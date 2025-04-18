<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Toko Bheka</title>
    <link rel="stylesheet" href="/node_modules/bootstrap/dist/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">
    <link rel="stylesheet" href="/assets-bs/style.css">
    <link rel="stylesheet" href="/app/styles/main.css">
</head>

<body class=" bg-body-tertiary">
    <div id="main" class="d-flex">
        <?php
        // Include sidebar.php dengan path relatif yang benar
        $sidebar_path = "../templatee/sidebar.php";
        if (file_exists($sidebar_path)) {
            include $sidebar_path;
        } else {
            echo "File sidebar.php tidak ditemukan di path: " . realpath($sidebar_path);
            exit();
        }

        // Ambil nilai 'halaman' dari URL
        $halaman = isset($_GET['halaman']) ? $_GET['halaman'] : '';

        // Jika halaman kosong, gunakan halaman default ('dashboard')
        if ($halaman == '') {
            $halaman = 'dashboard';
        }

        // Path absolut ke file halaman
        $path_halaman = __DIR__ . "/../pages/$halaman.php";


        // Periksa apakah file halaman ada
        if (file_exists($path_halaman)) {
            include $path_halaman; // Muat file halaman
        } else {
            // Redirect ke halaman 404 jika file tidak ditemukan
            header("Location: http://localhost:8080/app/pages/pages404.php");
            exit();
        }
        ?>
    </div>
</body>

</html>