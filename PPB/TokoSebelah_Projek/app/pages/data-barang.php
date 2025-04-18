<script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
<?php
session_start();
include "../templatee/barang_db.php";

// Cek role: hanya Kepala Toko
if ($_SESSION['role'] !== 'Kepala Toko') {
    echo "<script>
            Swal.fire({
                icon: 'error',
                title: 'Akses Di Tolak!',
                text: 'Role Anda Tidak Valid!.',
                confirmButtonText: 'Oke',
                confirmButtonColor: '#3085d6'
            });
        </script>";
    exit;
}

$query = "SELECT * FROM produk";

$result = $conn->query($query);
?>

<!DOCTYPE html>
<html lang="id">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Produk Buku</title>
    <script src="https://cdn.tailwindcss.com"></script>
    <link rel="stylesheet" href="/assets-bs/style.css">
    <script src="/assets-bs/bootstrap.js"></script>
</head>

<body class="bg-gray-100 p-6">
    <div id="konten-utama">
        <div class="container-fluid">
            <div class="header d-flex w-100 py-3">
                <h5 class="h4 fw-bold text-black-50 text-uppercase">Daftar Barang</h5>
            </div>
            <div class="max-w-6xl mx-auto">
                <!-- Add Items -->
                <a href="http://localhost:8080/app/pages/tambah-barang.php">
                    <button type="button" class="btn btn-outline-success" style="margin:20px 0px; ">Add Item</button>
                </a>

                <div class="overflow-auto rounded-lg shadow">
                    <table class="w-full table-auto text-sm text-left text-gray-700">
                        <thead class="bg-gray-200 text-gray-800">
                            <tr>
                                <th class="px-4 py-3">ID Produk</th>
                                <th class="px-4 py-3">Nama Produk</th>
                                <th class="px-4 py-3">Harga</th>
                                <th class="px-4 py-3">Stok</th>
                                <th class="px-4 py-3">Edit</th>
                                <th class="px-4 py-3">Tambah</th>
                            </tr>
                        </thead>
                        <tbody class="divide-y divide-gray-300 bg-white">
                            <?php while ($item = $result->fetch_assoc()): ?>
                                <tr class="hover:bg-gray-50">
                                    <td class="px-4 py-2"> <?= $item['produk_id'] ?> </td>
                                    <td class="px-4 py-2"> <?= $item['nama_produk'] ?> </td>
                                    <td class="px-4 py-2"> <?= $item['harga'] ?></td>
                                    <td class="px-4 py-2"> <?= $item['stok'] ?></td>
                                    <td><a
                                            href="http://localhost:8080/app/pages/update-barang.php?produk_id=<?= $item['produk_id'] ?>">
                                            <button type="button" class="btn btn-outline-success"
                                                style="margin:20px 10px; ">Edit</button>
                                        </a></td>
                                    <td><a
                                            href="http://localhost:8080/app/pages/hapus-barang.php?produk_id=<?= $item['produk_id'] ?>"><button
                                                type="button"
                                                class="text-red-700 hover:text-white border border-red-700 hover:bg-red-800 focus:ring-4 focus:outline-none focus:ring-red-300 font-medium rounded-lg text-sm px-3 py-2 text-center me-0 mb-0 ml-3 dark:border-red-500 dark:text-red-500 dark:hover:text-white dark:hover:bg-red-600 dark:focus:ring-red-900">Hapus</button>
                                        </a></td>
                                </tr>

                            <?php endwhile; ?>
                        </tbody>
                    </table>
                </div>
            </div>

        </div>
    </div>
</body>

</html>