<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class DashboardController extends Controller
{
    public function index(){
        return "Ini Halaman Dashboard";
    }

    public function profil($nama){
        return "Ini Profilnya $nama";
    }

    public $produk = [
        ['id' => 1, 'nama' => 'Kopi Hitam', 'harga' => 15000],
        ['id' => 2, 'nama' => 'Teh Manis', 'harga' => 10000],
        ['id' => 3, 'nama' => 'Roti Bakar', 'harga' => 20000],
        ['id' => 4, 'nama' => 'Nasi Goreng', 'harga' => 30000],
        ['id' => 5, 'nama' => 'Ayam Geprek', 'harga' => 25000],
        ['id' => 6, 'nama' => 'Mie Ayam', 'harga' => 20000],
        ['id' => 7, 'nama' => 'Es Jeruk', 'harga' => 12000],
        ['id' => 8, 'nama' => 'Susu Coklat', 'harga' => 17000],
        ['id' => 9, 'nama' => 'Burger', 'harga' => 25000],
        ['id' => 10, 'nama' => 'Kentang Goreng', 'harga' => 15000]
    ];

    public function produk(){
        return $this->produk;
    }

    public function produk_id($id){
        $detail = null;

        foreach($this->produk as $item){
            if($item['id'] == $id){
                $detail = $item;
                break;
            }
        }

        if($detail){
            return response()->json($detail);
        }else{
            return "Produk dengan ID: $id tidak ditemukan";
        }
    }

    public function cek_kategori($kategori = null){
        if($kategori){
            return "menampilkan produk dalam kategori: " . $kategori;
        }else{
            return "Menampilkan semua produk";
        }
    }
}
