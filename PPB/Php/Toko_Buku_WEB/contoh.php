<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>ReiterateMe - Habit Refleksi</title>
  <script src="https://cdn.tailwindcss.com"></script>
</head>
<body class="bg-gray-50 text-gray-800">
  <div class="max-w-4xl mx-auto py-10 px-6">
    <h1 class="text-3xl font-bold mb-4 text-center">📘 ReiterateMe</h1>
    <p class="text-center text-lg mb-8">Track kebiasaan belajar kamu dengan pendekatan reflektif & perbaikan berkelanjutan.</p>

    <!-- Form Tambah Habit Baru -->
    <div class="bg-white p-6 rounded-2xl shadow mb-10">
      <h2 class="text-xl font-semibold mb-4">+ Tambah Habit Baru</h2>
      <form class="space-y-4">
        <div>
          <label class="block text-sm font-medium">Judul Habit</label>
          <input type="text" placeholder="Contoh: Belajar JavaScript" class="w-full mt-1 p-2 border rounded-lg">
        </div>
        <div>
          <label class="block text-sm font-medium">Kategori</label>
          <select class="w-full mt-1 p-2 border rounded-lg">
            <option>Coding</option>
            <option>Trading</option>
            <option>Public Speaking</option>
            <option>Bahasa Inggris</option>
          </select>
        </div>
        <button class="bg-blue-600 hover:bg-blue-700 text-white px-4 py-2 rounded-xl">Simpan Habit</button>
      </form>
    </div>

    <!-- Form Log Refleksi Harian -->
    <div class="bg-white p-6 rounded-2xl shadow">
      <h2 class="text-xl font-semibold mb-4">📝 Log Refleksi Harian</h2>
      <form class="space-y-4">
        <div>
          <label class="block text-sm font-medium">Apa yang kamu pelajari hari ini?</label>
          <textarea class="w-full mt-1 p-2 border rounded-lg" rows="2"></textarea>
        </div>
        <div>
          <label class="block text-sm font-medium">Apa tantangan atau kesalahan hari ini?</label>
          <textarea class="w-full mt-1 p-2 border rounded-lg" rows="2"></textarea>
        </div>
        <div>
          <label class="block text-sm font-medium">Apa yang akan kamu perbaiki besok?</label>
          <textarea class="w-full mt-1 p-2 border rounded-lg" rows="2"></textarea>
        </div>
        <button class="bg-green-600 hover:bg-green-700 text-white px-4 py-2 rounded-xl">Simpan Log</button>
      </form>
    </div>

    <!-- Section Histori (mockup saja dulu) -->
    <div class="mt-10">
      <h3 class="text-lg font-semibold mb-4">📆 Histori Refleksi</h3>
      <ul class="space-y-3">
        <li class="bg-white p-4 rounded-xl shadow">
          <p class="text-sm text-gray-500">24 April 2025</p>
          <p class="mt-1 font-medium">Belajar fungsi & arrow function. Masih bingung dengan scope. Besok mau buat diagram visualisasi.</p>
        </li>
        <li class="bg-white p-4 rounded-xl shadow">
          <p class="text-sm text-gray-500">23 April 2025</p>
          <p class="mt-1 font-medium">Belajar `let` dan `const`. Kesalahan di deklarasi ulang. Besok mau latihan soal.</p>
        </li>
      </ul>
    </div>
  </div>
</body>
</html>