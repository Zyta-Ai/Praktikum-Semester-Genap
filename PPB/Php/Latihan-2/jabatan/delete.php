<?php 
$servername = "localhost";
$username = "root";
$password = "";
$db_name = "db_praktekum_2";

$conn = new mysqli($servername, $username, $password, $db_name);

if ($conn->connect_error) {
    die("Koneksi Gagal:" . $conn->connect_error);
};

$id_jabatan = $_GET['id_jabatan'];

$query = "DELETE FROM jabatan WHERE id_jabatan = $id_jabatan";

$hasil = $conn->query($query);

header("location:http://localhost:8080/PPB/Php/Latihan-2/Jabatan/read.php");
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Doc</title>
</head>
<body>
    
</body>
</html>