<script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
<?php
session_start();
include "../templatee/barang_db.php";

// Cek login
if (!isset($_SESSION['petugas_id']) || !isset($_SESSION['role'])) {
    header("Location: login.php");
    exit;
}

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

$tanggal_dari = $_POST['tanggal_dari'] ?? '';
$tanggal_sampai = $_POST['tanggal_sampai'] ?? '';
$laporan = [];
$total_penjualan = 0;
$produk_terlaris = [];

if ($tanggal_dari && $tanggal_sampai) {
    $query_filter = "SELECT penjualan.penjualan_id, penjualan.tanggalPenjualan, penjualan.total_harga, pelanggan.namaPelanggan, petugas.namaPetugas 
    FROM penjualan 
    LEFT JOIN pelanggan ON penjualan.pelanggan_id = pelanggan.pelanggan_id 
    LEFT JOIN petugas ON penjualan.petugas_id = petugas.petugas_id
    WHERE penjualan.tanggalPenjualan BETWEEN '$tanggal_dari' AND '$tanggal_sampai' 
    ORDER BY penjualan.tanggalPenjualan DESC;";

    $laporan = $conn->query($query_filter);

    $query_total = "SELECT SUM(total_harga) as total_penjualan 
        FROM penjualan 
        WHERE tanggalPenjualan BETWEEN '$tanggal_dari' AND '$tanggal_sampai'";

    $total = $conn->query($query_total);
    $total_penjualan = $total->fetch_assoc()['total_penjualan'];

    $query_produk_terlaris = "SELECT produk.nama_produk, SUM(detail_penjualan.jumlah_produk) as total_terjual 
        FROM detail_penjualan 
        LEFT JOIN produk ON detail_penjualan.produk_id = produk.produk_id 
        LEFT JOIN penjualan ON detail_penjualan.penjualan_id = penjualan.penjualan_id 
        WHERE penjualan.tanggalPenjualan BETWEEN '$tanggal_dari' AND '$tanggal_sampai' 
        GROUP BY produk.nama_produk 
        ORDER BY total_terjual DESC 
        LIMIT 5";

    $produk_terlaris = $conn->query($query_produk_terlaris);
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Laporan Penjualan</title>
    <script src="https://cdn.tailwindcss.com"></script>
</head>

<body class="bg-gray-100 p-6 font-sans">
    <div id="konten-utama">
        <div class="container-fluid">
            <div class="header d-flex w-100 py-3">
                <h5 class="h4 fw-bold text-black-50 text-uppercase">Laporan Penjualan</h5>
            </div><!-- Akhir header -->
        </div>
        <div class="max-w-6xl mx-auto bg-white shadow-md rounded-lg p-6">
            <h1 class="text-2xl font-bold mb-6 text-gray-800">Laporan Penjualan</h1>

            <!-- Form Filter Tanggal -->
            <form method="POST" class="grid grid-cols-1 sm:grid-cols-3 gap-4 mb-6">
                <div>
                    <label for="tanggal_dari" class="block text-gray-700 font-medium mb-1">Dari Tanggal</label>
                    <input type="date" name="tanggal_dari" id="tanggal_dari"
                        value="<?= htmlspecialchars($tanggal_dari) ?>"
                        class="w-full border border-gray-300 rounded-lg p-2" required>
                </div>
                <div>
                    <label for="tanggal_sampai" class="block text-gray-700 font-medium mb-1">Sampai Tanggal</label>
                    <input type="date" name="tanggal_sampai" id="tanggal_sampai"
                        value="<?= htmlspecialchars($tanggal_sampai) ?>"
                        class="w-full border border-gray-300 rounded-lg p-2" required>
                </div>
                <div class="flex items-end">
                    <button type="submit"
                        class="bg-blue-600 text-white px-6 py-2 rounded-lg hover:bg-blue-700 w-full">Tampilkan</button>
                </div>
            </form>

            <!-- Tabel Transaksi -->
            <div class="overflow-x-auto">
                <table class="min-w-full border text-sm text-gray-700">
                    <thead class="bg-gray-200">
                        <tr>
                            <th class="p-2 text-left">Tanggal</th>
                            <th class="p-2 text-left">Nama Pelanggan</th>
                            <th class="p-2 text-left">Petugas</th>
                            <th class="p-2 text-right">Total Harga</th>
                        </tr>
                    </thead>
                    <tbody class="bg-white">
                        <?php if ($laporan && $laporan->num_rows > 0): ?>
                            <?php while ($row = $laporan->fetch_assoc()): ?>
                                <tr>
                                    <td class="p-2"><?= htmlspecialchars($row['tanggalPenjualan']) ?></td>
                                    <td class="p-2"><?= htmlspecialchars($row['namaPelanggan'] ?? 'Umum') ?></td>
                                    <td class="p-2"><?= htmlspecialchars($row['namaPetugas'] ?? '-') ?></td>
                                    <td class="p-2 text-right">Rp <?= number_format($row['total_harga'], 0, ',', '.') ?></td>
                                </tr>
                            <?php endwhile; ?>
                        <?php else: ?>
                            <tr>
                                <td colspan="4" class="p-4 text-center text-gray-500">Tidak ada data penjualan pada rentang
                                    tanggal ini.</td>
                            </tr>
                        <?php endif; ?>
                    </tbody>
                    <tfoot class="bg-gray-100">
                        <tr>
                            <td colspan="3" class="p-2 text-right font-semibold">Total Penjualan:</td>
                            <td class="p-2 text-right font-semibold text-green-600">
                                Rp <?= number_format($total_penjualan ?? 0, 0, ',', '.') ?>
                            </td>
                        </tr>
                    </tfoot>
                </table>
            </div>

            <!-- Produk Terlaris -->
            <div class="mt-8">
                <h2 class="text-lg font-semibold mb-2 text-gray-700">Daftar Produk Terlaris</h2>
                <ul class="list-disc pl-5 text-gray-600 text-sm">
                    <?php if ($produk_terlaris && $produk_terlaris->num_rows > 0): ?>
                        <?php while ($row = $produk_terlaris->fetch_assoc()): ?>
                            <li><?= htmlspecialchars($row['nama_produk']) ?> - Terjual <?= (int) $row['total_terjual'] ?> pcs
                            </li>
                        <?php endwhile; ?>
                    <?php else: ?>
                        <li>Tidak ada produk terjual dalam periode ini.</li>
                    <?php endif; ?>
                </ul>
            </div>
        </div>
    </div>
</body>

</html>