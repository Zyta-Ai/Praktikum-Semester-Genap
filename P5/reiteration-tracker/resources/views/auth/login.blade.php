<!DOCTYPE html>
<html lang="id">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>ReiriX - Login</title>
    <link href="{{ asset('css/app.css') }}" rel="stylesheet">
</head>
<body class="bg-gray-100">
    <div class="w-full max-w-sm mx-auto mt-10 p-6 bg-white rounded shadow">
        <h2 class="text-xl font-bold text-center mb-4">Login ke ReiriX</h2>
        <form method="POST" action="{{ route('login') }}">
            @csrf
            <div class="mb-4">
                <label for="email" class="block text-sm">Email</label>
                <input id="email" type="email" name="email" value="{{ old('email') }}" 
                       class="w-full p-2 border rounded @error('email') border-red-500 @enderror">
                @error('email')
                    <p class="text-red-500 text-sm">{{ $message }}</p>
                @enderror
            </div>
            <div class="mb-4">
                <label for="password" class="block text-sm">Kata Sandi</label>
                <input id="password" type="password" name="password" 
                       class="w-full p-2 border rounded @error('password') border-red-500 @enderror">
                @error('password')
                    <p class="text-red-500 text-sm">{{ $message }}</p>
                @enderror
            </div>
            <button type="submit" class="w-full bg-blue-500 text-white p-2 rounded">Login</button>
        </form>
        <p class="mt-4 text-center">
            Belum punya akun? <a href="{{ route('register') }}" class="text-blue-500">Daftar</a>
        </p>
    </div>
</body>
</html>