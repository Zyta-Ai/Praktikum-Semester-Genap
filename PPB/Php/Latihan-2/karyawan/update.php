<?php
$servername = "localhost";
$username = "root";
$password = "";
$db_name = "db_praktekum_2";

$conn = new mysqli($servername, $username, $password, $db_name);

if($conn->connect_error){
    die("koneksi gagal: " . $conn->connect_error);
};

$id_karyawan = $_GET['id_karyawan'];

if(isset($_POST["id_karyawan"])){
    $nama_karyawan = $_POST["nama"];
    $tanggal_lahir = $_POST["tanggal_lahir"];
    $jenis_kelamin = $_POST["jenis_kelamin"];
    $id_jabatan = $_POST["id_jabatan"];

    $query = "UPDATE karyawan SET nama = '$nama_karyawan', tanggal_lahir = '$tanggal_lahir', jenis_kelamin = '$jenis_kelamin', id_jabatan = $id_jabatan WHERE id_karyawan = $id_karyawan";

    $hasil = $conn->query( $query);
}

$karyawan = $conn->query("SELECT * FROM karyawan WHERE id_karyawan = $id_karyawan");
$data = $karyawan->fetch_assoc();

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
            <h3>Form Mengedit Karyawan</h3>
            <br>

            <div class="mb-3 row">
                <label for="nama_jabatan" class="col-sm-2 col-form-label">ID Karyawan</label>
                <div class="col-sm-6">
                    <input type="text" class="form-control" id="id_karyawan" name="id_karyawan"
                        placeholder="Masukan ID Karyawan" value="<?=$data['id_karyawan']?>">
                </div>
            </div>

            <div class="mb-3 row">
                <label for="nama_jabatan" class="col-sm-2 col-form-label">Nama Karyawan</label>
                <div class="col-sm-6">
                    <input type="text" class="form-control" id="nama" name="nama"
                        placeholder="Masukan Nama Karyawan" value="<?=$data['nama']?>">
                </div>
            </div>

                <div class="mb-3 row">
                    <label for="nama_jabatan" class="col-sm-2 col-form-label">Tanggal Lahir</label>
                    <div class="col-sm-6">
                        <input type="text" class="form-control" id="tanggal_lahir" name="tanggal_lahir"
                            placeholder="Masukan Tangga Lahir" value="<?=$data['tanggal_lahir']?>">
                    </div>
                </div>

                <div class="mb-3 row">
                    <label for="nama_jabatan" class="col-sm-2 col-form-label">Jenis Kelamin</label>
                    <div class="col-sm-6">
                        <input type="text" class="form-control" id="jenis_kelamin" name="jenis_kelamin"
                            placeholder="Masukan Jenis Kelamin" value="<?=$data['jenis_kelamin']?>">
                    </div>
                </div>

            <div class="mb-3 row">
                <label for="gaji_pokok" class="col-sm-2 col-form-label">ID Jabatan</label>
                <div class="col-sm-6">
                    <input type="text" class="form-control" id="id_jabatan" name="id_jabatan"
                        placeholder="Masukan ID Jabatan" value="<?=$data['id_jabatan']?>">
                </div>
            </div>

            <br>

            <button class="btn btn-primary" type="submit">Submit</button>
            <a href="http://localhost:8080/PPB/Php/Latihan-2/karyawan/read.php" class="btn btn-primary">
                Kembali
            </a>
        </form>
    </div>

    <!-- Form Tambah Jabatan End -->
    <script src="../assets/bootstrap.js"></script>
</body>

</html>