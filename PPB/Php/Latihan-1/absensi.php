<?php
$conn = new mysqli("localhost", "root", '', 'db_praktekum_2');

if ($conn->connect_error) {
    die("Koneksi Gagal : " . $conn->connect_error);
    // Fungsi Die untuk mematikan porses php
}
;

$query = "SELECT * FROM absensi";

//Menjalankan Query : 
$hasil = $conn->query($query);

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<table>
        <thead>
            <tr>
                <th>Id Karyawan</th>
                <th>Nama Lengkap</th>
                <th>Tanggal Lahir</th>
                <th>Jenis Kelamin</th>
                <th>Id Jabatan</th>
            </tr>
        </thead>

        <tbody>
            <?php while($item = $hasil->fetch_assoc()): ?>
                <tr>
                    <td> <?php echo $item['id_absensi']; ?> </td>
                    <td> <?= $item['id_karyawan'] ?> </td>
                    <td> <?php echo $item['tanggal']; ?> </td>
                    <td> <?= $item['jam_masuk'] ?> </td>
                    <td> <?php echo $item['jam_keluar']; ?> </td>
                </tr>

            <?php endwhile; ?>
        </tbody>
    </table>
</body>
</html>