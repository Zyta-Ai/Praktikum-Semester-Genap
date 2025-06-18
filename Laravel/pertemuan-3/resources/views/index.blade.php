<!doctype html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Bootstrap demo</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet"
        integrity="sha384-rbsA2VBKQhggwzxH7pPCaAqO46MgnOM80zW1RWuH61DGLwZJEdK2Kadq2F9CUG65" crossorigin="anonymous">
</head>
<body>
    <div class="container mt-5">
        <div class="container mt-5">
            <h2 class="mb-4">Daftar Produk</h2>
            <table class="table table-striped table-bordered">
                <thead class="table-dark">
                    <tr>
                        <th scope="col">Kode Produk</th>
                        <th scope="col">Nama Produk</th>
                        <th scope="col">Harga (Rp)</th>
                        <th scope="col">Stok</th>
                        <th scope="col">Aksi</th>
                    </tr>
                </thead>
                <tbody>
                    @foreach($ikan as $item)
                    <tr>
                        <td>{{$item->kode_produk}}</td>
                        <td>{{$item->nama}}</td>
                        <td>{{$item->harga}}</td>
                        <td>{{$item->stok}}</td>
                        <td>
                            <a href="p/update/{{$item->kode_produk}}"><button class="btn btn-sm btn-warning">Edit</button></a>
                            <a href="p/hapus/{{$item->kode_produk}}"><button class="btn btn-sm btn-danger">Hapus</button></a>
                            
                            
                        </td>
                    </tr>
                    @endforeach
                </tbody>
            </table>
        </div>
    </div>
</body>

</html>
