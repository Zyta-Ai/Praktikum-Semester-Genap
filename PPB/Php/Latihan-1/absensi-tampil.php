<?php 

$conn = new mysqli('localhost', 'root', '', 'db_praktekum_2');

$query = "SELECT * FROM absensi";

$hasil = $conn->query($query);

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Absensi</title>
</head>
<body>
    <table>
        <thead>
            <tr>
                <th>Id Absensi</th>
                <th>Id Karyawan</th>
                <th>Tanggal</th>
                <th>Jam Masuk</th>
                <th>Jam Keluar</th>
            </tr>
        </thead>

        <tbody>
            <?php while($item = $hasil->fetch_assoc()): ?>
                <tr>
                    <td> <?=$item['id_absensi']?> </td>
                    <td> <?=$item['id_karyawan']?> </td>
                    <td> <?=$item['tanggal']?> </td>
                    <td> <?=$item['jam_masuk']?> </td>
                    <td> <?=$item['jam_keluar']?> </td>
                </tr>
            <?php endwhile;?>
        </tbody>
    </table>
</body>
</html>