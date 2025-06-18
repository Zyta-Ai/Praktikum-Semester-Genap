-- Active: 1722988556954@@127.0.0.1@3306@db_toko_sebelah
CREATE DATABASE db_toko_sebelah;

CREATE TABLE pelanggan(
    pelanggan_id int PRIMARY KEY AUTO_INCREMENT,
    namaPelanggan VARCHAR(255),
    alamat TEXT,
    nomor_telepon VARCHAR(15)
);

CREATE TABLE penjualan(
    penjualan_id INT PRIMARY KEY AUTO_INCREMENT,
    tanggalPenjualan date,
    total_harga decimal(10,2),
    pelanggan_id INT,
    petugas_id INT,
    Foreign Key (pelanggan_id) REFERENCES pelanggan(pelanggan_id),
    Foreign Key (petugas_id) REFERENCES petugas(petugas_id)
);

CREATE Table detail_penjualan(
    detail_id INT PRIMARY KEY AUTO_INCREMENT,
    penjualan_id INT,
    produk_id INT,
    jumlah_produk INT,
    subtotal INT,
    Foreign Key (penjualan_id) REFERENCES penjualan(penjualan_id),
    Foreign Key (produk_id) REFERENCES produk(produk_id)
);

CREATE Table petugas(
    petugas_id INT PRIMARY KEY AUTO_INCREMENT,
    namaPetugas VARCHAR(255),
    username VARCHAR(100),
    password VARCHAR(255),
    role ENUM('Kepala Toko', 'Kasir')
);

CREATE TABLE produk(
    produk_id INT PRIMARY KEY AUTO_INCREMENT,
    nama_produk VARCHAR(255),
    harga decimal(10,2),
    stok INT
);


SELECT produk.nama_produk, COUNT(*) as jumlah_terjual FROM detail_penjualan 
JOIN produk ON detail_penjualan.produk_id = produk.produk_id
Group By detail_penjualan.produk_id
ORDER BY jumlah_terjual DESC LIMIT 10;


INSERT INTO pelanggan (namaPelanggan, alamat, nomor_telepon) VALUES
('Haruki Yamamoto', '1-2-3 Shibuya, Tokyo, Japan', '+81 80-1234-5678'),
('Aiko Tanaka', '4-5-6 Namba, Osaka, Japan', '+81 90-2345-6789'),
('Kenta Nakamura', '7-8-9 Sakae, Nagoya, Japan', '+81 70-3456-7890'),
('Yui Suzuki', '2-3-4 Tenjin, Fukuoka, Japan', '+81 80-4567-8901'),
('Ren Kobayashi', '5-6-7 Susukino, Sapporo, Japan', '+81 90-5678-9012');

SELECT * FROM detail_penjualan;

SELECT * FROM produk;

SELECT * FROM penjualan WHERE `tanggalPenjualan` <= DATETIME.NOW AND `tanggalPenjualan` ;

INSERT INTO petugas(namaPetugas,username, password, role) 
VALUES
("Ayano","ayanokouji",'ayano123','Kepala Toko'),
("Haruto",'haruto', "haruto123", "Kasir");

SELECT SUM(detail_penjualan.subtotal) FROM detail_penjualan\r\nJOIN penjualan\r\nON detail_penjualan.penjualan_id = penjualan.penjualan_id\r\nWHERE penjualan.tanggalPenjualan BETWEEN DATE_SUB(@tanggalSebelum, INTERVAL 7 DAY) AND @tanggalSesudah;

INSERT INTO produk (produk_id, nama_produk, harga, stok) VALUES
('TB001', 'Hujan', 63613.00, 26),
('TB002', 'Mars', 56818.00, 55),
('TB003', 'Pergi', 59507.00, 17),
('TB004', 'Rindu', 132099.00, 25),
('TB005', 'Tentang Kamu', 133028.00, 23),
('TB006', 'Bumi', 133179.00, 38),
('TB007', 'Bulan', 142373.00, 14),
('TB008', 'Matahari', 80059.00, 42),
('TB009', 'Bintang', 103507.00, 30),
('TB010', 'Komet', 101390.00, 15),
('KB011', 'Pemrograman Kotlin', 120000.00, 4),
('KB012', 'Pengembangan Aplikasi Android', 145000.00, 8),
('KB013', 'Pemrograman Ruby', 130000.00, 10),
('KB014', 'Framework Laravel', 140000.00, 6),
('KB015', 'Data Science dengan Python', 180000.00, 5),
('KB016', 'Pemrograman R', 150000.00, 7),
('KB017', 'Big Data Analytics', 200000.00, 4),
('KB018', 'Pemrograman PHP', 110000.00, 12),
('KB019', 'Pemrograman C++', 135000.00, 11),
('KB020', 'Cloud Computing', 175000.00, 6),
('KB021', 'Pemrograman Go', 125000.00, 5),
('KB022', 'Docker untuk Pemula', 145000.00, 10),
('KB023', 'Kubernetes Basics', 165000.00, 9),
('KB024', 'Pemrograman Swift', 140000.00, 7),
('KB025', 'Pemrograman Dart', 135000.00, 8),
('KB026', 'Framework Flutter', 160000.00, 6),
('KB027', 'Pemrograman Rust', 155000.00, 5),
('KB028', 'Pemrograman Scala', 145000.00, 4),
('KB029', 'Pemrograman Julia', 130000.00, 6),
('KB030', 'Blockchain Fundamentals', 190000.00, 3),
('KB031', 'Cryptocurrency Basics', 175000.00, 4),
('KB032', 'Pemrograman Solidity', 185000.00, 5),
('KB033', 'Smart Contracts', 200000.00, 6),
('KB034', 'Pemrograman Matlab', 145000.00, 10),
('KB035', 'Pemrograman VBA', 120000.00, 8),
('KB036', 'Statistika untuk Data Science', 160000.00, 6),
('KB037', 'Pemrograman JavaScript', 135000.00, 9),
('KB038', 'Framework ReactJS', 140000.00, 7),
('KB039', 'Framework Angular', 150000.00, 8),
('KB040', 'Framework VueJS', 130000.00, 10);


-- 1
SELECT SUM(total_harga) AS penjualan_hari_ini
FROM penjualan
WHERE tanggalPenjualan = CURDATE();

SELECT SUM(total_harga) AS penjualan_hari_kemarin
FROM penjualan
WHERE tanggalPenjualan = CURDATE() - INTERVAL 1 DAY;

SELECT MONTH(tanggalPenjualan) AS bulan, SUM(total_harga) AS total 
FROM penjualan 
GROUP BY bulan 
ORDER BY bulan;

SELECT * FROM penjualan 

SELECT COUNT(*) as total_penjualan FROM penjualan;

-- Soal 1

SELECT SUM(subtotal * 20 / 100) as total_penjualan FROM detail_penjualan;

-- Soal 2
SELECT produk.nama_produk, SUM(detail_penjualan.jumlah_produk) as total_penjualan FROM detail_penjualan
JOIN penjualan 
ON detail_penjualan.penjualan_id = penjualan.pelanggan_id
JOIN produk
ON detail_penjualan.produk_id = produk.produk_id
GROUP BY produk.produk_id;

-- Soal 3
SELECT nama_produk, harga FROM produk
ORDER BY harga DESC;

-- Soal 4
SELECT pelanggan.namaPelanggan, COUNT(penjualan.pelanggan_id) as total_transaksi FROM penjualan
JOIN pelanggan =
ON penjualan.pelanggan_id = pelanggan.pelanggan_id
GROUP BY penjualan.pelanggan_id;

-- Soal 5
SELECT AVG(harga * stok) AS rata_rata_harga
FROM produk
WHERE stok > 0;


-- Soal 6
SELECT pelanggan.namaPelanggan, petugas.namaPetugas FROM penjualan
JOIN pelanggan
ON penjualan.pelanggan_id = pelanggan.pelanggan_id
JOIN petugas
ON penjualan.petugas_id = petugas.petugas_id
GROUP BY penjualan.pelanggan_id;

-- Soal 7
SELECT pelanggan.namaPelanggan as nama_pelanggan, produk.nama_produk as produk_yang_dibeli FROM detail_penjualan
JOIN penjualan 
ON detail_penjualan.penjualan_id = penjualan.pelanggan_id
JOIN produk
ON detail_penjualan.produk_id = produk.produk_id
JOIN pelanggan
ON penjualan.pelanggan_id = pelanggan.pelanggan_id
GROUP BY penjualan.pelanggan_id;

-- Soal 8
SELECT pelanggan.namaPelanggan, penjualan.total_harga FROM detail_penjualan
JOIN penjualan 
ON detail_penjualan.penjualan_id = penjualan.pelanggan_id
JOIN produk
ON detail_penjualan.produk_id = produk.produk_id
JOIN pelanggan
ON penjualan.pelanggan_id = pelanggan.pelanggan_id
WHERE penjualan.total_harga > 1000
GROUP BY penjualan.pelanggan_id;

-- Soal 9 & 10
DELIMITER //

CREATE TRIGGER kurangi_stok
BEFORE INSERT ON detail_penjualan
FOR EACH ROW
BEGIN
    DECLARE stok_tersedia INT;

    -- Ambil stok produk
    SELECT stok INTO stok_tersedia
    FROM produk
    WHERE produk_id = NEW.produk_id;

    -- Cek apakah stok cukup
    IF stok_tersedia < NEW.jumlah_produk THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Stok produk tidak cukup untuk transaksi ini';
    ELSE
        -- Kurangi stok
        UPDATE produk
        SET stok = stok - NEW.jumlah_produk
        WHERE produk_id = NEW.produk_id;
    END IF;
END;//

DELIMITER ;

SELECT *
FROM penjualan 
JOIN pelanggan ON penjualan.pelanggan_id = pelanggan.pelanggan_id 
JOIN petugas ON penjualan.petugas_id = petugas.petugas_id
WHERE penjualan.tanggalPenjualan BETWEEN '2025-04-01' AND '2025-04-17' 
ORDER BY penjualan.tanggalPenjualan DESC;

SELECT * FROM penjualan;

SELECT COUNT(*) FROM penjualan WHERE `tanggalPenjualan` = DATE_SUB('2025-04-01', INTERVAL 7 DAY);

SELECT COUNT(*) FROM penjualan WHERE `tanggalPenjualan` BETWEEN DATE_SUB('2025-04-17', INTERVAL 17 DAY) AND '2025-04-17';

SELECT * FROM penjualan ORDER BY `tanggalPenjualan` ASC;

SELECT COUNT(*) FROM penjualan WHERE tanggalPenjualan BETWEEN DATE_SUB('@tanggalSebelum', INTERVAL 7 DAY) AND '@tanggalSesudah';
--  WHERE tanggalPenjualan BETWEEN DATE_SUB(@tanggalSebelum, INTERVAL 7 DAY) AND @tanggalSesudah
    
SELECT SUM(detail_penjualan.subtotal * 20/100) FROM detail_penjualan
JOIN penjualan
ON detail_penjualan.penjualan_id = penjualan.penjualan_id
WHERE penjualan.tanggalPenjualan BETWEEN DATE_SUB('2025-04-17', INTERVAL 7 DAY) AND '2025-04-17';

SELECT SUM(subtotal) as total_penjualan FROM detail_penjualan;

    SELECT MONTH(tanggalPenjualan) AS bulan, COUNT(*) AS total_penjualan FROM penjualan GROUP BY bulan ORDER BY bulan


SELECT produk.nama_produk, SUM(detail_penjualan.jumlah_produk) AS total_penjualan
FROM detail_penjualan
JOIN produk ON detail_penjualan.produk_id = produk.produk_id
JOIN penjualan ON detail_penjualan.penjualan_id = penjualan.penjualan_id
WHERE penjualan.tanggalPenjualan BETWEEN DATE_SUB('2025-04-25', INTERVAL 30 DAY) AND '2025-04-25'
GROUP BY produk.produk_id, produk.nama_produk
ORDER BY total_penjualan DESC
LIMIT 10;

SELECT * FROM penjualan

INSERT INTO penjualan (penjualan_id, tanggalPenjualan, pelanggan_id) VALUES
(95, '2025-04-20', 2);

INSERT INTO detail_penjualan (penjualan_id, produk_id, jumlah_produk, subtotal) VALUES
(95, 3, 2, 40000), -- Produk 3, harga 20,000 x 2
(95, 5, 1, 50000); -- Produk 5, harga 50,000 x 1