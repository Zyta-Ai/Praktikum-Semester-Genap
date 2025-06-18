<!DOCTYPE html>
<html lang="id">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ReiriX - Lacak Kebiasaan & Refleksi Harian</title>
    @vite('resources/css/app.css')
    <style>

        .neon-glow-green {
            box-shadow: 0 0 15px rgba(163, 230, 53, 0.4), 0 0 5px rgba(163, 230, 53, 0.6);
        }
        .card-bg {
            background-color: #111827; 
        }
    </style>
</head>
<body class="bg-black text-gray-200 font-sans">

    <div class="container mx-auto px-6 py-4">
        <header class="flex justify-between items-center py-4">
            <h1 class="text-2xl font-bold text-white">ReiriX</h1>
            <nav class="hidden md:flex items-center space-x-8">
                <a href="#fitur" class="hover:text-lime-300 transition-colors">Fitur</a>
                <a href="{{ route('about') }}" class="hover:text-lime-300 transition-colors">Tentang</a>
                <a href="{{ route('login') }}" class="bg-gray-800 hover:bg-gray-700 text-white px-5 py-2 rounded-lg transition-colors">Login</a>
            </nav>
            <a href="{{ route('register') }}" class="md:hidden bg-lime-400 text-black font-bold px-5 py-2 rounded-lg hover:bg-lime-300 transition-colors">Daftar</a>
        </header>

        <section class="text-center py-20 md:py-32">
            <h1 class="text-4xl md:text-6xl font-extrabold text-white leading-tight">
                Lacak Kebiasaanmu. <br>
                <span class="text-lime-300">Refleksi Tiap Hari.</span>
            </h1>
            <p class="mt-6 text-lg text-gray-400 max-w-2xl mx-auto">
                Renungkan progres, temukan pola, dan bangun versi terbaik dari dirimu, satu refleksi setiap hari.
            </p>
            <a href="{{ route('register') }}" class="mt-10 inline-block bg-lime-400 text-black font-bold px-8 py-4 rounded-lg hover:bg-lime-300 transition-transform hover:scale-105 neon-glow-green">
                Mulai Sekarang - Gratis
            </a>
        </section>

        <section id="fitur" class="pb-20 md:pb-32">
            <div class="grid grid-cols-1 lg:grid-cols-3 gap-8">
                
                <div class="card-bg p-6 rounded-2xl border border-gray-800">
                    <h3 class="text-xl font-bold text-white mb-4">Tambah Kebiasaan</h3>
                    <div class="space-y-4">
                        <input type="text" placeholder="Nama Kebiasaan" class="w-full p-3 bg-gray-800 border border-gray-700 rounded-lg text-gray-200" disabled>
                        <button class="w-full bg-lime-400 text-black font-bold py-3 rounded-lg opacity-50 cursor-not-allowed">Tambah</button>
                    </div>
                </div>

                <div class="card-bg p-6 rounded-2xl border border-gray-800 lg:scale-105 shadow-2xl shadow-lime-500/10">
                     <h3 class="text-xl font-bold text-white mb-4">Refleksi Hari Ini</h3>
                     <div class="space-y-4">
                        <textarea placeholder="Apa yang kamu pelajari hari ini?" class="w-full p-3 bg-gray-800 border border-gray-700 rounded-lg text-gray-200 h-20" disabled></textarea>
                        <textarea placeholder="Kesalahan apa yang ditemui?" class="w-full p-3 bg-gray-800 border border-gray-700 rounded-lg text-gray-200" disabled></textarea>
                        <textarea placeholder="Bagaimana ingin perbaiki untuk besok?" class="w-full p-3 bg-gray-800 border border-gray-700 rounded-lg text-gray-200" disabled></textarea>
                        <button class="w-full bg-lime-400 text-black font-bold py-3 rounded-lg opacity-50 cursor-not-allowed">Simpan</button>
                     </div>
                </div>

                <div class="card-bg p-6 rounded-2xl border border-gray-800">
                    <h3 class="text-xl font-bold text-white mb-4">Histori Refleksi</h3>
                    <div class="space-y-4">
                        <div class="opacity-50">
                            <p class="text-sm text-gray-500">24 Apr 2024</p>
                            <p class="text-gray-300">Belajar async/await</p>
                        </div>
                        <div class="opacity-50">
                            <p class="text-sm text-gray-500">24 Apr 2024</p>
                            <p class="text-gray-300">Belajar async/await</p>
                        </div>
                        <div class="opacity-50">
                            <p class="text-sm text-gray-500">24 Apr 2024</p>
                            <p class="text-gray-300">Belajar async/await</p>
                        </div>
                    </div>
                </div>

            </div>
        </section>
    </div>

</body>
</html>