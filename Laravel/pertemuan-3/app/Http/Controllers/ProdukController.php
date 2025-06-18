<?php

namespace App\Http\Controllers;

use App\Models\Produk;
use Illuminate\Http\Request;

class ProdukController extends Controller
{
    public function tampil(){
        return view('index', [
            'ikan'=>Produk::all()
        ]);
    }

    public function tambah(){
        return view('add');
    }

    public function simpan(Request $item){
        $produk = new Produk();
        // Simpan data ke database
        $produk->create($item->all());
        // Arahkan ke halaman 
        return redirect('/p');
    }

    public function edit($kode_produk){
        return view('edit', [
            "ikan"=>Produk::find($kode_produk)  
        ]); 
    }

    public function update(Request $request, $kode_produk){
        Produk::find($kode_produk)->update($request->all());

        return redirect('p');
    }

    public function hapus($kode_produk){
        Produk::find($kode_produk)->delete();

        return redirect('p');
    }
}
