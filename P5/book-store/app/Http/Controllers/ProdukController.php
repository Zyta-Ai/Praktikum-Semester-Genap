<?php

namespace App\Http\Controllers;

use App\Models\Produk;
use Illuminate\Http\Request;

class ProdukController extends Controller
{
    public function tampil()
    {
        return view('produk.index', [
            'produk' => Produk::all()
        ]);
    }

    public function tambah()
    {
        return view('produk.create');
    }

    public function simpan(Request $request)
    {
        $produk = new Produk();
        $produk->create($request->all());
        return redirect('/produk')->with('success', 'Produk berhasil ditambahkan!');
    }

    public function edit($id)
    {
        $produk = Produk::find($id);
        if (!$produk) {
            return redirect('/produk')->with('error', 'Produk tidak ditemukan!');
        }
        return view('produk.edit', [
            'produk' => $produk
        ]);
    }

    public function update(Request $request, $id)
    {
        $produk = Produk::find($id);
        if (!$produk) {
            return redirect('/produk')->with('error', 'Produk tidak ditemukan!');
        }
        $produk->update($request->all());
        return redirect('/produk')->with('success', 'Produk berhasil diperbarui!');
    }

    public function hapus($id)
    {
        $produk = Produk::find($id);
        if (!$produk) {
            return redirect('/produk')->with('error', 'Produk tidak ditemukan!');
        }
        $produk->delete();
        return redirect('/produk')->with('success', 'Produk berhasil dihapus!');
    }
}
