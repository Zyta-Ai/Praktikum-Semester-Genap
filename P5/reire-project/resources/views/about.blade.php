<!DOCTYPE html>
<html lang="id">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tentang ReiriX - Lacak Kebiasaan & Refleksi Harian</title>
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
            <a href="{{ route('landing') }}" class="text-2xl font-bold text-white">ReiriX</a>
            <nav class="hidden md:flex items-center space-x-8">
                <a href="{{ route('landing') }}" class="hover:text-lime-300 transition-colors">Beranda</a>
                <a href="{{ route('about') }}" class="text-lime-300 font-semibold">Tentang</a>
                <a href="{{ route('login') }}" class="bg-gray-800 hover:bg-gray-700 text-white px-5 py-2 rounded-lg transition-colors">Login</a>
            </nav>
            <a href="{{ route('register') }}" class="md:hidden bg-lime-400 text-black font-bold px-5 py-2 rounded-lg hover:bg-lime-300 transition-colors">Daftar</a>
        </header>

        <section class="text-center py-16 md:py-24">
            <h1 class="text-4xl md:text-5xl font-extrabold text-white leading-tight">
                Tentang <span class="text-lime-300">ReiriX</span>
            </h1>
            <p class="mt-6 text-lg text-gray-400 max-w-3xl mx-auto">
                ReiriX lahir dari keyakinan bahwa pertumbuhan diri adalah sebuah perjalanan, bukan tujuan akhir. Kami percaya bahwa langkah kecil yang konsisten melalui refleksi harian adalah kunci untuk membuka potensi terbesar dalam diri kita.
            </p>
        </section>

        <section class="pb-20 md:pb-32 grid md:grid-cols-2 gap-12 items-center">
            <div class="text-left">
                <h2 class="text-3xl font-bold text-white mb-4">Misi Kami</h2>
                <p class="text-gray-400 leading-relaxed">
                    Misi kami adalah menyediakan alat yang sederhana, intuitif, dan kuat bagi siapa saja yang ingin memahami diri mereka lebih baik. Kami ingin mengubah proses refleksi yang terkadang terasa berat menjadi sebuah kebiasaan yang mencerahkan dan memberdayakan. Dengan ReiriX, Anda tidak hanya melacak apa yang Anda lakukan, tetapi juga memahami 'mengapa' di baliknya.
                </p>
            </div>
            <div class="card-bg p-8 rounded-2xl border border-gray-800">
                <h3 class="text-xl font-bold text-lime-300 mb-4">Filosofi Kami</h3>
                <ul class="space-y-4">
                    <li class="flex items-start">
                        <span class="text-lime-300 mr-3 mt-1">✓</span>
                        <span>
                            <strong class="text-white">Kesederhanaan itu Kuat.</strong> 
                            Fokus pada fitur inti tanpa distraksi agar Anda bisa langsung ke inti refleksi.
                        </span>
                    </li>
                    <li class="flex items-start">
                        <span class="text-lime-300 mr-3 mt-1">✓</span>
                        <span>
                            <strong class="text-white">Konsistensi adalah Kunci.</strong> 
                            Membantu Anda membangun momentum dengan melacak streak dan aktivitas harian.
                        </span>
                    </li>
                    <li class="flex items-start">
                        <span class="text-lime-300 mr-3 mt-1">✓</span>
                        <span>
                            <strong class="text-white">Data adalah Cerita.</strong> 
                            Menyajikan data Anda dalam bentuk insight yang mudah dipahami, bukan sekadar angka.
                        </span>
                    </li>
                </ul>
            </div>
        </section>

         <section class="text-center pb-20">
             <h2 class="text-3xl font-bold text-white">Siap Memulai Perjalanan Anda?</h2>
             <a href="{{ route('register') }}" class="mt-8 inline-block bg-lime-400 text-black font-bold px-8 py-4 rounded-lg hover:bg-lime-300 transition-transform hover:scale-105 neon-glow-green">
                Gabung Gratis Hari Ini
            </a>
        </section>
    </div>
</body>
</html>