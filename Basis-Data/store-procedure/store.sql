-- Active: 1722988556954@@127.0.0.1@3306@db_learn_procedure
CREATE DATABASE db_learn_procedure;

CREATE TABLE pelanggan(
    id_pelanggan int AUTO_INCREMENT PRIMARY KEY,
    nama VARCHAR(100),
    alamat VARCHAR(200)
);

CREATE TABLE logPelanggan(
    id INT AUTO_INCREMENT PRIMARY KEY,
    nama VARCHAR(100),
    waktu_input DATETIME DEFAULT CURRENT_TIMESTAMP()
); 

CREATE Procedure tambah_pelanggan(nama_pelanggan VARCHAR(100), alamat_pelanggan VARCHAR(200))
BEGIN
    INSERT INTO pelanggan (nama, alamat) VALUES (nama_pelanggan, alamat_pelanggan);

    INSERT INTO logpelanggan(nama) VALUES (nama_pelanggan);
END;

CALL tambah_pelanggan ('Budi', 'Jakarta');

SELECT * FROM logpelanggan