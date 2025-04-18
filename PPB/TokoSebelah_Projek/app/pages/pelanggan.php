<?php
session_start();
include "../templatee/barang_db.php";

// Cek login
if (!isset($_SESSION['petugas_id']) || !isset($_SESSION['role'])) {
    header("Location: login.php");
    exit;
}

if ($_SESSION['role'] !== 'Kepala Toko' && $_SESSION['role'] !== 'Kasir') {
    echo "<script>alert('Akses ditolak! Role tidak valid.'); window.location='login.php';</script>";
    exit;
}

$query = "SELECT * FROM pelanggan;";
$pelanggan = $conn->query($query);

if (isset($_POST['namaPelanggan'])) {
    $namaPelanggan = $_POST['namaPelanggan'];
    $alamat = $_POST['alamat'];
    $nomor_telepon = $_POST['nomor_telepon'];

    $query = "INSERT INTO pelanggan (namaPelanggan, alamat, nomor_telepon) VALUES ('$namaPelanggan', '$alamat', '$nomor_telepon');";
    $tambah = $conn->query($query);
    header("Location: http://localhost:8080/app/models/index.php?halaman=pelanggan#");
}

?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="../styles/pelanggan.css">
</head>

<body>
    <div id="konten-utama">
        <div class="container-fluid">
            <div class="header d-flex w-100 py-3">
                <h5 class="h4 fw-bold text-black-50 text-uppercase">Dashboard Pelanggan</h5>
            </div><!-- Akhir header -->
        </div>

        <div class="container">
            <div class="main-container">
                <section class="contact-section">
                    <div class="contact-intro">
                        <h2 class="contact-title">Tambah Pelanggan</h2>
                    </div>

                    <form class="contact-form" action="" method="POST">
                        <div class="form-group-container">
                            <div class="form-group">
                                <label for="nama" class="form-label">Nama Pelanggan</label>
                                <input id="nama" name="namaPelanggan" class="form-input"
                                    placeholder="Masukan Nama Pelanggan" type="text" />
                            </div>
                            <div class="form-group">
                                <label for="alamat" class="form-label">Alamat </label>
                                <input id="alamat" name="alamat" class="form-input" placeholder="Masukan Alamat"
                                    type="text" />
                            </div>
                            <div class="form-group">
                                <label for="phone" class="form-label">Nomor Telepon</label>
                                <input id="phone" name="nomor_telepon" class="form-input" placeholder="+62 (234) 56789"
                                    type="text" />
                            </div>
                        </div>
                        <button class="form-submit" type="submit">Tambah</button>
                    </form>
                </section>

                <div class="table-container">
                    <table>
                        <thead>
                            <tr>
                                <th>No</th>
                                <th>Nama</th>
                                <th>Alamat</th>
                                <th>Nomor Telepon</th>
                                <th>Edit</th>
                                <th>Hapus</th>
                            </tr>
                        </thead>
                        <tbody>
                            <?php while ($item = $pelanggan->fetch_assoc()): ?>
                                <tr>
                                    <td data-label="ID Pelanggan"> <?= $item['pelanggan_id'] ?> </td>
                                    <td data-label="Nama"> <?= $item['namaPelanggan'] ?> </td>
                                    <td data-label="Alamat"> <?= $item['alamat'] ?> </td>
                                    <td data-label="Nomor Telepon"> <?= $item['nomor_telepon'] ?> </td>
                                    <td><a
                                            href="http://localhost:8080/app/pages/edit-pelanggan.php?pelanggan_id=<?= $item['pelanggan_id'] ?> "><img
                                                src="/assets/edit.png" alt="" style="width: 17px; margin-left: 10px;"></a>
                                    </td>
                                    <td><a
                                            href="http://localhost:8080/app/pages/hapus-pelanggan.php?pelanggan_id=<?= $item['pelanggan_id'] ?>"><img
                                                src="/assets/delete.png" alt="" style="width: 16px; margin-left: 15px;"></a>
                                    </td>
                                </tr>
                            <?php endwhile; ?>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>

    <!-- Konten Utama -->

    </div><!-- Akhir konten utama -->
    <script src="/assets-bs/bootstrap.js"></script>
</body>

</html>