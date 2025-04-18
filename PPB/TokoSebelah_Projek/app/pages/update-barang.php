<?php
include '../templatee/barang_db.php';

$produk_id = $_GET['produk_id'];

if (isset($_POST["produk_id"])) {
    $nama_produk = $_POST['nama_produk'];
    $harga = $_POST['harga'];
    $stok = $_POST['stok'];

    $query = "UPDATE produk SET nama_produk='$nama_produk', harga=$harga, stok=$stok WHERE produk_id = $produk_id;";
    $update = $conn->query($query);
}
$barang = $conn->query("SELECT * FROM produk WHERE produk_id = $produk_id");
$data = $barang->fetch_assoc();

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
                <label for="produk_id">ID Produk</label>
                <input type="text" id="produk_id" name="produk_id" placeholder="Masukkan kode buku"
                    value="<?= $data['produk_id'] ?>" required readonly>
            </div>

            <div class="form-group">
                <label for="nama_produk">Nama Produk</label>
                <input type="text" id="nama_produk" name="nama_produk" placeholder="Masukkan kode buku"
                    value="<?= $data['nama_produk'] ?>" required>
            </div> 

            <div class="form-group">
                <label for="harga">Harga</label>
                <input type="text" id="harga" name="harga" placeholder="Masukkan harga"
                    value="<?= $data['harga'] ?>" required>
            </div>

            <div class="form-group">
                <label for="stok">Stok</label>
                <input type="text" id="stok" name="stok" placeholder="Masukkan stok"
                    value="<?= $data['stok'] ?>" required>
            </div>
        

            <a href="http://localhost:8080/app/models/index.php?halaman=dashboard">
                <button type="submit" class="btn-submit">Update Barang</button>
                <?php if (isset($update)): ?>
                    <div class="alert alert-success" role="alert">
                        <h4 class="alert-heading">Data Berhasil Dikirim</h4>
                        <?php header ("Location: http://localhost:8080/app/models/index.php?halaman=data-barang");?>
                    </div>
                <?php endif; ?>
            </a>
        </form>
    </div>
</body>
</html>