<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Layout</title>
    @yield('bagian-css')

    <link rel="stylesheet" href="\bootstrap\css\bootstrap.min.css">
</head>

<body>
    <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">Laundry GLS</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNav"
                aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNav">
                <ul class="navbar-nav ms-auto">
                    <li class="nav-item">
                        <a class="nav-link active" aria-current="page" href="/produk-cafe">Product</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="/produk-cafe-about">About</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="/produk-cafe-contact">Contact</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    @yield('bagian-konten')
    <script src="\bootstrap\js\bootstrap.bundle.js"></script>
</body>

</html>
