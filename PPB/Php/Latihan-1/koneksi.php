<?php 

$conn = new mysqli("localhost","root",'','db_praktekum_2');

if($conn->connect_error){
    die("Koneksi Gagal : " . $conn->connect_error);
    // Fungsi Die untuk mematikan porses php
};

?>