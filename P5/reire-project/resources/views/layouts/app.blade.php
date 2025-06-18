<!DOCTYPE html>
<html lang="{{ str_replace('_', '-', app()->getLocale()) }}">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ReiriX - @yield('title')</title>

    @vite('resources/css/app.css')

    <script defer src="https://cdn.jsdelivr.net/npm/alpinejs@3.x.x/dist/cdn.min.js"></script>
    <style>
        body {
            background: radial-gradient(circle at center, #0f172a 0%, #000000 100%);
        }

        .glassmorphic {
            background: rgba(31, 41, 55, 0.5);
            backdrop-filter: blur(10px);
            border: 1px solid rgba(255, 255, 255, 0.1);
        }

        .glass {
            background: rgba(255, 255, 255, 0.05);
            backdrop-filter: blur(12px);
            border: 1px solid rgba(255, 255, 255, 0.1);
        }

        .neon-blue {
            box-shadow: 0 0 10px rgba(59, 130, 246, 0.7);
        }

        .neon-yellow {
            text-shadow: 0 0 5px rgba(234, 179, 8, 0.7);
        }

        .neon-glow-green {
            box-shadow: 0 0 15px rgba(163, 230, 53, 0.4), 0 0 5px rgba(163, 230, 53, 0.6);
        }
    </style>
</head>

<body class="bg-gray-900 font-sans text-gray-200">

    @auth
        <div class="flex min-h-screen">
            <nav class="w-64 glassmorphic p-4 fixed h-full">
                <h1 class="text-2xl font-bold text-white mb-6">ReiriX</h1>
                <ul>
                    <li class="mb-2"><a href="{{ route('habits.index') }}"
                            class="flex items-center text-gray-200 hover:bg-gray-700 hover:bg-opacity-50 p-2 rounded">Dashboard</a>
                    </li>
                    <li class="mb-2"><a href="{{ route('entries.create') }}"
                            class="flex items-center text-gray-200 hover:bg-gray-700 hover:bg-opacity-50 p-2 rounded">Tulis
                            Refleksi</a></li>
                    <li class="mb-2"><a href="{{ route('entries.index') }}"
                            class="flex items-center text-gray-200 hover:bg-gray-700 hover:bg-opacity-50 p-2 rounded">Riwayat
                            Refleksi</a></li>
                    <li class="mb-2"><a href="{{ route('statistics.index') }}"
                            class="flex items-center text-gray-200 hover:bg-gray-700 hover:bg-opacity-50 p-2 rounded">Insight
                            & Statistik</a></li>
                </ul>
            </nav>

            <div class="flex-1 ml-64">
                <header class="flex justify-between items-center p-6">
                    <h1 class="text-3xl font-bold text-lime-300">@yield('title', 'Dashboard')</h1>
                    <div class="flex items-center gap-4">
                        <span class="text-sm text-gray-300">Hi, {{ Auth::user()->name }}</span>

                        <div x-data="{ open: false }" @click.outside="open = false" class="relative">
                            <button @click="open = !open"
                                class="bg-lime-500 hover:bg-lime-400 text-black px-3 py-1 rounded-xl text-sm">
                                <span>☰</span>
                            </button>

                            <div x-show="open" x-transition
                                class="absolute right-0 mt-2 w-40 bg-gray-800/80 glass text-sm rounded-xl p-2 z-10"
                                style="display: none;">

                                <a href="#"
                                    class="block w-full text-left px-3 py-1 hover:bg-white/20 rounded">Pengaturan</a>

                                <a href="{{ route('about') }}" target="_blank" class="block w-full text-left px-3 py-1 hover:bg-white/20 rounded">Tentang</a>
                                
                                <form method="POST" action="{{ route('logout') }}" class="w-full">
                                    @csrf
                                    <button type="submit"
                                        class="block w-full text-left px-3 py-1 hover:bg-white/20 rounded">
                                        Logout
                                    </button>
                                </form>
                            </div>
                        </div>
                    </div>
                </header>

                <div class="px-6 pb-6">
                    @yield('content')
                </div>
            </div>
        </div>
    @else
        <main class="min-h-screen flex flex-col items-center justify-center p-6">
            @yield('content')
        </main>
    @endauth

     @stack('scripts')
</body>

</html>
