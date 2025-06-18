<?php

use App\Http\Controllers\ContohController;
use App\Http\Controllers\ProdukController;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\DashboardController;

Route::get('/', function () {
    return view('welcome');
});

// Route::get('dashboard', function(){
//     return view('dashboard');
// });

// Route::post('dashboard', function(){
//     return "Ini method via POST";
// });

Route::get('/dashboard',[DashboardController::class, 'index']);

// Route Dengan Parameter : | Dynamic Root
Route::get('pengguna/profil/{nama}', [DashboardController::class, 'profil']);

// Soal Nomor 1:
Route::get('produk', [DashboardController::class, 'produk']);

// Soal Nomor 2:
Route::get('produk/{id}', [DashboardController::class, 'produk_id']);

// Soal nomor 3:
Route::get('kategori/{kategori?}', [DashboardController::class, 'cek_kategori']);

Route::get('contoh',[ContohController::Class, 'contoh']);

Route::get('produk-cafe',[ProdukController::Class, 'produk_cafe']);

Route::get('produk-cafe-about',[ProdukController::Class, 'produk_cafe_about']);

Route::get('produk-cafe-contact',[ProdukController::Class, 'produk_cafe_contact']);