<?php
$servername = "localhost";
$username = "root";
$password = "";
$db_name = "db_praktekum_2";

$conn = new mysqli($servername, $username, $password, $db_name);

$tampil = "SELECT * FROM jabatan";

$hasil = $conn->query($tampil);

?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tampilkan</title>

    <link rel="stylesheet" href="../assets/style.css">
</head>

<body>
    <br>
    <br>

    <div class="container">

        <form action="" method="post">
            <table class="table">
                <thead class="table-dark">
                    <tr>
                        <th scope="col">ID Jabatan</th>
                        <th scope="col">Nama Jabatan</th>
                        <th scope="col">Gaji Pokok</th>
                        <th scope="col">#</th>
                        <th scope="col">Hapus</th>                      
                    </tr>
                </thead>
                <tbody>
                    <?php while ($item = $hasil->fetch_assoc()): ?>

                        <tr>
                            <td> <?php echo $item['id_jabatan'] ?> </td>
                            <td> <?= $item['nama_jabatan'] ?> </td>
                            <td> <?= $item['gaji_pokok'] ?> </td>
                            <td><a href="http://localhost:8080/PPB/Php/Latihan-2/Jabatan/update.php?id_jabatan=<?= $item['id_jabatan'] ?>">Edit</a></td>
                            <td><a href="http://localhost:8080/PPB/Php/Latihan-2/Jabatan/delete.php?id_jabatan=<?= $item['id_jabatan'] ?>">Hapus</a></td>

                        </tr>

                    <?php endwhile; ?>
                </tbody>
            </table>
        </form>
    </div>

    <script src="../assets/bootstrap.js"></script>
</body>

</html>