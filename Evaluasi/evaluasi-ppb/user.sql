-- Active: 1722988556954@@127.0.0.1@3306@db_uprak_genap
CREATE DATABASE db_uprak_genap;

CREATE TABLE user(
    id INT AUTO_INCREMENT PRIMARY KEY,
    nama_lengkap VARCHAR(50),
    email VARCHAR(50),
    tanggal_lahir DATE,
    password VARCHAR(30)
);

SELECT * FROM user;

INSERT INTO user(nama_lengkap,email,tanggal_lahir,password) VALUES(nama_lengkap = '', email ='', tanggal_lahir='', password='')

DELETE FROM user WHERE id = 3;