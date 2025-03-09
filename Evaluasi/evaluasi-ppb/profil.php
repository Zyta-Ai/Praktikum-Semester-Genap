<?php
    $servername = 'localhost';
    $user = 'root';
    $password = '';
    $db_name = 'db_uprak_genap';
    
    $conn = new mysqli($servername, $user, $password, $db_name);
    
    if ($conn->connect_error) {
        die("Koneksi error : " . $conn->connect_error);
    }

    $user_id = $_GET['id'];

    $query = "SELECT * FROM user WHERE id = $user_id";
    $hasil = $conn->query($query);
    $userlogin = $hasil->fetch_assoc();

?>


<!DOCTYPE html>
<html lang="en" dir="ltr">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title> Profil User </title>
    <link rel="stylesheet" href="../assets-bs/regis.css">
</head>

<body>
    <div class="wrapper">
        <h2>Profil</h2>
        <form action="" method="POST">
            
            <div class="input-box">
                <input type="text" id="nama_lengkap" placeholder="Enter your name" name="nama_lengkap" value="Nama Lengkap: <?=$userlogin['nama_lengkap']?>" required readonly>
            </div>
            <div class="input-box">
                <input type="text" id="email" name="email" placeholder="Enter your email" value="Email: <?=$userlogin['email']?>" required readonly>
            </div>
            <div class="input-box">
                <input type="text" id="tanggal_lahir" name="tanggal_lahir" value="Tanggal Lahir: <?=$userlogin['tanggal_lahir']?>" required readonly>
            </div>

        </form>
    </div>
</body>

</html>