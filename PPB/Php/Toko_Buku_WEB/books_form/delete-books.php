<?php 
    include "../template/config_db.php";
    

    $id_buku = $_GET['id_buku'];

    $query = "DELETE FROM books WHERE id_buku = $id_buku";

    $hasil = $conn->query($query);
    header("location:http://localhost:8080/PPB/php/toko_buku_web/books_crud/read-books.php");
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Delete Form </title>
</head>
<body>
    
</body>
</html>
