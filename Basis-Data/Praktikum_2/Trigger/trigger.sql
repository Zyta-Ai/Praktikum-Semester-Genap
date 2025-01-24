-- Active: 1722988556954@@127.0.0.1@3306@db_trigger
CREATE DATABASE db_trigger;

CREATE Table karyawan (
    id BIGINT PRIMARY KEY,
    nama VARCHAR(50),
    nohp VARCHAR(13),
    jabatan VARCHAR(100)
);

CREATE TABLE rekap(
    id INT PRIMARY KEY,
    karyawan_id BIGINT,
    jumlah_hari INT,
    Foreign Key (karyawan_id) REFERENCES karyawan(id)
);

CREATE TABLE absensi(
    id BIGINT PRIMARY KEY,
    tanggal DATE,
    karyawan_id BIGINT,
    Foreign Key (karyawan_id) REFERENCES karyawan(id)
);

INSERT INTO karyawan(id,nama,nohp,jabatan) 
VALUES
(1,"Sodikhin","08123456789","Direktur"),
(2,"Melatin","08987654321","Manager");

INSERT INTO rekap(id, karyawan_id, jumlah_hari) 
VALUES
(3, 1, 0);

DELIMITER $$
CREATE Trigger add_recap_day
AFTER INSERT
ON absensi
FOR EACH ROW
BEGIN 
    UPDATE rekap SET jumlah_hari = jumlah_hari + 1 WHERE karyawan_id = NEW.karyawan_id;
END$$

DELIMITER ;

INSERT INTO absensi(id, tanggal, karyawan_id) 
VALUES(1, '2025-15-01', 1);

SELECT * FROM rekap;

DELIMITER $$
CREATE Trigger delete_recap_day_1
AFTER DELETE
ON absensi
FOR EACH ROW
BEGIN 
    UPDATE rekap SET jumlah_hari = jumlah_hari - 1 WHERE karyawan_id = OLD.karyawan_id;
END$$

DELIMITER ;

DELETE FROM absensi WHERE id = 1;

SELECT * FROM rekap;

SELECT * FROM absensi


DELIMITER $$
CREATE Trigger delete_data
AFTER DELETE
ON karyawan
FOR EACH ROW
BEGIN 
    DELETE FROM absensi WHERE karyawan_id = OLD.karyawan_id;
    DELETE FROM rekap WHERE karyawan_id = c   OL                            [[xD.karyawan_id;
END$$

DELIMITER ;

