<?php

namespace App\Http\Controllers;
use App\Models\Pelanggan;
use App\Models\Produk;
use Illuminate\Http\Request;

class PelangganController extends Controller
{
    public function tampil()
    {
        return view('pelanggan.index', [
            'pelanggan' => Pelanggan::all()
        ]);
    }

    public function tambah()
    {
        return view('pelanggan.create');
    }

    public function simpan(Request $request)
    {
        $pelanggan = new Pelanggan();
        $pelanggan->create($request->all());
        return redirect('/pelanggan');
    }

    public function edit($id)
    {
        return view('pelanggan.edit',[
            'ikan'=>Pelanggan::find($id)
        ]);
    }

    public function update(Request $request, $id)
    {
        Pelanggan::find($id)->update($request->all());
        return redirect('pelanggan.index');
    }

    public function hapus($id)
    {
        $pelanggan = Pelanggan::find($id);
    }
}
