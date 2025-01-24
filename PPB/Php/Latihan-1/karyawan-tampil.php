<?php
$conn = new mysqli("localhost", "root", '', 'db_praktekum_2');

if ($conn->connect_error) {
    die("Koneksi Gagal : " . $conn->connect_error);
    // Fungsi Die untuk mematikan porses php
}
;

$query = "SELECT * FROM karyawan";

//Menjalankan Query : 
$hasil = $conn->query($query);
$hasil2 = $conn->query($query);

// print_r(value:$hasil);

// while($item = $hasil->fetch_assoc()){
//     echo $item['nama'] . "<br>";
// };

?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Karyawan</title>
</head>
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
            <?php
            while ($item = $hasil->fetch_assoc()) {
                echo "<tr>
                    <td>" . $item['id_karyawan'] . "</td>
                    <td>" . $item['nama'] . "</td>
                    <td>" . $item['tanggal_lahir'] . "</td>
                    <td>" . $item['jenis_kelamin'] . "</td>
                    <td>" . $item['id_jabatan'] . "</td>
                </tr>
                ";
            }
            ?>

        </tbody>
    </table>

    <br>
    <br>

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
            <?php while($item = $hasil2->fetch_assoc()): ?>
                <tr>
                    <td> <?php echo $item['id_karyawan']; ?> </td>
                    <td> <?= $item['nama'] ?> </td>
                    <td> <?php echo $item['tanggal_lahir']; ?> </td>
                    <td> <?= $item['jenis_kelamin'] ?> </td>
                    <td> <?php echo $item['id_jabatan']; ?> </td>
                </tr>

            <?php endwhile; ?>
        </tbody>
    </table>

</body>
</html>