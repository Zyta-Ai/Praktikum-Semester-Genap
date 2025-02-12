<?php
include "../template/config_db.php";

// Ambil Data Buku
$query = "SELECT * FROM books";

$buku = $conn->query($query);

$list_buku = [];
while ($data = $buku->fetch_assoc()) {
    $list_buku[] = $data;
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Form Transaksi</title>
    <link rel="stylesheet" href="../assets-bs/style.css">
    <link rel="stylesheet" href="../assets-bs/transaksi.css">

    <style>
        .pembayaran {
            margin: 0 10px;
        }
    </style>
</head>

<body>
    <?php include "../template/navbar.php"; ?>

    <br>
    <div class="container"
        style="display:flex; border:1px solid black; padding:10px; border-radius:10px; flex-direction:column;">
        <table class="table table-sm table-bordered">
            <thead style="">
                <tr>
                    <th>Kode Buku</th>
                    <th>Judul</th>
                    <th>Penerbit</th>
                    <th>Harga</th>
                    <th>Jml</th>
                    <th>Subtotal</th>
                </tr>
            </thead>

            <tbody>
                <tr>
                    <td>
                        <input type="text" name="" id="kode_buku" class="form-control form-control-sm"
                            list="list_kode_buku">

                        <datalist id="list_kode_buku">

                        </datalist>
                    </td>
                    <td><input type="text" name="" id="judul" class="form-control form-control-sm"></td>
                    <td><input type="text" name="" id="penerbit" class="form-control form-control-sm"></td>
                    <td><input type="text" name="" id="harga" class="form-control form-control-sm"></td>
                    <td><input type="text" name="" id="jumlah" class="form-control form-control-sm"></td>
                    <td><input type="text" name="" id="subtotal" class="form-control form-control-sm"></td>
                </tr>
            </tbody>
        </table>


        <div class="pembayaran-container" style="display:flex;">
            <div class="form_pembayaran">
                <label class="pembayaran" for="total">Total</label>
                <input type="text" name="" id="total">
            </div>
            <div class="form_pembayaran">
                <label class="pembayaran" for="bayar">Bayar</label>
                <input type="text" name="" id="bayar">
            </div>
            <div class="form_pembayaran">
                <label class="pembayaran" for="kembali">Kembali</label>
                <input type="text" name="" id="kembali">
            </div>
        </div>

    </div>

    <script src="../assets-bs/bootstrap.js"></script>

    <script>
        let daftar_buku = <?= json_encode($list_buku) ?>;

        document.getElementById("kode_buku").oninput =function(){
            let kode = this.value;
            let filterBuku = daftar_buku.filter(buku=>buku.kode_buku.includes(kode));
            
            if(filterBuku.length > 0){
                filterBuku =filterBuku.slice(0, 5); // Membatasi Jumlah yang Di Tampilkan

                document.getElementById("list_kode_buku").innerHTML = filterBuku.map(buku=>`<option value="${buku.kode_buku}">${buku.kode_buku}-${buku.judul}</option>`).join("")
            };
        }
    </script>
</body>
</html>