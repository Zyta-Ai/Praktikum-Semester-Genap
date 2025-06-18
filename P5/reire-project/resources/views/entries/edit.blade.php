@extends('layouts.app')

@section('title', 'Edit Refleksi')

@section('content')
    <main class="flex-1 p-8 space-y-8">
        <section class="glass p-6 rounded-2xl shadow-xl">
            <h2 class="text-xl font-semibold text-gray-200 mb-4">Edit Refleksi</h2>
            
            <form action="{{ route('entries.update', $entry->id) }}" method="POST">
                @csrf
                <div class="mb-4">
                    <label for="habit_id" class="block text-gray-200 mb-2">Pilih Habit</label>
                    <select name="habit_id" id="habit_id"
                        class="w-full p-3 bg-gray-800 border border-gray-600 rounded-xl text-gray-200 @error('habit_id') border-red-400 @enderror">
                        @foreach ($habits as $habit)
                            <option value="{{ $habit->id }}" {{ old('habit_id', $entry->habit_id) == $habit->id ? 'selected' : '' }}>
                                {{ $habit->title }}
                            </option>
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
                        rows="5">{{ old('learned', $entry->learned) }}</textarea>
                    @error('learned')
                        <p class="text-red-400 text-sm mt-1 neon-yellow">{{ $message }}</p>
                    @enderror
                </div>

                <div class="mb-4">
                    <label for="mistake" class="block text-gray-200 mb-2">Kendala (Opsional)</label>
                    <textarea name="mistake" id="mistake"
                        class="w-full p-3 bg-gray-800 border border-gray-600 rounded-xl text-gray-200 @error('mistake') border-red-400 @enderror"
                        rows="5">{{ old('mistake', $entry->mistake) }}</textarea>
                    @error('mistake')
                        <p class="text-red-400 text-sm mt-1 neon-yellow">{{ $message }}</p>
                    @enderror
                </div>

                <div class="mb-4">
                    <label for="improvement" class="block text-gray-200 mb-2">Perbaikan (Opsional)</label>
                    <textarea name="improvement" id="improvement"
                        class="w-full p-3 bg-gray-800 border border-gray-600 rounded-xl text-gray-200 @error('improvement') border-red-400 @enderror"
                        rows="5">{{ old('improvement', $entry->improvement) }}</textarea>
                    @error('improvement')
                        <p class="text-red-400 text-sm mt-1 neon-yellow">{{ $message }}</p>
                    @enderror
                </div>
                
                <div class="flex space-x-4">
                    <button type="submit"
                        class="bg-lime-500 text-white px-6 py-3 rounded-xl hover:bg-gray-950 hover:ring-2 hover:ring-lime-500">Simpan Perubahan</button>
                    <a href="{{ route('entries.index') }}"
                        class="bg-gray-700 text-gray-200 px-6 py-3 rounded-xl hover:bg-gray-600 shadow-md">Batal</a>
                </div>
            </form>
        </section>
    </main>
@endsection