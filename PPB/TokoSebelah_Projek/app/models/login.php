<?php
session_start();
include "../templatee/barang_db.php";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $username = $_POST['username'];
    $password = $_POST['password'];
    $query = "SELECT petugas_id, namaPetugas, role FROM petugas WHERE username='$username' AND password='$password'";
    $result = $conn->query($query);
    if ($result->num_rows > 0) {
        $petugas = $result->fetch_assoc();
        $_SESSION['petugas_id'] = $petugas['petugas_id'];
        $_SESSION['namaPetugas'] = $petugas['namaPetugas'];
        $_SESSION['role'] = $petugas['role'];
        header("Location: index.php?halaman=transaksi");
    } else {
        echo "<script>alert('Username atau password salah!');</script>";
    }
}
?>

<!DOCTYPE html>
<html lang="id">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login Petugas</title>
    <script src="https://cdn.tailwindcss.com"></script>
    <style>
        .input-field {
            transition: all 0.3s ease;
            border: 1px solid #d1d5db;
        }
        .input-field:focus {
            border-color: #3b82f6;
            box-shadow: 0 0 0 3px rgba(59, 130, 246, 0.2);
            outline: none;
        }
    </style>
</head>
<body class="bg-gray-100 flex items-center justify-center min-h-screen">
    <div class="bg-white p-8 rounded-lg shadow-xl max-w-md w-full">
        <h2 class="text-2xl font-semibold text-gray-700 mb-6 text-center">Login Petugas</h2>
        <form method="POST" action="">
            <div class="mb-4">
                <label for="username" class="block text-gray-700 font-medium mb-2">Username</label>
                <input type="text" id="username" name="username" 
                       class="input-field w-full border rounded-lg p-2" 
                       placeholder="Masukkan username" required>
            </div>
            <div class="mb-6">
                <label for="password" class="block text-gray-700 font-medium mb-2">Password</label>
                <input type="password" id="password" name="password" 
                       class="input-field w-full border rounded-lg p-2" 
                       placeholder="Masukkan password" required>
            </div>
            <button type="submit" 
                    class="w-full bg-blue-600 text-white py-2 rounded-lg hover:bg-blue-700 transition">
                Login
            </button>
        </form>
    </div>
</body>
</html>