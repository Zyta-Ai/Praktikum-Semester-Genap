<?php
include "../templatee/barang_db.php";

$pelanggan_id = $_GET['pelanggan_id'];

if (isset($_POST["pelanggan_id"])) {
    $namaPelanggan = $_POST['namaPelanggan'];
    $alamat = $_POST['alamat'];
    $no_telp = $_POST['nomor_telepon'];

    $query = "UPDATE pelanggan SET namaPelanggan='$namaPelanggan', alamat='$alamat', nomor_telepon = '$no_telp' WHERE pelanggan_id = $pelanggan_id;";
    $update = $conn->query($query);
}
$pelanggan = $conn->query("SELECT * FROM pelanggan WHERE pelanggan_id = $pelanggan_id;");
$data = $pelanggan->fetch_assoc();

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
        <h2>Edit Data Pelanggan</h2>

        <?php if (isset($tambah)): ?>
            <div class="alert alert-success" role="alert">
                <h4 class="alert-heading">Data Berhasil Dikirim</h4>
            </div>
        <?php endif; ?>

        <form action="" method="POST">

            <div class="form-group">
                <label for="pelanggan_id">ID pelanggan</label>
                <input type="text" id="pelanggan_id" name="pelanggan_id" placeholder="Masukkan ID Pelanggan"
                    value="<?= $data['pelanggan_id'] ?>" required readonly>
            </div>

            <div class="form-group">
                <label for="namaPelanggan">Nama Pelanggan</label>
                <input type="text" id="namaPelanggan" name="namaPelanggan" placeholder="Masukkan Nama Pelanggan"
                    value="<?= $data['namaPelanggan'] ?>" required>
            </div>

            <div class="form-group">
                <label for="alamat">Alamat</label>
                <input type="text" id="alamat" name="alamat" placeholder="Masukkan Alamat Pelanggan"
                    value="<?= $data['alamat'] ?>" required>
            </div>

            <div class="form-group">
                <label for="nomor_telepon">Nomor Telepon</label>
                <input type="text" id="nomor_telepon" name="nomor_telepon"
                    placeholder="Masukkan Nomor Telepon Pelanggan" value="<?= $data['nomor_telepon'] ?>" required>
            </div>


            <a href="http://localhost:8080/app/models/index.php?halaman=dashboard">
                <button type="submit" class="btn-submit">Perbaharui Data</button>
                <?php if (isset($update)): ?>
                    <div class="alert alert-success" role="alert">
                        <h4 class="alert-heading">Data Berhasil Dikirim</h4>
                        <?php header("Location: http://localhost:8080/app/models/index.php?halaman=pelanggan"); ?>
                    </div>
                <?php endif; ?>
            </a>
        </form>
    </div>
</body>

</html>