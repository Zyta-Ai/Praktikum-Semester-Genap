<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class ProdukController extends Controller
{
    public function produk_cafe()
    {
        $produk = [
            ['id' => 1, 'nama' => 'Kopi Hitam', 'harga' => 15000, 'stok' => 10],
            ['id' => 2, 'nama' => 'Teh Manis', 'harga' => 10000, 'stok' => 5],
            ['id' => 3, 'nama' => 'Roti Bakar', 'harga' => 20000, 'stok' => 0],
            ['id' => 4, 'nama' => 'Nasi Goreng', 'harga' => 30000, 'stok' => 7],
            ['id' => 5, 'nama' => 'Ayam Geprek', 'harga' => 25000, 'stok' => 3],
            ['id' => 6, 'nama' => 'Mie Ayam', 'harga' => 20000, 'stok' => 0],
            ['id' => 7, 'nama' => 'Es Jeruk', 'harga' => 12000, 'stok' => 8],
            ['id' => 8, 'nama' => 'Susu Coklat', 'harga' => 17000, 'stok' => 4],
            ['id' => 9, 'nama' => 'Burger', 'harga' => 25000, 'stok' => 6],
            ['id' => 10, 'nama' => 'Kentang Goreng', 'harga' => 15000, 'stok' => 0]
        ];

        return view('produk', compact('produk'));
    }

    public function produk_cafe_about(){
        return view('about');
    }

    public function produk_cafe_contact(){
        return view('contact');
    }
}
