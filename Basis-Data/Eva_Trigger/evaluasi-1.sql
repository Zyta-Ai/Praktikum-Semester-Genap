-- Active: 1722988556954@@127.0.0.1@3306@db_evalusi_trigger

-- Soal Nomor 1
CREATE DATABASE db_evalusi_trigger;


-- Soal Nomor 2
CREATE TABLE anggota (
    id_anggota INT PRIMARY KEY AUTO_INCREMENT,
    kode_anggota CHAR(10),
    nama_lengkap VARCHAR(50),
    alamat TEXT,
    no_telepon VARCHAR(13),
    jenis_kelamin ENUM ('Pria', 'Wanita')
);

DROP Table anggota, buku

CREATE TABLE buku (
    id_buku INT PRIMARY KEY AUTO_INCREMENT,
    kode_buku CHAR(5),
    judul_buku VARCHAR(50),
    penulis_buku VARCHAR(50),
    penerbit_buku VARCHAR(50),
    tahun_terbit YEAR,
    stok TINYINT
);

CREATE TABLE peminjaman (
    id_peminjaman INT PRIMARY KEY AUTO_INCREMENT,
    tanggal_pinjam DATE,
    tanggal_kembali DATE,
    id_buku INT,
    id_anggota INT,
    jumlah_buku TINYINT,
    FOREIGN KEY (id_buku) REFERENCES buku(id_buku),
    FOREIGN KEY (id_anggota) REFERENCES anggota(id_anggota)
);

CREATE TABLE pengembalian (
    id_pengembalian INT PRIMARY KEY AUTO_INCREMENT,
    tanggal_kembali DATE,
    jumlah_buku TINYINT,
    id_buku INT,
    id_anggota INT,
    denda BIGINT,
    id_peminjaman INT,
    Foreign Key (id_buku) REFERENCES buku(id_buku),
    Foreign Key (id_anggota) REFERENCES anggota(id_anggota),
    Foreign Key (id_peminjaman) REFERENCES peminjaman(id_peminjaman)
);

-- Soal Nomor 3

INSERT INTO buku (id_buku, kode_buku, judul_buku, penulis_buku, penerbit_buku, tahun_terbit, stok)
VALUES
    (1, 'B001', 'Laskar Pelangi', 'Andrea Hirata', 'Bentang Pustaka', 2005, 10),
    (2, 'B002', 'Sang Pemimpi', 'Andrea Hirata', 'Bentang Pustaka', 2006, 5);

    INSERT INTO anggota (id_anggota, kode_anggota, nama_lengkap, alamat, no_telepon, jenis_kelamin)
VALUES
    (1, 'A001', 'Budi Santoso', 'Jl. Merdeka No. 1', '081234567890', 'Pria'),
    (2, 'A002', 'Siti Nurhaliza', 'Jl. Mawar No. 2', '089876543210', 'Wanita');


-- Soal Nomor 4 :

DROP TRIGGER cek_peminjaman

DELIMITER ##

CREATE TRIGGER cek_peminjaman
BEFORE INSERT 
ON peminjaman
FOR EACH ROW 
BEGIN
    -- Soal A: Mengecek apakah Anggota masih ada buku yang dipinjam
    IF (SELECT COUNT(*) FROM peminjaman 
      WHERE id_anggota = NEW.id_anggota AND tanggal_kembali IS NULL) > 0 THEN

        SIGNAL SQLSTATE '45000' 
        SET MESSAGE_TEXT = 'Peminjaman dibatalkan: Masih ada buku yang belum dikembalikan.';

    -- Soal B : Jika stok kurang
    ELSEIF (SELECT stok FROM buku WHERE id_buku = NEW.id_buku) < NEW.jumlah_buku THEN
        SIGNAL SQLSTATE '45000'

        SET MESSAGE_TEXT = "Peminjaman dibatalkan: Stok tidak Cukup";
    -- Soal C : Jika berhasil maka kurangin Stok
    ELSE
        UPDATE buku SET stok = stok - NEW.jumlah_buku WHERE id_buku = NEW.id_buku;
    END IF;
END##

DELIMITER ;

INSERT INTO peminjaman(tanggal_pinjam, tanggal_kembali,  id_anggota, id_buku, jumlah_buku) 
VALUES
('2025-01-01', '2025-02-01', 1, 1, 1);


-- Anggota Pinjam Buku ke 1 | Berhasil
INSERT INTO peminjaman (tanggal_pinjam, id_buku, id_anggota, jumlah_buku)
VALUES ('2024-05-15', 1, 1, 1);

-- Anggota Pinjam Buku ke 2 | Gagal 
INSERT INTO peminjaman (tanggal_pinjam, id_buku, id_anggota, jumlah_buku)
VALUES ('2024-05-16', 2, 1, 1);

-- Anggota ke 2 meminjam buku lebih banyak dari stok | Gagal
INSERT INTO peminjaman (tanggal_pinjam, id_buku, id_anggota, jumlah_buku)
VALUES ('2024-05-16', 2, 2, 10);


-- Anggota ke 2 meminjam buku cukup pada stok :
INSERT INTO peminjaman (tanggal_pinjam, id_buku, id_anggota, jumlah_buku)
VALUES ('2024-05-16', 2, 2, 1);

SELECT * FROM buku

-- Soal Nomor 5 || Ga tau bener apa enggak;

DELIMITER $$

CREATE Trigger pengembalian_solve
AFTER INSERT
ON pengembalian
FOR EACH ROW
BEGIN 
    DECLARE tgl_pinjam DATE;
    SELECT tanggal_pinjam INTO tgl_pinjam FROM peminjaman
    WHERE id_peminjaman = NEW.id_peminjaman;

    IF NEW.tanggal_kembali > tgl_pinjam THEN
        UPDATE pengembalian
        SET denda = 2000 * DATEDIFF(NEW.tanggal_kembali, tgl_pinjam)
        WHERE id_pengembalian = NEW.id_pengembalian;
    ELSE
        UPDATE pengembalian
        SET denda = 0
        WHERE id_pengembalian = NEW.id_pengembalian;
    END IF;

    UPDATE buku
    SET stok = stok + NEW.jumlah_buku
    WHERE id_buku = NEW.id_buku;
END$$

DELIMITER ;



