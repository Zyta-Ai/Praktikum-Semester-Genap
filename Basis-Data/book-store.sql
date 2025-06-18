-- Active: 1722988556954@@127.0.0.1@3306@db_toko
CREATE DATABASE db_toko;
CREATE TABLE pelanggan (
    pelangganId INT PRIMARY KEY AUTO_INCREMENT,
    namaPelanggan VARCHAR(100) NOT NULL,
    alamat VARCHAR(255),
    nomorTelepon VARCHAR(15)
);
CREATE TABLE petugas (
    petugasId INT PRIMARY KEY AUTO_INCREMENT,
    namaPetugas VARCHAR(100) NOT NULL,
    username VARCHAR(50) UNIQUE NOT NULL,
    password VARCHAR(50) NOT NULL,
    role VARCHAR(50) NOT NULL
);
CREATE TABLE produk (
    produkId INT PRIMARY KEY AUTO_INCREMENT,
    namaProduk VARCHAR(100) NOT NULL,
    harga INT NOT NULL,
    stok INT NOT NULL
);

DESC pelanggan;

