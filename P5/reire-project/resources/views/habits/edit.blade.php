@extends('layouts.app')

@section('title', 'Edit Habit')

@section('content')
    <main class="flex-1 p-8 space-y-8">
        <section class="glass p-6 rounded-2xl shadow-xl">
            <h2 class="text-xl font-semibold text-gray-200 mb-4">Edit Habit</h2>
            <form action="/habits/{{ $habit->id }}" method="POST">
                @csrf
                <div class="mb-4">
                    <label for="title" class="block text-gray-200 mb-2">Judul Habit</label>
                    <input type="text" name="title" id="title" class="w-full p-3 bg-gray-800 border border-gray-600 rounded-xl text-gray-200 @error('title') border-red-400 @enderror" value="{{ old('title', $habit->title) }}">
                    @error('title')
                        <p class="text-red-400 text-sm mt-1 neon-yellow">{{ $message }}</p>
                    @enderror
                </div>
                <div class="mb-4">
                    <label for="category" class="block text-gray-200 mb-2">Pilih Kategori</label>
                    <select name="category" id="category" class="w-full p-3 bg-gray-800 border border-gray-600 rounded-xl text-gray-200 @error('category') border-red-400 @enderror">
                        <option value="Coding" {{ $habit->category == 'Coding' ? 'selected' : '' }}>Coding</option>
                        <option value="Bahasa" {{ $habit->category == 'Bahasa' ? 'selected' : '' }}>Bahasa</option>
                        <option value="Soft Skill" {{ $habit->category == 'Soft Skill' ? 'selected' : '' }}>Soft Skill</option>
                    </select>
                    @error('category')
                        <p class="text-red-400 text-sm mt-1 neon-yellow">{{ $message }}</p>
                    @enderror
                </div>
                <div class="flex space-x-4">
                    <button type="submit" class="bg-lime-500 text-white px-6 py-3 rounded-xl hover:bg-gray-950 hover:ring-2 hover:ring-lime-500">Simpan Perubahan</button>
                    <a href="/habits" class="bg-gray-700 text-gray-200 px-6 py-3 rounded-xl hover:bg-gray-600">Batal</a>
                </div>
            </form>
        </section>
    </main>
@endsection