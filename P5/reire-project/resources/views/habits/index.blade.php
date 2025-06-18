@extends('layouts.app')

@section('title', 'Dashboard')

@section('content')
    <main class="flex-1 p-8 space-y-8">

        @if ($habits->isEmpty() && $entryCount === 0)
            <section class="glass p-8 rounded-2xl shadow-xl text-center">
                <h1 class="text-3xl font-bold text-lime-300">Selamat Datang di ReiriX, {{ Auth::user()->name }}!</h1>
                <p class="text-gray-300 mt-4 max-w-2xl mx-auto">
                    Ini adalah ruang pribadi Anda untuk melacak kebiasaan, merefleksikan kemajuan, dan membangun versi terbaik dari diri Anda. Mulai perjalanan Anda dengan membuat habit pertama.
                </p>
                
                <a href="{{ route('habits.create') }}" class="mt-8 inline-block bg-blue-500 text-white font-bold px-8 py-4 rounded-xl hover:bg-blue-600 neon-blue shadow-lg transition-all text-lg">
                    Buat Habit Pertama Anda
                </a>

                <div class="mt-12 text-left grid md:grid-cols-3 gap-8 max-w-4xl mx-auto">
                    <div class="bg-gray-800/50 p-4 rounded-xl">
                        <h3 class="font-semibold text-gray-200">1. Buat Habit</h3>
                        <p class="text-sm text-gray-400 mt-1">Tentukan kebiasaan baru yang ingin Anda lacak, misalnya "Belajar Laravel" atau "Membaca Buku".</p>
                    </div>
                    <div class="bg-gray-800/50 p-4 rounded-xl">
                        <h3 class="font-semibold text-gray-200">2. Isi Refleksi</h3>
                        <p class="text-sm text-gray-400 mt-1">Setiap selesai melakukan habit, tulis refleksi singkat tentang apa yang dipelajari dan kendalanya.</p>
                    </div>
                    <div class="bg-gray-800/50 p-4 rounded-xl">
                        <h3 class="font-semibold text-gray-200">3. Lihat Progres</h3>
                        <p class="text-sm text-gray-400 mt-1">Pantau kemajuan dan habit yang stagnan melalui ringkasan di dashboard Anda.</p>
                    </div>
                </div>
            </section>

        @else

            @if (session('success'))
                <div class="bg-green-400 bg-opacity-20 text-green-200 p-4 mb-4 rounded-xl shadow-lg">
                    {{ session('success') }}
                </div>
            @endif

            <section class="glass p-6 rounded-2xl shadow-xl">
                <h2 class="text-xl font-semibold text-gray-200 mb-4">Ringkasan Hari Ini</h2>
                <p class="text-gray-200 mb-2">Streak aktif: <strong class="text-lime-300">{{ $streak }} hari</strong></p>
                
                @if ($stagnantHabits->isNotEmpty())
                    <p class="text-yellow-300 neon-yellow">Habit stagnan:</p>
                    <ul class="list-disc list-inside text-yellow-300">
                        @foreach ($stagnantHabits as $habit)
                            <li>{{ $habit->title }} (tidak aktif sejak {{ $habit->updated_at->format('d M') }})</li>
                        @endforeach
                    </ul>
                @else
                    <p class="text-green-400 ">Kerja bagus! Semua habit aktif.</p>
                @endif
            </section>

            <section class="grid grid-cols-1 md:grid-cols-3 gap-6">
                <a href="{{ route('habits.create') }}" class="glass p-6 rounded-2xl shadow-lg hover:ring-2 hover:ring-lime-400 cursor-pointer transition-all">
                    <h3 class="text-lg font-semibold text-gray-200">Tambah Habit</h3>
                    <p class="text-sm text-gray-400 mt-2">Mulai pelacakan kebiasaan baru hari ini.</p>
                </a>
                <a href="{{ route('entries.create') }}" class="glass p-6 rounded-2xl shadow-lg hover:ring-2 hover:ring-lime-400 cursor-pointer transition-all">
                    <h3 class="text-lg font-semibold text-gray-200">Refleksi Hari Ini</h3>
                    <p class="text-sm text-gray-400 mt-2">Tulis pembelajaran dan kendala hari ini.</p>
                </a>
                <a href="{{ route('statistics.index') }}" class="glass p-6 rounded-2xl shadow-lg hover:ring-2 hover:ring-lime-400 cursor-pointer transition-all">
                    <h3 class="text-lg font-semibold text-gray-200">Lihat Statistik</h3>
                    <p class="text-sm text-gray-400 mt-2">Cek progres minggu ini dalam grafik.</p>
                </a>
            </section>

            <section class="glass p-6 rounded-2xl shadow-xl">
                <h4 class="text-lg font-semibold text-gray-200 mb-4">Daftar Habits</h4>
                <div class="overflow-x-auto">
                    <table class="w-full">
                        <thead>
                            <tr class="bg-gray-700 bg-opacity-50">
                                <th class="p-3 text-left text-gray-200 font-semibold">Judul</th>
                                <th class="p-3 text-left text-gray-200 font-semibold">Kategori</th>
                                <th class="p-3 text-left text-gray-200 font-semibold">Aksi</th>
                            </tr>
                        </thead>
                        <tbody>
                            @foreach ($habits as $habit)
                                <tr class="hover:bg-gray-700 hover:bg-opacity-30 transition-all border-b border-gray-700">
                                    <td class="p-3 text-gray-200">{{ $habit->title }}</td>
                                    <td class="p-3 text-gray-200">{{ $habit->category }}</td>
                                    <td class="p-3 whitespace-nowrap">
                                        <a href="{{ route('habits.edit', $habit->id) }}" class="bg-lime-500 text-white px-4 py-2 rounded-xl hover:bg-gray-950 hover:ring-2 hover:ring-lime-500">Edit</a>
                                        <form action="{{ route('habits.destroy', $habit->id) }}" method="POST" class="inline">
                                            @csrf
                                            @method('DELETE')
                                            <button type="submit" class="bg-red-500 text-white font-bold px-4 py-2 rounded-lg hover:bg-red-600 shadow-md transition-all" onclick="return confirm('Yakin ingin menghapus habit ini?')">Hapus</button>
                                        </form>
                                    </td>
                                </tr>
                            @endforeach
                        </tbody>
                    </table>
                </div>
            </section>
        @endif
    </main>
@endsection