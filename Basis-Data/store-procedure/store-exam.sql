-- Active: 1722988556954@@127.0.0.1@3306@db_learn_procedure

-- Soal 1
CREATE TABLE produk(
    id_produk int AUTO_INCREMENT PRIMARY KEY,
    nama_produk VARCHAR(100),
    harga DECIMAL(10,2),
    stok INT
);

CREATE Procedure tambah_produk(produk VARCHAR(100), harga_produk DECIMAL(10,2))
BEGIN
    INSERT INTO produk(nama_produk, harga) VALUES(produk, harga_produk);
END;

CALL tambah_produk('Jam Tangan Mahal Broo!', 100000.00);

-- Soal 2
CREATE Table penjualan(
    id_penjualan INT PRIMARY KEY AUTO_INCREMENT,
    tanggal_penjualan DATE,
    total_harga DECIMAL(10,2)
);

CREATE Procedure hitung_total_penjualan(IN bulan_penjualan INT,IN tahun_penjualan INT, OUT total_penjualan DECIMAL(10,2))
BEGIN
    SELECT SUM(total_harga) INTO total_penjualan FROM penjualan WHERE MONTH(tanggal_penjualan) = bulan_penjualan AND YEAR(tanggal_penjualan) = tahun_penjualan;
END;

INSERT INTO penjualan (id_penjualan, tanggal_penjualan, total_harga) 
VALUES 
    (1, '2024-03-01', 150000.00),
    (2, '2024-03-15', 200000.00),
    (3, '2024-04-01', 300000.00);


CALL hitung_total_penjualan(3, 2024, @total);
SELECT @total AS Total_Penjualan;

-- Soal 3
CREATE TABLE produk(
    id_produk int AUTO_INCREMENT PRIMARY KEY,
    nama_produk VARCHAR(100),
    harga DECIMAL(10,2),
    stok INT
);

CREATE Procedure hitung_stok_tersedia(
    OUT total_stok INT
)
BEGIN
    SELECT SUM(stok) INTO total_stok FROM produk WHERE stok > 0;
END;


CALL hitung_stok_tersedia(@total_stok);
SELECT @total_stok AS Total_Stok_Tersedia;

-- Soal 4
CREATE TABLE pelanggan_toko(
    id_pelanggan INT PRIMARY KEY,
    nama_pelanggan VARCHAR(100)
);

CREATE TABLE pembelian (
    id_pembelian INT PRIMARY KEY,
    id_pelanggan INT,
    total_harga DECIMAL(10,2),
    FOREIGN KEY (id_pelanggan) REFERENCES pelanggan_toko(id_pelanggan)
);

INSERT INTO pelanggan_toko (id_pelanggan, nama_pelanggan) VALUES
    (1, 'Andi'),
    (2, 'Budi');

INSERT INTO pembelian (id_pembelian, id_pelanggan, total_harga) VALUES
    (1, 1, 50000.00),
    (2, 2, 75000.00),
    (3, 1, 25000.00);

DELIMITER //    

CREATE Procedure pelanggan_pembelian_tertinggi(
    OUT nama_pelanggan_tertinggi VARCHAR(100)
)
BEGIN
    SELECT pelanggan_toko.nama_pelanggan INTO nama_pelanggan_tertinggi FROM pelanggan_toko 
    JOIN pembelian 
    ON pelanggan_toko.id_pelanggan = pembelian.id_pelanggan
    GROUP BY pelanggan_toko.id_pelanggan, pelanggan_toko.nama_pelanggan
    ORDER BY SUM(pembelian.total_harga) DESC
    LIMIT 1;
END;

DROP Procedure pelanggan_pembelian_tertinggi;

CALL pelanggan_pembelian_tertinggi(@nama);
SELECT @nama as nama_pelanggan;

-- Soal 5
CREATE PROCEDURE rata_rata_pembelian_bulanan(
    IN id_pelanggan INT,
    OUT rata_rata_total_bulanan DECIMAL(10,2)
)
BEGIN
    SELECT AVG(total_per_bulan) INTO rata_rata_total_bulanan
    FROM (
        SELECT SUM(total_harga) AS total_per_bulan
        FROM pembelian
        WHERE id_pelanggan = id_pelanggan
        GROUP BY YEAR(tanggal_pembelian), MONTH(tanggal_pembelian)
    ) AS tabel_total_bulanan;
END 

CALL rata_rata_pembelian_bulanan(1, @rata_rata);
SELECT @rata_rata AS Rata_Rata_Pembelian_Bulanan;

-- Soal 6
CREATE PROCEDURE hitung_laba_bersih(
    IN persentase_pajak DECIMAL(5,2),
    OUT laba_bersih DECIMAL(10,2)
)
BEGIN
    DECLARE total_penjualan DECIMAL(10,2);
    DECLARE total_pengeluaran DECIMAL(10,2);
    DECLARE jumlah_pajak DECIMAL(10,2);

    SELECT SUM(total_harga) INTO total_penjualan
    FROM penjualan;

    SELECT SUM(total_biaya) INTO total_pengeluaran
    FROM pengeluaran;

    SET jumlah_pajak = total_penjualan * (persentase_pajak / 100);

    SET laba_bersih = total_penjualan - total_pengeluaran - jumlah_pajak;
END

CALL hitung_laba_bersih(20, @laba_bersih);
SELECT @laba_bersih AS Laba_Bersih;

-- Soal 7

CREATE PROCEDURE produk_stok_minimum(
    IN stok_minimum INT
)
BEGIN
    SELECT id_produk, nama_produk, stok
    FROM produk
    WHERE stok < stok_minimum;
END

CALL produk_stok_minimum(6);

