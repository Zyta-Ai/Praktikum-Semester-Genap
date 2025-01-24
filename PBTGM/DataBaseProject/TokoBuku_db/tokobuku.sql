-- Active: 1722988556954@@127.0.0.1@3306@db_tokobuku
CREATE DATABASE db_tokoBuku;

-- Membuat database
CREATE DATABASE IF NOT EXISTS toko_buku;
USE toko_buku;


CREATE TABLE users (
    id_user INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) UNIQUE,
    password VARCHAR(255),
    role ENUM('admin', 'kasir') 
);

INSERT INTO users(id_user, username, password, role) 
VALUES
(2, "Kasir", "kasir123","kasir");

CREATE TABLE books (
    id_buku INT AUTO_INCREMENT PRIMARY KEY,
    kode_buku VARCHAR(20) UNIQUE,
    judul VARCHAR(100),
    pengarang VARCHAR(100),
    penerbit VARCHAR(100),
    harga DECIMAL(10, 2),
    stok INT 
);

DELETE FROM books WHERE id_buku = @id_buku

CREATE TABLE transactions (
    id_transaksi INT AUTO_INCREMENT PRIMARY KEY,
    tanggal DATETIME  DEFAULT CURRENT_TIMESTAMP,
    total_harga DECIMAL(15, 2),
    id_user INT,
    FOREIGN KEY (id_user) REFERENCES users(id_user)
);

CREATE TABLE transaction_details (
    id_detail INT AUTO_INCREMENT PRIMARY KEY,
    id_transaksi INT,
    id_buku INT,
    jumlah INT,
    subtotal DECIMAL(15, 2),
    FOREIGN KEY (id_transaksi) REFERENCES transactions(id_transaksi),
    FOREIGN KEY (id_buku) REFERENCES books(id_buku)
);

-- Tabel Diskon
CREATE TABLE discounts (
    id_diskon INT AUTO_INCREMENT PRIMARY KEY,
    nama_diskon VARCHAR(100),
    deskripsi TEXT,
    jenis_diskon ENUM('persentase', 'nominal'),    
    nilai_diskon DECIMAL(10, 2),   
    minimal_pembelian DECIMAL(10, 2) DEFAULT 0,
    tanggal_mulai DATETIME,
    tanggal_selesai DATETIME, 
    aktif BOOLEAN DEFAULT TRUE 
);


SELECT role FROM users WHERE username = @username AND password = @passwords

INSERT INTO books (id_buku, kode_buku, judul, pengarang, penerbit, harga, stok) VALUES 
('11', 'KB011', 'Pemrograman Kotlin', 'Rachel Adams', 'AndroidBooks', 120000, 4),
('12', 'KB012', 'Pengembangan Aplikasi Android', 'Oliver Wright', 'MobileMasters', 145000, 8),
('13', 'KB013', 'Pemrograman Ruby', 'Sophia Walker', 'CodeWorld', 130000, 10),
('14', 'KB014', 'Framework Laravel', 'Henry Young', 'WebWorld', 140000, 6),
('15', 'KB015', 'Data Science dengan Python', 'Grace Allen', 'DataBooks', 180000, 5),
('16', 'KB016', 'Pemrograman R', 'Jacob Harris', 'DataMasters', 150000, 7),
('17', 'KB017', 'Big Data Analytics', 'Victoria Campbell', 'BigDataPress', 200000, 4),
('18', 'KB018', 'Pemrograman PHP', 'Daniel Martinez', 'CodeMasters', 110000, 12),
('19', 'KB019', 'Pemrograman C++', 'Ella Lopez', 'TechBooks', 135000, 11),
('20', 'KB020', 'Cloud Computing', 'Mason Clark', 'CloudWorld', 175000, 6),
('21', 'KB021', 'Pemrograman Go', 'Liam Robinson', 'CodeBooks', 125000, 5),
('22', 'KB022', 'Docker untuk Pemula', 'Evelyn Lewis', 'DevOpsPress', 145000, 10),
('23', 'KB023', 'Kubernetes Basics', 'Aiden Walker', 'CloudBooks', 165000, 9),
('24', 'KB024', 'Pemrograman Swift', 'Charlotte Nelson', 'MobileBooks', 140000, 7),
('25', 'KB025', 'Pemrograman Dart', 'Benjamin Perez', 'FlutterMasters', 135000, 8),
('26', 'KB026', 'Framework Flutter', 'Harper Baker', 'FlutterWorld', 160000, 6),
('27', 'KB027', 'Pemrograman Rust', 'Jack Thompson', 'CodeMasters', 155000, 5),
('28', 'KB028', 'Pemrograman Scala', 'Luna Harris', 'BigDataBooks', 145000, 4),
('29', 'KB029', 'Pemrograman Julia', 'Nathan Collins', 'DataBooks', 130000, 6),
('30', 'KB030', 'Blockchain Fundamentals', 'Emma Evans', 'BlockchainBooks', 190000, 3),
('31', 'KB031', 'Cryptocurrency Basics', 'James Carter', 'CryptoBooks', 175000, 4),
('32', 'KB032', 'Pemrograman Solidity', 'Sophia Hill', 'BlockchainMasters', 185000, 5),
('33', 'KB033', 'Smart Contracts', 'William Turner', 'SmartContractsPress', 200000, 6),
('34', 'KB034', 'Pemrograman Matlab', 'Lucas Allen', 'TechBooks', 145000, 10),
('35', 'KB035', 'Pemrograman VBA', 'Amelia Ramirez', 'ExcelMasters', 120000, 8),
('36', 'KB036', 'Statistika untuk Data Science', 'Henry Cox', 'DataBooks', 160000, 6),
('37', 'KB037', 'Pemrograman JavaScript', 'Mila Ward', 'WebWorld', 135000, 9),
('38', 'KB038', 'Framework ReactJS', 'Oliver Reed', 'CodeBooks', 140000, 7),
('39', 'KB039', 'Framework Angular', 'Sophie White', 'WebMasters', 150000, 8),
('40', 'KB040', 'Framework VueJS', 'Levi Brooks', 'FrontendBooks', 130000, 10),
('41', 'KB041', 'Pemrograman Bash', 'Isabella Gray', 'LinuxBooks', 110000, 5),
('42', 'KB042', 'Pemrograman Perl', 'Eli Griffin', 'CodeMasters', 125000, 4),
('43', 'KB043', 'Pemrograman Shell', 'Emma Murphy', 'LinuxPress', 120000, 6),
('44', 'KB044', 'Pemrograman Fortran', 'Noah Alexander', 'CodeBooks', 140000, 5),
('45', 'KB045', 'Pemrograman COBOL', 'Chloe Peterson', 'LegacyBooks', 150000, 4),
('46', 'KB046', 'Pemrograman Pascal', 'Lucas Hayes', 'TechBooks', 135000, 6),
('47', 'KB047', 'Pemrograman Delphi', 'Sophia Rogers', 'CodeMasters', 140000, 7),
('48', 'KB048', 'Pemrograman ASP.NET', 'Mason Howard', 'WebMasters', 160000, 5),
('49', 'KB049', 'Framework Django', 'Charlotte James', 'CodeBooks', 145000, 8),
('50', 'KB050', 'Framework Flask', 'Liam Green', 'WebBooks', 140000, 7);

SELECT judul FROM books WHERE id_buku LIKE @keyword OR kode_buku LIKE @keyword OR judul LIKE @keyword
LIMIT 5;