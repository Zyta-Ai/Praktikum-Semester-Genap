<?php
$servername = 'localhost';
$user = 'root';
$password = '';
$db_name = 'db_uprak_genap';

$conn = new mysqli($servername, $user, $password, $db_name);

if ($conn->connect_error) {
    die("Koneksi error : " . $conn->connect_error);
}

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    if (isset($_POST['email']) && isset($_POST['password'])) {
        $email = $_POST['email'];
        $password = $_POST['password'];

        $query = "SELECT * FROM user WHERE email = '$email' AND password = '$password'";
        $hasil = mysqli_query($conn, $query);

        if (mysqli_num_rows($hasil) > 0) {
            $user = mysqli_fetch_assoc($hasil);
            
            $_SESSION['email'] = $_POST['email'];

            if ($user['password'] === $password) {
                $current_user = $user['id'];
                header("location:http://localhost:9090/profil.php?id=" . $current_user );
            }
        } else {
            echo "Password Salah";
        }
    }
}

$baca = "SELECT * FROM user";
$hasil2 = $conn->query($baca);

$item = $hasil2->fetch_assoc();
?>


<!DOCTYPE html>
<!-- Created By CodingNepal -->
<html lang="en" dir="ltr">

<head>
    <meta charset="utf-8">
    <title>Login Form Design | CodeLab</title>
    <link rel="stylesheet" href="../assets-bs/login.css">
</head>

<body>
    <div class="wrapper">
        <div class="title">
            Login Form
        </div>
        <form action="" method="POST">
            <div class="field">
                <input type="email" id="email" name="email" required placeholder="Email"><br><br>
            </div>
            <div class="field">
                <input type="password" id="password" name="password" required placeholder="Password"><br><br>
            </div>
            <div class="content">
                <div class="checkbox">
                    <input type="checkbox" id="remember-me">
                    <label for="remember-me">Remember me</label>
                </div>
                <div class="pass-link">
                    <a href="#">Forgot password?</a>
                </div>
            </div>
            <div class="field">
                    <button type="submit" value="login" id="login">Login</button>
            </div>
            <div class="signup-link">
                Not a member? <a href="http://localhost:9090/registrasi.php">Signup now</a>
            </div>
        </form>
    </div>
</body>

</html>