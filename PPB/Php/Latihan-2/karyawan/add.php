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
    $id_karyawan = $_POST["id_karyawan"];
    $nama_karyawan = $_POST["nama"];
    $tanggal_lahir = $_POST["tanggal_lahir"];
    $jenis_kelamin = $_POST["jenis_kelamin"];
    $id_jabatan = $_POST["id_jabatan"];
}

if (isset($nama_karyawan)) {

    if (empty($id_karyawan) || empty($nama_karyawan)) {
        echo "JANGAN ADA YANG KOSONG!";
    } else {
        $query = "INSERT INTO karyawan(id_karyawan, nama, tanggal_lahir, jenis_kelamin, id_jabatan) VALUES('$id_karyawan','$nama_karyawan', '$tanggal_lahir', '$jenis_kelamin', $id_jabatan);";
        $tambah = $conn->query($query);
    }
    ;
}


$tampil = "SELECT * FROM jabatan";
$tampil_kedua = "SELECT * FROM karyawan";

$hasil = $conn->query($tampil);
$hasil2 = $conn->query($tampil_kedua);
$conn->close();

?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Karyawan Tambah</title>
    <link rel="stylesheet" href="../assets/style.css">
</head>

<body>
    <!-- Form Tambah Jabatan Start -->
    <div class="container">
        <?php if (isset($tambah)): ?>
            <div class="alert alert-success" role="alert">
                <br>
                <h4 class="alert-heading">Data Berhasil Dikirim</h4>
            </div>
        <?php endif; ?>
        <form action="" method="post">
            <br> <br>
            <h3>Form Menambah Karyawan</h3>
            <br>

                <div class="mb-3 row">
                    <label for="nama_jabatan" class="col-sm-2 col-form-label">ID Karyawan</label>
                    <div class="col-sm-6">
                        <input type="text" class="form-control" id="id_karyawan" name="id_karyawan"
                            placeholder="Masukan ID Karyawan">
                    </div>
                </div>

            <div class="mb-3 row">
                <label for="nama_jabatan" class="col-sm-2 col-form-label">Nama Karyawan</label>
                <div class="col-sm-6">
                    <input type="text" class="form-control" id="nama" name="nama" placeholder="Masukan Nama Karyawan">
                </div>
            </div>

            <div class="mb-3 row">
                <label for="nama_jabatan" class="col-sm-2 col-form-label">Tanggal Lahir</label>
                <div class="col-sm-6">
                    <input type="text" class="form-control" id="tanggal_lahir" name="tanggal_lahir"
                        placeholder="Masukan Tangga Lahir">
                </div>
            </div>

            <div class="form-check" style="display:flex; ">
                <div>
                <label class="" for="flexRadioDefault1" style="margin-right: 100px;">
                    Jenis Kelamin
                </label>
                </div>
                <input class="form-check-input" type="radio" name="flexRadioDefault" id="flexRadioDefault1">
                <label class="form-check-label" for="flexRadioDefault1">
                    Default radio
                </label>
            </div>

            <div style="display:flex;">
                <label for="nama_jabatan" class="col-sm-2 col-form-label">Nama Jabatan</label>
                <select class="form-select form-select-sm mb-3" style=" width: 550px;"
                    aria-label="Default select example">
                    <option selected>Open this select menu</option>
                    <?php while ($item = $hasil->fetch_assoc()): ?>
                        <option value=""><?= $item['nama_jabatan'] ?></option>
                    <?php endwhile; ?>
                </select>
            </div>



            <div class="mb-3 row">
                <label for="gaji_pokok" class="col-sm-2 col-form-label">ID Jabatan</label>
                <div class="col-sm-6">
                    <input type="text" class="form-control" id="id_jabatan" name="id_jabatan"
                        placeholder="Masukan ID Jabatan">
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