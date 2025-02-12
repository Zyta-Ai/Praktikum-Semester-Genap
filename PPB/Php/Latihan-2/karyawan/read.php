<?php
$servername = "localhost";
$username = "root";
$password = "";
$db_name = "db_praktekum_2";

$conn = new mysqli($servername, $username, $password, $db_name);

$tampil = "SELECT * FROM karyawan JOIN jabatan ON jabatan.id_jabatan = karyawan.id_jabatan";

$hasil = $conn->query($tampil);

?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Karyawan</title>
    <link rel="stylesheet" href="../assets/style.css">
</head>

<body>

    <div class="container">
        <br><br>
        <form action="" method="POST">
            <table class="table table-success table-striped">
                <thead class="table-dark">
                    <tr>
                        <th scope="col">ID Karyawan</th>
                        <th scope="col">Nama Karyawan</th>
                        <th scope="col">Tanggal Lahir</th>
                        <th scope="col">Jenis Kelamin</th>
                        <th scope="col">ID Jabatan</th>
                        <th scope="col">Edit</th>
                        <th scope="col">Hapus</th>
                    </tr>
                </thead>

                <tbody>
                    <?php while ($item = $hasil->fetch_assoc()): ?>

                        <tr>
                            <td> <?php echo $item['id_karyawan'] ?> </td>
                            <td> <?= $item['nama'] ?> </td>
                            <td> <?= $item['tanggal_lahir'] ?> </td>
                            <td> <?= $item['jenis_kelamin'] ?> </td>
                            <td> <?= $item['nama_jabatan'] ?> </td>

                                <td><a href="http://localhost:8080/PPB/Php/Latihan-2/karyawan/update.php?id_karyawan=<?= $item['id_karyawan'] ?>">Edit</a></td>
                                
                                <td><a href="http://localhost:8080/PPB/Php/Latihan-2/karyawan/delete.php?id_karyawan=<?= $item['id_karyawan'] ?>">Hapus</a></td>

                        </tr>

                    <?php endwhile; ?>
                </tbody>
            </table>
        </form>
    </div>

    <script src="../assets/bootstrap.js"></script>
</body>

</html>