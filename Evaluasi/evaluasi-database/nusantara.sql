-- Active: 1722988556954@@127.0.0.1@3306@db_nusantara
CREATE DATABASE db_nusantara;

CREATE TABLE user(
    id INT AUTO_INCREMENT PRIMARY KEY,
    nama_depan VARCHAR(50),
    nama_belakang VARCHAR(50),
    email VARCHAR(50),
    kata_sandi VARCHAR(50)
);

INSERT INTO user(nama_depan, nama_belakang, email, kata_sandi) 
VALUES
('Ayanokouji', 'Kiyotaka', 'ayano@gmail.com', 'Ayano123');


SELECT email FROM user WHERE email LIKE "%@gmail.com%";



CREATE TABLE member (
    member_id VARCHAR(10) PRIMARY KEY,
    nama VARCHAR(50),
    tanggal_lahir DATE,
    alamat TEXT,
    provinsi_id INT,
    kabupaten_id INT,
    kecamatan_id INT,
    nomor_telepon VARCHAR(13),
    jenis_kelamin ENUM('Pria', 'Wanita'),
    agama ENUM('Islam', 'Kristen', 'Katolik', 'Hindu', 'Buddha', 'Konghucu')
);

INSERT INTO member() VALUES(3, "Ghaisan", "2005-04-01", "Jepang", "Jakart Selatan", "Blok M", "Blok M", "08123456789", "Pria", "Islam");



DROP Table member

create table provinsi(
	id int primary key, 
    nama varchar(255)
);

CREATE TABLE kabupaten(
	id int primary key,
	provinsi_id int,
	nama varchar(255)
);

CREATE TABLE kecamatan(
	id varchar(20) primary key,
	kabupaten_id int,
	nama varchar(255)
);