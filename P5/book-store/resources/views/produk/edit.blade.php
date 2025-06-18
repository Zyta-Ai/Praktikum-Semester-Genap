@extends('layouts.app')

@section('content')
    <h1>Edit Produk</h1>
    <form action="" method="POST">
        @csrf
        <div class="mb-3">
            <label class="form-label">Nama Produk</label>
            <input type="text" name="namaProduk" class="form-control" value="{{ $produk->namaProduk }}">
        </div>
        <div class="mb-3">
            <label class="form-label">Harga</label>
            <input type="number" name="harga" class="form-control" value="{{ $produk->harga }}">
        </div>
        <div class="mb-3">
            <label class="form-label">Stok</label>
            <input type="number" name="stok" class="form-control" value="{{ $produk->stok }}">
        </div>
        <button type="submit" class="btn btn-primary">Update</button>
        <a href="/produk" class="btn btn-secondary">Kembali</a>
    </form>
@endsection