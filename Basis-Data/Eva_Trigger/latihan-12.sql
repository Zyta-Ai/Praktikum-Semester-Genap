-- Active: 1722988556954@@127.0.0.1@3306@db_lkpd_12
CREATE DATABASE db_lkpd_12;

use db_lkpd_12;

CREATE Table tabel_barang (
    id_barang VARCHAR(10) PRIMARY KEY,
    nama_barang VARCHAR(50),
    stok INT
);

ALTER TABLE tabel_barang ADD COLUMN harga INT NOT NULL DEFAULT 0;


CREATE TABLE tabel_pembelian (
    id_pembelian INT PRIMARY KEY,
    id_barang VARCHAR(10),
    jumlah_beli INT,
    Foreign Key (id_barang) REFERENCES tabel_barang (id_barang)
);

CREATE TABLE pembayaran(
    id_pembayaran int PRIMARY KEY AUTO_INCREMENT,
    jumlah int,
    id_pembelian INT,
    Foreign Key (id_pembelian) REFERENCES tabel_pembelian(id_pembelian)
);

CREATE TABLE log_pembelian(
    id_log int AUTO_INCREMENT PRIMARY KEY,
    waktu TIMESTAMP,
    operasi VARCHAR(255)
);

INSERT INTO
    tabel_barang (id_barang, nama_barang, stok)
VALUES ("A10", "Mouse", 10),
    ("A11", "Keyboard", 15),
    ("A12", "DVD-RW", 19);

INSERT INTO
    tabel_pembelian (
        id_pembelian,
        id_barang,
        jumlah_beli
    )
VALUES (1, "A10", 5);


-- Trigger 1 untuk Stok Inkremen
DELIMITER ##

CREATE Trigger inkremenStok
BEFORE INSERT 
ON tabel_barang
FOR EACH ROW
BEGIN
    SET NEW.stok = NEW.stok + 1; 
END##

DELIMITER;

-- Trigger 2

DELIMITER ##

CREATE Trigger updateStok
AFTER INSERT 
ON tabel_pembelian
FOR EACH ROW
BEGIN
    UPDATE tabel_barang 
    SET stok = stok + NEW.jumlah_beli +
        (IF(NEW.jumlah_beli > 150 AND NEW.jumlah_beli < 250, 15,
            IF(NEW.jumlah_beli > 250 AND NEW.jumlah_beli < 350, 25,
                IF(NEW.jumlah_beli > 350, 50, 0)
            )
        ))
    WHERE id_barang = NEW.id_barang;

    INSERT INTO pembayaran(id_pembelian, jumlah)
    VALUES(
        NEW.id_pembelian,
        NEW.jumlah_beli * (SELECT harga FROM tabel_barang WHERE id_barang = NEW.id_barang)
    );

END##

DELIMITER;


-- Trigger 3
DELIMITER //

CREATE TRIGGER updateStokEdit
AFTER UPDATE 
ON tabel_pembelian
FOR EACH ROW 
BEGIN
UPDATE tabel_barang
SET stok = stok + (NEW.jumlah_beli - OLD.jumlah_beli)
WHERE id_barang = NEW.id_barang;

END//

DELIMITER;

-- Trigger 4
DELIMITER / /

CREATE TRIGGER deleteChild 
AFTER DELETE 
ON tabel_barang 
FOR EACH ROW 
BEGIN 
DELETE FROM pembelian 
WHERE id_barang = OLD.id_barang; 
END//
DELIMITER;
DROP Trigger inkremenStok

-- Trigger 5 untuk Log Pembelian Insert, Delete, Update

DELIMITER ++

CREATE Trigger log_insert
AFTER INSERT 
ON tabel_pembelian
FOR EACH ROW
BEGIN
    INSERT INTO log_pembelian(operasi) 
    VALUES ("Anda melakukan Operasi Insert ");
END++

DELIMITER ;

DELIMITER ++

CREATE Trigger log_update
AFTER UPDATE
ON tabel_pembelian
FOR EACH ROW
BEGIN
    INSERT INTO log_pembelian(operasi) 
    VALUES ("Anda melakukan Update");
END++

DELIMITER ;

DELIMITER ++

CREATE Trigger log_delete
AFTER DELETE
ON tabel_pembelian
FOR EACH ROW
BEGIN
    INSERT INTO log_pembelian(operasi) 
    VALUES ("Anda melakukan Insert");
END++

DELIMITER ;

INSERT INTO tabel_pembelian() 
VALUES(6, "A001", 10);

UPDATE tabel_pembelian
SET jumlah_beli = 10 
WHERE id_pembelian = 6;

DELETE FROM tabel_pembelian WHERE id_pembelian = 6

SELECT * FROM l