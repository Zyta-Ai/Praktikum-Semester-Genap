<?php 
$servername = "localhost";
$username = "root";
$password = "";
$db_name = "db_praktekum_2";

$conn = new mysqli($servername, $username, $password, $db_name);

if ($conn->connect_error) {
    die("Koneksi Gagal:" . $conn->connect_error);
};

$id_karyawan = $_GET['id_karyawan'];

$query = "DELETE FROM karyawan WHERE id_karyawan = $id_karyawan";

$hasil = $conn->query($query);

header("http://localhost:8080/PPB/Php/Latihan-2/karyawan/read.php")

?>