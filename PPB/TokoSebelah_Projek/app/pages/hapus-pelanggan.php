<?php 
include "../templatee/barang_db.php";

$pelanggan_id = $_GET['pelanggan_id'];

$query = "DELETE FROM pelanggan WHERE pelanggan_id = $pelanggan_id;";
$delete = $conn->query($query);

$hasil = $conn->query($query);

header("Location: http://localhost:8080/app/models/index.php?halaman=pelanggan#");
?>