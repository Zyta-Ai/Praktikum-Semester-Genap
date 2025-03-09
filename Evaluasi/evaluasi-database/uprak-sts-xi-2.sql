-- Active: 1722988556954@@127.0.0.1@3306@uprak_3_ghaisan
CREATE DATABASE uprak_3_ghaisan;

CREATE Table produk(
    kode_produk VARCHAR(50) PRIMARY KEY,
    deskripsi TEXT,
    harga_beli INT,
    harga_jual INT,
    stok INT
);

CREATE TABLE log_produk_harga(
    id INT PRIMARY KEY AUTO_INCREMENT,
    kode_produk VARCHAR(50),
    harga_beli int,
    harga_jual INT,
    created_at DATE,
    Foreign Key (kode_produk) REFERENCES produk(kode_produk)
);

CREATE TABLE penjualan(
    id INT PRIMARY KEY AUTO_INCREMENT,
    kode_produk VARCHAR(50),
    tanggal DATE,
    jumlah INT,
    Foreign Key (kode_produk) REFERENCES log_produk_harga(kode_produk)
);

INSERT INTO produk() 
VALUES
('MAO-001', 'Pertamina 1L', 45000, 60000, 5),
('MAO-002', 'Fastron 1L', 80000, 110000, 4),
('SAO-001', 'Shell Helix Premium 1L', 56000, 72000, 10),
('SAO-002', 'Shell Helix Ultra 1L', 120000, 145000, 5);


DELIMITER $$

CREATE Trigger log_produk_change
AFTER UPDATE
ON produk
FOR EACH ROW
BEGIN
    -- Data Sebelum Berubah
    INSERT INTO log_produk_harga(kode_produk, harga_beli, harga_jual, created_at) 
    VALUES(OLD.kode_produk, OLD.harga_beli, OLD.harga_jual, CURRENT_DATE);

    -- Data Setelah Berubah
    INSERT INTO log_produk_harga(kode_produk, harga_beli, harga_jual, created_at) 
    VALUES(NEW.kode_produk, NEW.harga_beli, NEW.harga_jual, CURRENT_DATE);
END$$

DELIMITER ;

DELIMITER ##

CREATE TRIGGER produk_stok
AFTER INSERT
ON penjualan
FOR EACH ROW
BEGIN
    DECLARE current_stock INT;
    SELECT stok INTO current_stock FROM produk WHERE kode_produk = NEW.kode_produk;

    IF current_stock <= NEW.jumlah THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Penjualan Dibatalkan: Stok tidak mencukupi!';
    ELSE
        UPDATE produk
        SET stok = stok - NEW.jumlah 
        WHERE kode_produk = NEW.kode_produk;
    END IF;
END##

DELIMITER ;

-- Debuggin and Testing 
SELECT * FROM log_produk_harga;

UPDATE produk
SET stok = 10
WHERE kode_produk = 'MAO-001';

UPDATE produk
SET harga_jual = 65000
WHERE kode_produk = 'MAO-001';


SELECT * FROM produk;
INSERT INTO penjualan(kode_produk, tanggal, jumlah) 
VALUES('MAO-001', CURRENT_DATE, 10);



