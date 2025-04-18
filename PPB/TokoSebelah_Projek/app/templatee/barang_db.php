<?php 

$servername = "localhost";
$username = "root";
$password = "";
$db_name = "db_toko_sebelah";

$conn = new mysqli($servername, $username, $password, $db_name);

if ($conn->connect_error) {
    die("Koneksi Gagal: " . $conn->connect_error);
}

?>