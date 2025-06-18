@extends('layouts.app')

@section('title', 'Detail Refleksi')

@section('content')
<main class="flex-1 p-8 space-y-8">
    <section class="glass p-8 rounded-2xl shadow-xl max-w-4xl mx-auto">
        <div class="border-b border-gray-700 pb-4 mb-6">
            <p class="text-sm text-gray-400">{{ $entry->date->format('l, d F Y') }}</p>
            <h2 class="text-3xl font-bold text-gray-100 mt-2">
                {{ $entry->habit->title }}
                <span class="text-sm align-middle font-medium bg-lime-500 text-black rounded-full px-3 py-1 ml-2">{{ $entry->habit->category }}</span>
            </h2>
        </div>

        <div class="space-y-6 text-gray-300 leading-relaxed">
            <div>
                <h3 class="font-semibold text-lg text-lime-300 mb-2">Apa yang Dipelajari</h3>
                <p class="whitespace-pre-wrap">{{ $entry->learned }}</p>
            </div>
            
            @if($entry->mistake)
            <div>
                <h3 class="font-semibold text-lg text-yellow-400 mb-2"> Kendala yang Dihadapi</h3>
                <p class="whitespace-pre-wrap">{{ $entry->mistake }}</p>
            </div>
            @endif

            @if($entry->improvement)
            <div>
                <h3 class="font-semibold text-lg text-blue-400 mb-2">Rencana Perbaikan</h3>
                <p class="whitespace-pre-wrap">{{ $entry->improvement }}</p>
            </div>
            @endif
        </div>

        <div class="border-t border-gray-700 pt-6 mt-8 flex items-center gap-4 flex-wrap">
            <a href="{{ route('entries.index') }}" class="bg-gray-700 text-gray-200 px-6 py-3 rounded-xl hover:bg-gray-600">
                ← Kembali ke Riwayat
            </a>
            <a href="{{ route('entries.edit', $entry->id) }}" class="bg-lime-500 text-white px-6 py-3 rounded-xl hover:bg-gray-950 hover:ring-2 hover:ring-lime-500 neon-glow-green">
                Edit Refleksi
            </a>
            <form action="{{ route('entries.destroy', $entry->id) }}" method="POST" class="ml-auto">
                @csrf
                @method('DELETE')
                <button type="submit" class="bg-red-400/80 text-white px-6 py-3 rounded-xl hover:bg-red-500/80" onclick="return confirm('Yakin ingin menghapus refleksi ini secara permanen?')">
                    Hapus
                </button>
            </form>
        </div>
    </section>
</main>
@endsection