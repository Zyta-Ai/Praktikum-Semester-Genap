<?php
include "../templatee/barang_db.php";

if ($conn->connect_error) {
    die("Koneksi Gagal: " . $conn->connect_error);
}

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $nama_produk = $_POST['nama_produk'];
    $harga = $_POST['harga'];
    $stok = $_POST['stok'];
}

if (isset($harga)) {
    if (empty($harga) || empty($nama_produk)) {
        echo "Form Tidak Boleh Ada yang Kosong!";
    } else {
        $query = "INSERT INTO produk (nama_produk, harga, stok) VALUES ('$nama_produk', $harga, $stok);";
        $tambah = $conn->query($query);
    }

    header ("Location: http://localhost:8080/app/models/index.php");
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=x, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="../styles/tambah.css">
</head>

<body>
    <div class="form-container">
        <h2>Tambah Data Buku</h2>
        <?php if (isset($tambah)): ?>
            <div class="alert alert-success" role="alert">
                <h4 class="alert-heading">Data Berhasil Dikirim</h4>
            </div>
        <?php endif; ?>
        <form action="" method="POST">
            <div class="form-group">
                <label for="nama_produk">Nama Produk</label>
                <input type="text" id="nama_produk" name="nama_produk" placeholder="Masukkan kode buku" required>
            </div>

            <div class="form-group">
                <label for="harga">Harga</label>
                <input type="text" id="harga" name="harga" placeholder="Masukkan harga" required>
            </div>

            <div class="form-group">
                <label for="stok">Stok</label>
                <input type="text" id="stok" name="stok" placeholder="Masukkan stok" required>
            </div>

            <button type="submit" class="btn-submit">Simpan Buku</button>
        </form>
    </div>

</body>

</html>