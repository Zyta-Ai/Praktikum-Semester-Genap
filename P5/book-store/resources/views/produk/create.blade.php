@extends('layouts.app')

@section('content')
    <h1>Tambah Produk</h1>
    <form action="/produk/store" method="POST">
        @csrf
        <div class="mb-3">
            <label class="form-label">Nama Produk</label>
            <input type="text" name="namaProduk" class="form-control" required>
        </div>
        <div class="mb-3">
            <label class="form-label">Harga</label>
            <input type="number" name="harga" class="form-control" step="0.01" required>
        </div>
        <div class="mb-3">
            <label class="form-label">Stok</label>
            <input type="number" name="stok" class="form-control" required>
        </div>
        <button type="submit" class="btn btn-primary">Simpan</button>
        <a href="/produk" class="btn btn-secondary">Kembali</a>
    </form>
@endsection