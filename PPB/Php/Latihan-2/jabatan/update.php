<?php
$servername = "localhost";
$username = "root";
$password = "";
$db_name = "db_praktekum_2";

$conn = new mysqli($servername, $username, $password, $db_name);

if($conn->connect_error){
    die("koneksi gagal: " . $conn->connect_error);
};

$id_jabatan = $_GET['id_jabatan'];

// Proses Update
if(isset($_POST['nama_jabatan'])){
    $nama_jabatan = $_POST['nama_jabatan'];
    $gaji_pokok = $_POST['gaji_pokok'];

    $query = "UPDATE jabatan SET nama_jabatan = '$nama_jabatan', gaji_pokok = '$gaji_pokok' WHERE id_jabatan = $id_jabatan";

    $hasil = $conn->query($query);
}

$jabatan = $conn->query("SELECT * FROM JABATAN WHERE id_jabatan = $id_jabatan");
$data = $jabatan->fetch_assoc();

?>


<!-- Form Jabatan -->

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Edit Data Jabatan</title>
    <link rel="stylesheet" href="../assets/style.css">
</head>

<body>
    
    <br><br>
    <!-- Form Tambah Jabatan Start -->
    <div class="container">
        <?php if (isset($tambah)): ?>
            <div class="alert alert-success" role="alert">
                <h4 class="alert-heading">Data Berhasil Dikirim</h4>              
            </div>
        <?php endif; ?>
        <form action="" method="POST">
            <br> <br>
            <h3>Form Menambah Jabatan</h3>
            <br>

            <div class="mb-3 row">
                <label for="nama_jabatan" class="col-sm-2 col-form-label">Nama Jabatan</label>
                <div class="col-sm-6">
                    <input type="text" class="form-control" id="nama_jabatan" name="nama_jabatan"
                        placeholder="Masukan Nama Jabatan" value="<?=$data['nama_jabatan']?>">
                </div>
            </div>


            <div class="mb-3 row">
                <label for="gaji_pokok" class="col-sm-2 col-form-label">Gaji Pokok</label>
                <div class="col-sm-6">
                    <input type="number" class="form-control" id="gaji_pokok" name="gaji_pokok"
                        placeholder="Gaji Pokok" value="<?=$data['gaji_pokok']?>" >
                </div>
            </div>

            <br>

            <button class="btn btn-primary" type="submit">Submit</button>
            <a href="http://localhost:8080/PPB/Php/Latihan-2/Jabatan/read.php" class="btn btn-primary">
                Kembali
            </a>
            
            <br><br><br><br><br>
        </form>
    </div>

    <!-- Form Tambah Jabatan End -->
    <script src="../assets/bootstrap.js"></script>
</body>
</html>


