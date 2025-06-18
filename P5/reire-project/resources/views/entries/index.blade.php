@extends('layouts.app')

@section('title', 'Riwayat Refleksi')

@section('content')
    <main class="flex-1 p-8 space-y-8">
        @if (session('success'))
            <div class="bg-green-400 bg-opacity-20 text-black p-4 mb-4 rounded-xl neon-blue shadow-lg">
                {{ session('success') }}
            </div>
        @endif

        <section class="glass p-6 rounded-2xl shadow-xl">
            <div class="flex justify-between items-center mb-6">
                <h2 class="text-xl font-semibold text-gray-200">Log Refleksi Kamu</h2>
                <a href="{{ route('entries.create') }}" class="bg-lime-400 text-white px-6 py-3 rounded-xl hover:bg-gray-950 hover:ring-2 hover:ring-lime-500 neon-glow-green">+ Tambah Refleksi</a>
            </div>

            <div class="overflow-x-auto">
                <table class="w-full">
                    <thead>
                        <tr class="bg-gray-700 bg-opacity-50">
                            <th class="p-3 text-left text-gray-200">Tanggal</th>
                            <th class="p-3 text-left text-gray-200">Habit</th>
                            <th class="p-3 text-left text-gray-200">Ringkasan</th>
                            <th class="p-3 text-left text-gray-200">Aksi</th>
                        </tr>
                    </thead>
                    <tbody>
                        @forelse ($entries as $entry)
                            <tr class="hover:bg-gray-700 hover:bg-opacity-30 transition-all">
                                <td class="p-3 text-gray-200">{{ $entry->date->format('d M Y') }}</td>
                                <td class="p-3 text-gray-200">{{ $entry->habit ? $entry->habit->title : 'Habit tidak ditemukan' }}</td>
                                <td class="p-3 text-gray-200">{{ Str::limit($entry->learned, 50) }}</td>
                                <td class="p-3">
                                    <a href="{{ route('entries.show', $entry->id) }}" class="bg-lime-500 text-white px-4 py-2 rounded-lg hover:bg-gray-950 hover:ring-2 hover:ring-lime-500">Lihat</a>
    

                                    <a href="{{ route('entries.edit', $entry->id) }}" class="bg-lime-500 text-white px-4 py-2 rounded-lg hover:bg-gray-950 hover:ring-2 hover:ring-lime-500">Edit</a>
                                    <form action="{{ route('entries.destroy', $entry->id) }}" method="POST" class="inline">
                                        @csrf
                                        @method('DELETE')
                                        <button type="submit" class="bg-red-400 text-white px-4 py-2 rounded-lg hover:bg-red-500 neon-yellow shadow-md" onclick="return confirm('Yakin ingin menghapus refleksi ini?')">Hapus</button>
                                    </form>
                                </td>
                            </tr>
                        @empty
                            <tr>
                                <td colspan="4" class="p-3 text-gray-400 text-center">Belum ada refleksi. <a href="{{ route('entries.create') }}" class="text-blue-400 hover:text-blue-500 ">Tambah sekarang</a>.</td>
                            </tr>
                        @endforelse
                    </tbody>
                </table>
            </div>

            <div class="mt-6 flex justify-between items-center">
                {{ $entries->links() }}
            </div>
        </section>
    </main>
@endsection