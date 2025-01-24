-- Active: 1722988556954@@127.0.0.1@3306@db_evaluasitrigger
CREATE DATABASE db_evaluasiTrigger;

CREATE TABLE Siswa (
    nis INT PRIMARY KEY,
    nama VARCHAR(100),
    alamat VARCHAR(255),
    no_telp VARCHAR(20),
    tanggal_lahir DATE
);

CREATE TABLE LogSiswa (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nis INT,
    deskripsi VARCHAR(255),
    waktu TIMESTAMP
);

CREATE TABLE LogHp (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nis INT,
    no_telp_lama VARCHAR(20),
    no_telp_baru VARCHAR(20),
    waktu TIMESTAMP   
);

DROP TABLE logsiswa, loghp, siswa

-- Menambahkan Data Trigger

INSERT INTO siswa(nis, nama, alamat, no_telp, tanggal_lahir) 
VALUES
(1001002, 'Ara', 'Purwakarta', 081122445566, '2001-12-1')

DELIMITER $$

CREATE TRIGGER add_siswa
AFTER INSERT
ON Siswa
FOR EACH ROW
BEGIN
   INSERT INTO logsiswa(nis, deskripsi) VALUES(NEW.nis, 'Siswa Di Tambahkan');
END$$

DELIMITER ;

SELECT * FROM logsiswa


-- Mengupdate Data Trigger
DELIMITER $$

CREATE TRIGGER update_siswa
AFTER UPDATE
ON Siswa
FOR EACH ROW
BEGIN
    INSERT INTO logsiswa(nis, deskripsi) VALUES(OLD.nis, 'Siswa Diperbaharui');
END$$

DELIMITER ;

UPDATE siswa SET nama = 'Ari' WHERE nis = 1001001;

SELECT * FROM logsiswa


-- Delete Trigger

DELIMITER $$

CREATE TRIGGER delete_siswa
AFTER DELETE 
ON Siswa
FOR EACH ROW
BEGIN
    INSERT INTO logsiswa(nis, deskripsi) VALUES(OLD.nis, 'Siswa Dihapus');
END$$

DELIMITER ;

DELETE FROM siswa WHERE nis = 1001002

SELECT * FROM logsiswa


-- Mencatat Perubahan NoHp
DELIMITER $$

CREATE Trigger update_no_hp
AFTER UPDATE
ON Siswa
FOR EACH ROW
BEGIN
    INSERT INTO loghp(nis, no_telp_baru, no_telp_lama) VALUES(OLD.nis, NEW.no_telp, OLD.no_telp);
END$$

DELIMITER ;

UPDATE siswa SET no_telp = '08123456789' WHERE nis = 1001001;

SELECT * FROM loghp



