<?php

use App\Http\Controllers\ProdukController;
use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('welcome');
});

Route::get('/p',[ProdukController::class, 'tampil']);

Route::get('p/tambah',[ProdukController::class, 'tambah']);

Route::post('p/tambah',[ProdukController::class, 'simpan']);

Route::get('p/update/{kode_produk}',[ProdukController::class, 'edit']);

Route::post('p/update/{kode_produk}',[ProdukController::class, 'update']);

Route::get('p/hapus/{kode_produk}',[ProdukController::class, 'hapus']);

