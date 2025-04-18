<?php 
    include "../templatee/barang_db.php";
    $produk_id = $_GET['produk_id'];

    $query = "DELETE FROM produk WHERE produk_id = $produk_id;";

    $hasil = $conn->query($query);
    header("http://localhost:8080/app/pages/data-barang.php#");
?>