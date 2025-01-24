<?php
$servername = "localhost";
$username = "root";
$password = "";
$db_name = "db_praktekum_2";

$conn = new mysqli($servername, $username, $password, $db_name);

if ($conn->connect_error) {
    die("Koneksi Gagal:" . $conn->connect_error);
}
;

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $nama_jabatan = $_POST["nama_jabatan"];
    $gaji_pokok = $_POST["gaji_pokok"];
}

if (isset($nama_jabatan)) {

    if (empty($nama_jabatan) || empty($gaji_pokok)) {
        echo "JANGAN ADA YANG KOSONG WOI";
    } else {
        $query = "INSERT INTO jabatan(nama_jabatan, gaji_pokok) VALUES('$nama_jabatan', $gaji_pokok);";
        $tambah = $conn->query($query);
    };
}

$conn->close();

?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Menambah Data Jabatan</title>
    <link rel="stylesheet" href="../assets/style.css">
</head>

<body>
    <!-- Form Tambah Jabatan Start -->
    <div class="container">
        <?php if (isset($tambah)): ?>
            <div class="alert alert-success" role="alert">
                <h4 class="alert-heading">Data Berhasil Dikirim</h4>              
            </div>
        <?php endif; ?>
        <form action="" method="post">
            <br> <br>
            <h3>Form Menambah Jabatan</h3>
            <br>

            <div class="mb-3 row">
                <label for="nama_jabatan" class="col-sm-2 col-form-label">Nama Jabatan</label>
                <div class="col-sm-6">
                    <input type="text" class="form-control" id="nama_jabatan" name="nama_jabatan"
                        placeholder="Masukan Nama Jabatan">
                </div>
            </div>

            <div class="mb-3 row">
                <label for="gaji_pokok" class="col-sm-2 col-form-label">Gaji Pokok</label>
                <div class="col-sm-6">
                    <input type="number" class="form-control" id="gaji_pokok" name="gaji_pokok"
                        placeholder="Masukan Gaji">
                </div>
            </div>

            <br>

            <button class="btn btn-primary" type="submit">Submit</button>

        </form>
    </div>

    <!-- Form Tambah Jabatan End -->
    <script src="../assets/bootstrap.js"></script>
</body>

</html>