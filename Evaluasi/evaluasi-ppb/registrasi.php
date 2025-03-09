<?php 
$servername = 'localhost';
$user = 'root';
$password = '';
$db_name = 'db_uprak_genap';

$conn = new mysqli($servername, $user, $password, $db_name);

if ($conn->connect_error) {
    die("Koneksi error : " . $conn->connect_error);
}

if($_SERVER['REQUEST_METHOD'] === 'POST'){
    $nama_lengkap = $_POST['nama_lengkap'];
    $email = $_POST['email'];
    $tanggal_lahir = $_POST['tanggal_lahir'];
    $password = $_POST['password'];
}

if(isset($nama_lengkap)){
    if(empty($password) && empty($email) && empty($tanggal_lahir) && empty($nama_lengkap)){
        echo "Form Tidak Boleh Ada Yang Kosong! Mohon Pengertian";
    }
    else{
        $query = "INSERT INTO user(nama_lengkap,email,tanggal_lahir,password) VALUES('$nama_lengkap', '$email', '$tanggal_lahir', '$password')";

        $tambah = $conn->query($query);

        header("location:http://localhost:9090/login.php");
    }
}
?>


<!DOCTYPE html>
<html lang="en" dir="ltr">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title> Registration or Sign Up form in HTML CSS | CodingLab </title>
    <link rel="stylesheet" href="../assets-bs/regis.css">
</head>

<body>
    <div class="wrapper">
        <h2>Registration</h2>
        <form action="" method="POST">
            <div class="input-box">
                <input type="text" id="nama_lengkap" placeholder="Enter your name" name="nama_lengkap" required>
            </div>
            <div class="input-box">
                <input type="text" id="email" name="email" placeholder="Enter your email" required>
            </div>
            <div class="input-box">
                <input type="date" id="tanggal_lahir" name="tanggal_lahir" required>
            </div>
            <div class="input-box">
                <input type="password" id="password" name="password" placeholder="Create password" required>
            </div>

            <div class="policy">
                <input type="checkbox">
                <h3>I accept all terms & condition</h3>
            </div>
            <div class="input-box button">
                <input type="Submit" value="Register Now">
            </div>
            <div class="text">
                <h3>Already have an account? <a href="http://localhost:9090/login.php">Login now</a></h3>
            </div>
        </form>
    </div>
</body>

</html>