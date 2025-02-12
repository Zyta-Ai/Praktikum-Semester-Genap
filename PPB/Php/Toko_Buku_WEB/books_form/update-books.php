<?php
$servername = "localhost";
$username = "root";
$password = "";
$db_name = "db_tokoBuku";

$conn = new mysqli($servername, $username, $password, $db_name);

if ($conn->connect_error) {
    die("Koneksi Gagal: " . $conn->connect_error);
}
;

$id_buku = $_GET['id_buku'];

if (isset($_POST["id_buku"])) {
    $kode_buku = $_POST['kode_buku'];
    $judul = $_POST['judul'];
    $pengarang = $_POST['pengarang'];
    $penerbit = $_POST['penerbit'];
    $harga = $_POST['harga'];
    $stok = $_POST['stok'];

    $query = "UPDATE books SET kode_buku = '$kode_buku', judul = '$judul', pengarang = '$pengarang', penerbit = '$penerbit', harga = $harga, stok = $stok WHERE id_buku = $id_buku";

    $hasil = $conn->query($query);
}

$books = $conn->query("SELECT * FROM books WHERE id_buku = $id_buku");
$data = $books->fetch_assoc();

?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title></title>
    <link rel="stylesheet" href="../assets-bs/style.css">
</head>

<body>
    <!-- Form Add Books -->

    <div class="container">
        <br>
        <?php if (isset($tambah)): ?>
            <div class="alert alert-success" role="alert">
                <br>
                <h4 class="alert-heading">Data Berhasil Di Update</h4>
            </div>
        <?php endif; ?>
        <form action="" method="post">
            <br>
            <h2>Form Add Books</h2>
            <br>

            <!-- ID Buku -->
            <div class="mb-3 row">
                <label for="id_buku" class="col-sm-2 col-form-label">ID Buku</label>
                <div class="col-sm-6">
                    <input type="text" class="form-control" id="id_buku" name="id_buku" placeholder="Masukan ID Buku"
                        value="<?= $data['id_buku'] ?>" readonly>
                </div>
            </div>

            <!-- Kode Buku -->
            <div class="mb-3 row">
                <label for="kode_buku" class="col-sm-2 col-form-label">Kode Buku</label>
                <div class="col-sm-6">
                    <input type="text" class="form-control" id="kode_buku" name="kode_buku"
                        placeholder="Masukan Kode Buku" value="<?= $data['kode_buku'] ?>">
                </div>
            </div>

            <!-- Judul Buku -->
            <div class="mb-3 row">
                <label for="judul" class="col-sm-2 col-form-label">Judul Buku</label>
                <div class="col-sm-6">
                    <input type="text" class="form-control" id="judul" name="judul" placeholder="Masukan Judul Buku"
                        value="<?= $data['judul'] ?>">
                </div>
            </div>

            <!-- Pengarang Buku-->
            <div class="mb-3 row">
                <label for="pengarang" class="col-sm-2 col-form-label">Pengarang Buku</label>
                <div class="col-sm-6">
                    <input type="text" class="form-control" id="pengarang" name="pengarang"
                        placeholder="Masukan Pengarang Buku" value="<?= $data['pengarang'] ?>">
                </div>
            </div>

            <!-- Penerbit Buku -->
            <div class="mb-3 row">
                <label for="penerbit" class="col-sm-2 col-form-label">Penerbit Buku</label>
                <div class="col-sm-6">
                    <input type="text" class="form-control" id="penerbit" name="penerbit"
                        placeholder="Masukan Penerbit Buku" value="<?= $data['penerbit'] ?>">
                </div>
            </div>

            <!-- Harga Buku -->
            <div class="mb-3 row">
                <label for="harga" class="col-sm-2 col-form-label">Harga Buku</label>
                <div class="col-sm-6">
                    <input type="number" class="form-control" id="harga" name="harga" placeholder="Masukan Harga Buku"
                        value="<?= $data['harga'] ?>">
                </div>
            </div>

            <!-- Stok Buku -->
            <div class="mb-3 row">
                <label for="stok" class="col-sm-2 col-form-label">Stok Buku</label>
                <div class="col-sm-6">
                    <input type="number" class="form-control" id="stok" name="stok" placeholder="Masukan Stok Buku"
                        value="<?= $data['stok'] ?>">
                </div>
            </div>

            <a href="http://localhost:8080/PPB/php/toko_buku_web/books_crud/read-books.php">
                <button type="button" class="btn btn-outline-success" style="margin:20px 0px; ">Back</button>
            </a>

            <button class="btn btn-outline-success" type="submit">Submit</button>

        </form>
    </div>

    <script src="../assets-bs/bootstrap.js"></script>
</body>

</html>