<!DOCTYPE html>
<html lang="id">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ReiriX - @yield('title')</title>
    @vite('resources/css/app.css')
</head>
<body class="bg-gray-100">
    <div class="flex">
        <div class="w-64 bg-white p-4">
            <h1 class="text-xl font-bold">ReiriX</h1>
            <nav class="mt-4">
                <a href="{{ route('dashboard') }}" class="block py-2">🏠 Dashboard</a>
                <a href="{{ route('refleksi') }}" class="block py-2">📝 Refleksi</a>
                <a href="{{ route('riwayat') }}" class="block py-2">📂 Riwayat</a>
                <a href="{{ route('insight') }}" class="block py-2">📊 Insight</a>
                <a href="{{ route('pengaturan') }}" class="block py-2">⚙️ Pengaturan</a>
                <form action="{{ route('logout') }}" method="POST">
                    @csrf
                    <button type="submit" class="block py-2 text-red-500">🚪 Logout</button>
                </form>
            </nav>
        </div>
        <!-- Konten -->
        <div class="flex-1 p-4">
            <header class="bg-white p-4">
                <h2 class="text-lg font-bold">@yield('page-title')</h2>
                <p>Hi, {{ $user->name }}</p>
            </header>
            <main class="mt-4">
                @yield('content')
            </main>
        </div>
    </div>
</body>
</html>