<?php
session_start();

// Cek login petugas
if (!isset($_SESSION['petugas_id'])) {
    header("Location: login.php");
    exit;
}

if ($_SESSION['role'] !== 'Kepala Toko' && $_SESSION['role'] !== 'Kasir') {
    echo "<script>
            Swal.fire({
                icon: 'error',
                title: 'Akses Di Tolak!',
                text: 'Role Tidak Valid!',
                confirmButtonText: 'Oke',
                confirmButtonColor: '#3085d6'
            }).then(() => {
                window.location='login.php';
            });
        </script>";
    exit;
}

include "../templatee/barang_db.php";

// Ambil data petugas
$petugas_id = $_SESSION['petugas_id'];
$nama_petugas = $_SESSION['namaPetugas'];

// Ambil daftar pelanggan
$daftar_pelanggan = [];
$query_pelanggan = "SELECT pelanggan_id, namaPelanggan FROM pelanggan";
$hasil_pelanggan = $conn->query($query_pelanggan);
while ($pelanggan = $hasil_pelanggan->fetch_assoc()) {
    $daftar_pelanggan[] = [
        'id' => $pelanggan['pelanggan_id'],
        'nama' => $pelanggan['namaPelanggan']
    ];
}

// Ambil daftar produk
$daftar_produk = [];
$query_produk = "SELECT produk_id, nama_produk, harga, stok FROM produk";
$hasil_produk = $conn->query($query_produk);
while ($produk = $hasil_produk->fetch_assoc()) {
    $daftar_produk[] = [
        'id' => $produk['produk_id'],
        'nama' => $produk['nama_produk'],
        'harga' => $produk['harga'],
        'stok' => $produk['stok']
    ];
}

// Proses transaksi
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $pelanggan_id = isset($_POST['pelanggan_id']) ? (int)$_POST['pelanggan_id'] : 0;
    $keranjang = isset($_POST['keranjang']) ? json_decode($_POST['keranjang'], true) : [];
    $uang_dibayar = isset($_POST['uang_dibayar']) ? (float)$_POST['uang_dibayar'] : 0;
    $total_belanja = 0;

    // Validasi input
    if ($pelanggan_id <= 0 || empty($keranjang)) {
        echo "<script>
            Swal.fire({
                icon: 'error',
                title: 'Gagal!',
                text: 'Pelanggan atau keranjang tidak valid.',
                confirmButtonText: 'Oke',
                confirmButtonColor: '#3085d6'
            });
        </script>";
        exit;
    }

    // Hitung total
    foreach ($keranjang as $item) {
        $total_belanja += $item['subtotal'];
    }

    // Simpan penjualan dengan prepared statement
    $tanggal = date('Y-m-d');
    $query_penjualan = "INSERT INTO penjualan (tanggalPenjualan, total_harga, pelanggan_id, petugas_id) VALUES (?, ?, ?, ?)";
    $stmt = $conn->prepare($query_penjualan);
    $stmt->bind_param("sdii", $tanggal, $total_belanja, $pelanggan_id, $petugas_id);
    
    if ($stmt->execute()) {
        $penjualan_id = $conn->insert_id;

        // Simpan detail
        foreach ($keranjang as $item) {
            $nama_produk = $conn->real_escape_string($item['nama_produk']);
            $query_produk_id = "SELECT produk_id FROM produk WHERE nama_produk = ?";
            $stmt_produk = $conn->prepare($query_produk_id);
            $stmt_produk->bind_param("s", $nama_produk);
            $stmt_produk->execute();
            $hasil_produk_id = $stmt_produk->get_result();
            $produk_id = $hasil_produk_id->fetch_assoc()['produk_id'];
            $stmt_produk->close();

            $jumlah = (int)$item['jumlah'];
            $subtotal = (float)$item['subtotal'];

            // Simpan detail
            $query_detail = "INSERT INTO detail_penjualan (penjualan_id, produk_id, jumlah_produk, subtotal) VALUES (?, ?, ?, ?)";
            $stmt_detail = $conn->prepare($query_detail);
            $stmt_detail->bind_param("iiid", $penjualan_id, $produk_id, $jumlah, $subtotal);
            $stmt_detail->execute();
            $stmt_detail->close();
        }

        $kembalian = $uang_dibayar - $total_belanja;
        echo "<script>
            Swal.fire({
                icon: 'success',
                title: 'Berhasil!',
                html: 'Transaksi disimpan.<br>Kembalian: Rp ' + $kembalian.toLocaleString(),
                confirmButtonText: 'Oke',
                confirmButtonColor: '#3085d6'
            }).then(() => {
                window.location='index.php?halaman=transaksi';
            });
        </script>";
    } else {
        echo "<script>
            Swal.fire({
                icon: 'error',
                title: 'Gagal!',
                text: 'Gagal menyimpan transaksi: " . $conn->error . "',
                confirmButtonText: 'Oke',
                confirmButtonColor: '#3085d6'
            });
        </script>";
    }
    $stmt->close();
}
$conn->close();
?>

<!DOCTYPE html>
<html lang="id">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Transaksi</title>
    <script src="https://cdn.tailwindcss.com"></script>
    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@11"></script>
</head>
<body class="bg-gray-100 p-6">
    <div id="konten-utama">
        <div class="container-fluid">
            <div class="flex justify-between py-3">
                <h5 class="h4 fw-bold text-black-50 text-uppercase">Halaman Transaksi</h5>
                <p class="text-gray-700">Petugas: <span class="font-semibold"><?= htmlspecialchars($nama_petugas) ?></span></p>
            </div>
        </div>

        <div class="bg-white shadow rounded-lg p-6 max-w-4xl mx-auto">
            <h2 class="text-2xl font-semibold mb-4 text-gray-700">Transaksi Baru</h2>

            <form id="formTransaksi" method="POST" action="">
                <!-- Pilih Pelanggan -->
                <div class="mb-4">
                    <label for="pelanggan" class="block text-gray-700 font-medium mb-2">Pelanggan</label>
                    <input type="text" id="pelanggan" name="pelanggan" 
                           class="w-full border border-gray-300 rounded-lg p-2" 
                           list="list_pelanggan" placeholder="Ketik nama pelanggan">
                    <datalist id="list_pelanggan"></datalist>
                    <input type="hidden" id="pelanggan_id" name="pelanggan_id">
                </div>

                <!-- Pilih Produk -->
                <div class="grid grid-cols-2 gap-4 mb-4">
                    <div>
                        <label for="produk" class="block text-gray-700 font-medium mb-2">Produk</label>
                        <input type="text" id="produk" name="produk"
                            class="w-full border border-gray-300 rounded-lg p-2" list="list_produk"
                            placeholder="Ketik nama produk">
                        <datalist id="list_produk"></datalist>
                    </div>
                    <div>
                        <label for="jumlah" class="block text-gray-700 font-medium mb-2">Jumlah</label>
                        <input type="number" id="jumlah" name="jumlah" value="1" min="1"
                            class="w-full border border-gray-300 rounded-lg p-2">
                    </div>
                </div>

                <button type="button" id="tambahKeranjang"
                    class="bg-blue-600 text-white px-4 py-2 rounded-lg hover:bg-blue-700 mb-6">
                    Tambah
                </button>

                <!-- Tabel Keranjang -->
                <table class="min-w-full border border-gray-200 text-sm">
                    <thead class="bg-gray-200">
                        <tr>
                            <th class="p-2 text-left">Produk</th>
                            <th class="p-2 text-right">Harga</th>
                            <th class="p-2 text-center">Jumlah</th>
                            <th class="p-2 text-right">Subtotal</th>
                            <th class="p-2 text-center">Hapus</th>
                        </tr>
                    </thead>
                    <tbody id="keranjangItems"></tbody>
                    <tfoot class="bg-gray-100">
                        <tr>
                            <td colspan="3" class="p-2 text-right font-semibold">Total:</td>
                            <td class="p-2 text-right font-semibold" id="totalBelanja">Rp 0</td>
                            <td></td>
                        </tr>
                    </tfoot>
                </table>

                <!-- Pembayaran -->
                <div class="mt-4 mb-6">
                    <label for="uang_dibayar" class="block text-gray-700 font-medium mb-2">Uang Dibayar (Rp)</label>
                    <input type="number" id="uang_dibayar" name="uang_dibayar" min="0"
                        class="w-full border border-gray-300 rounded-lg p-2" placeholder="Masukkan jumlah">
                    <p class="mt-2 text-gray-700">Kembalian: <span id="kembalian" class="font-semibold">Rp 0</span></p>
                </div>

                <input type="hidden" id="dataKeranjang" name="keranjang">

                <!-- Tombol Simpan -->
                <div class="mt-6 text-right">
                    <button type="submit" id="simpanTransaksi"
                        class="bg-green-600 text-white px-6 py-2 rounded-lg hover:bg-green-700">
                        Simpan
                    </button>
                </div>
            </form>
        </div>
    </div>

    <script>
        // Data dari PHP
        let daftar_produk = <?= json_encode($daftar_produk) ?>;
        let daftar_pelanggan = <?= json_encode($daftar_pelanggan) ?>;

        // Elemen DOM
        const pelangganInput = document.getElementById('pelanggan');
        const pelangganIdInput = document.getElementById('pelanggan_id');
        const listPelanggan = document.getElementById('list_pelanggan');
        const produkInput = document.getElementById('produk');
        const jumlahInput = document.getElementById('jumlah');
        const listProduk = document.getElementById('list_produk');
        const keranjangItems = document.getElementById('keranjangItems');
        const totalBelanja = document.getElementById('totalBelanja');
        const dataKeranjang = document.getElementById('dataKeranjang');
        const uangDibayarInput = document.getElementById('uang_dibayar');
        const kembalianText = document.getElementById('kembalian');

        let keranjang = [];
        let total = 0;

        // Autocomplete untuk pelanggan
        pelangganInput.oninput = function () {
            let input = this.value.toLowerCase();
            let filterPelanggan = daftar_pelanggan.filter(pelanggan => 
                pelanggan.nama.toLowerCase().includes(input)
            );

            if (filterPelanggan.length > 0) {
                filterPelanggan = filterPelanggan.slice(0, 5);
                listPelanggan.innerHTML = filterPelanggan.map(pelanggan => 
                    `<option value="${pelanggan.nama}" data-id="${pelanggan.id}">
                        ${pelanggan.nama}
                    </option>`
                ).join("");
            } else {
                listPelanggan.innerHTML = "";
                pelangganIdInput.value = "";
            }
        };

        // Set pelanggan_id saat memilih pelanggan
        pelangganInput.addEventListener('change', function () {
            const selectedOption = listPelanggan.querySelector(`option[value="${this.value}"]`);
            if (selectedOption) {
                pelangganIdInput.value = selectedOption.getAttribute('data-id') || "";
            } else {
                pelangganIdInput.value = "";
            }
        });

        // Autocomplete untuk produk
        produkInput.oninput = function () {
            let input = this.value.toLowerCase();
            let filterProduk = daftar_produk.filter(produk =>
                produk.nama.toLowerCase().includes(input)
            );

            if (filterProduk.length > 0) {
                filterProduk = filterProduk.slice(0, 5);
                listProduk.innerHTML = filterProduk.map(produk =>
                    `<option value="${produk.nama}" 
                             data-harga="${produk.harga}" 
                             data-stok="${produk.stok}">
                        ${produk.nama} - Rp ${Number(produk.harga).toLocaleString()} (Stok: ${produk.stok})
                    </option>`
                ).join("");
            } else {
                listProduk.innerHTML = "";
            }
        };

        // Tambah ke keranjang
        document.getElementById('tambahKeranjang').addEventListener('click', () => {
            const nama_produk = produkInput.value;
            if (!nama_produk) {
                Swal.fire({
                    icon: 'warning',
                    title: 'Produk Kosong!',
                    text: 'Pilih produk dulu.',
                    confirmButtonText: 'Oke',
                    confirmButtonColor: '#3085d6'
                });
                return;
            }

            const produkTerpilih = daftar_produk.find(produk => produk.nama === nama_produk);
            if (!produkTerpilih) {
                Swal.fire({
                    icon: 'warning',
                    title: 'Produk Salah!',
                    text: 'Pilih produk dari daftar.',
                    confirmButtonText: 'Oke',
                    confirmButtonColor: '#3085d6'
                });
                return;
            }

            const harga = parseFloat(produkTerpilih.harga);
            const jumlah = parseInt(jumlahInput.value);
            const stok = parseInt(produkTerpilih.stok);
            if (jumlah > stok) {
                Swal.fire({
                    icon: 'warning',
                    title: 'Stok Kurang!',
                    text: 'Jumlah melebihi stok produk.',
                    confirmButtonText: 'Oke',
                    confirmButtonColor: '#3085d6'
                });
                return;
            }

            const subtotal = harga * jumlah;

            const itemAda = keranjang.find(item => item.nama_produk === nama_produk);
            if (itemAda) {
                itemAda.jumlah += jumlah;
                itemAda.subtotal += subtotal;
            } else {
                keranjang.push({ nama_produk, harga, jumlah, subtotal });
            }

            tampilKeranjang();
            produkInput.value = '';
            jumlahInput.value = 1;
        });

        // Hitung kembalian
        uangDibayarInput.oninput = function () {
            const uang_dibayar = parseFloat(this.value) || 0;
            const kembalian = uang_dibayar - total;

            if (uang_dibayar >= total && total > 0) {
                kembalianText.textContent = `Rp ${kembalian.toLocaleString()}`;
                kembalianText.classList.remove('text-red-600');
                kembalianText.classList.add('text-green-600');
            } else {
                kembalianText.textContent = uang_dibayar > 0 ? `Uang kurang!` : `Rp 0`;
                kembalianText.classList.remove('text-green-600');
                kembalianText.classList.add('text-red-600');
            }
        };

        function tampilKeranjang() {
            keranjangItems.innerHTML = '';
            total = 0;

            keranjang.forEach((item, index) => {
                total += item.subtotal;

                keranjangItems.innerHTML += `
                    <tr>
                        <td class="p-2">${item.nama_produk}</td>
                        <td class="p-2 text-right">Rp ${item.harga.toLocaleString()}</td>
                        <td class="p-2 text-center">${item.jumlah}</td>
                        <td class="p-2 text-right">Rp ${item.subtotal.toLocaleString()}</td>
                        <td class="p-2 text-center">
                            <button onclick="hapusItem(${index})" class="text-red-600 hover:underline">Hapus</button>
                        </td>
                    </tr>
                `;
            });

            totalBelanja.textContent = `Rp ${total.toLocaleString()}`;
            dataKeranjang.value = JSON.stringify(keranjang);
            uangDibayarInput.value = '';
            kembalianText.textContent = `Rp 0`;
            kembalianText.classList.remove('text-green-600', 'text-red-600');
        }

        function hapusItem(index) {
            keranjang.splice(index, 1);
            tampilKeranjang();
        }
    </script>
</body>
</html>