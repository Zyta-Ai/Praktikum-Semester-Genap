<?php
use App\Http\Controllers\PelangganController;
use App\Http\Controllers\ProdukController;

use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('welcome');
});

Route::get('/pelanggan', [PelangganController::class, 'tampil']);
Route::get('/pelanggan/create', [PelangganController::class, 'tambah']);
Route::post('/pelanggan/store', [PelangganController::class, 'simpan']);
Route::get('/pelanggan/edit/{id}', [PelangganController::class, 'edit']);
Route::post('/pelanggan/edit/{id}', [PelangganController::class, 'update']);
Route::get('/pelanggan/delete/{id}', [PelangganController::class, 'hapus']);

Route::get('/produk', [ProdukController::class, 'tampil']);
Route::get('/produk/create', [ProdukController::class, 'tambah']);
Route::post('/produk/store', [ProdukController::class, 'simpan']);
Route::get('/produk/edit/{id}', [ProdukController::class, 'edit']);
Route::post('/produk/update/{id}', [ProdukController::class, 'update']);
Route::get('/produk/delete/{id}', [ProdukController::class, 'hapus']);
