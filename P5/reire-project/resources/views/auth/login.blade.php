@extends('layouts.app')

@section('title', 'Login')

@section('content')
<main class="flex-1 p-8 flex items-center justify-center">
    <section class="glass p-8 rounded-2xl shadow-xl w-full max-w-md">
        <h2 class="text-2xl font-semibold text-gray-200 mb-6 text-center">Login ke Akun Anda</h2>

        @if (session('status'))
            <div class="mb-4 font-medium text-sm text-green-400">
                {{ session('status') }}
            </div>
        @endif

        <form method="POST" action="{{ route('login') }}">
            @csrf

            <div class="mb-4">
                <label for="email" class="block text-gray-200 mb-2">Email</label>
                <input type="email" name="email" id="email" class="w-full p-3 bg-gray-800 border border-gray-600 rounded-xl text-gray-200 @error('email') border-red-400 @enderror" value="{{ old('email') }}" required autofocus>
                @error('email')
                    <p class="text-red-400 text-sm mt-1 neon-yellow">{{ $message }}</p>
                @enderror
            </div>

            <div class="mb-5">
                <label for="password" class="block text-gray-200 mb-2">Password</label>
                <input type="password" name="password" id="password" class="w-full p-3 bg-gray-800 border border-gray-600 rounded-xl text-gray-200 @error('password') border-red-400 @enderror" required>
                @error('password')
                    <p class="text-red-400 text-sm mt-1 neon-yellow">{{ $message }}</p>
                @enderror
            </div>

            <div class="block mb-6">
                <label for="remember_me" class="inline-flex items-center">
                    <input id="remember_me" type="checkbox" class="rounded border-gray-500 text-blue-500 shadow-sm focus:ring-blue-600 bg-gray-800" name="remember">
                    <span class="ml-2 text-sm text-gray-400">Ingat saya</span>
                </label>
            </div>

            <div class="flex items-center justify-between flex-wrap gap-4">
                <a class="text-sm text-gray-400 hover:text-blue-400" href="{{ route('register') }}">
                    Belum punya akun? Daftar
                </a>

                <button type="submit" class="bg-lime-400 text-white px-6 py-3 rounded-xl hover:bg-gray-950 hover:ring-2 hover:ring-lime-500 neon-glow-green">
                    Login
                </button>
            </div>
        </form>
    </section>
</main>
@endsection