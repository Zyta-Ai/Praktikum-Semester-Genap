@extends('layouts.app')

@section('title', 'Isi Refleksi')

@section('content')
    <main class="flex-1 p-8 space-y-8">
        <section class="glass p-6 rounded-2xl shadow-xl">
            <h2 class="text-xl font-semibold text-gray-200 mb-4">Isi Refleksi Hari Ini</h2>
            @if ($habits->isEmpty())
                <p class="text-gray-400 mb-4">Belum ada habit. <a href="{{ route('habits.create') }}"
                        class="text-blue-400 hover:text-blue-500 ">Tambah habit dulu</a> untuk membuat refleksi.</p>
            @else
                <form action="{{ route('entries.store') }}" method="POST">
                    @csrf
                    <div class="mb-4">
                        <label for="habit_id" class="block text-gray-200 mb-2">Pilih Habit</label>
                        <select name="habit_id" id="habit_id"
                            class="w-full p-3 bg-gray-800 border border-gray-600 rounded-xl text-gray-200 @error('habit_id') border-red-400 @enderror">
                            @foreach ($habits as $habit)
                                <option value="{{ $habit->id }}" {{ old('habit_id') == $habit->id ? 'selected' : '' }}>
                                    {{ $habit->title }}</option>
                            @endforeach
                        </select>
                        @error('habit_id')
                            <p class="text-red-400 text-sm mt-1 neon-yellow">{{ $message }}</p>
                        @enderror
                    </div>
                    <div class="mb-4">
                        <label for="learned" class="block text-gray-200 mb-2">Apa yang Dipelajari</label>
                        <textarea name="learned" id="learned"
                            class="w-full p-3 bg-gray-800 border border-gray-600 rounded-xl text-gray-200 @error('learned') border-red-400 @enderror"
                            rows="5">{{ old('learned') }}</textarea>
                        @error('learned')
                            <p class="text-red-400 text-sm mt-1 neon-yellow">{{ $message }}</p>
                        @enderror
                    </div>
                    <div class="mb-4">
                        <label for="mistake" class="block text-gray-200 mb-2">Kendala (Opsional)</label>
                        <textarea name="mistake" id="mistake"
                            class="w-full p-3 bg-gray-800 border border-gray-600 rounded-xl text-gray-200 @error('mistake') border-red-400 @enderror"
                            rows="5">{{ old('mistake') }}</textarea>
                        @error('mistake')
                            <p class="text-red-400 text-sm mt-1 neon-yellow">{{ $message }}</p>
                        @enderror
                    </div>
                    <div class="mb-4">
                        <label for="improvement" class="block text-gray-200 mb-2">Perbaikan (Opsional)</label>
                        <textarea name="improvement" id="improvement"
                            class="w-full p-3 bg-gray-800 border border-gray-600 rounded-xl text-gray-200 @error('improvement') border-red-400 @enderror"
                            rows="5">{{ old('improvement') }}</textarea>
                        @error('improvement')
                            <p class="text-red-400 text-sm mt-1 neon-yellow">{{ $message }}</p>
                        @enderror
                    </div>
                    <div class="flex space-x-4">
                        <button type="submit"
                            class="bg-lime-400 text-white px-6 py-3 rounded-xl hover:bg-gray-950 hover:ring-2 hover:ring-lime-500 neon-glow-green">Kirim
                            Refleksi</button>
                        <a href="{{ route('habits.index') }}"
                            class="bg-gray-700 text-gray-200 px-6 py-3 rounded-xl hover:bg-gray-600 shadow-md">Batal</a>
                    </div>
                </form>
            @endif
        </section>
    </main>
@endsection
