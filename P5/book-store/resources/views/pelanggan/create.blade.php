@extends('layouts.app')

@section('content')
    <h1>Tambah Pelanggan</h1>
    <form action="/pelanggan/store" method="POST">
        @csrf
        <div class="mb-3">
            <label class="form-label">Nama Pelanggan</label>
            <input type="text" name="namaPelanggan" class="form-control" required>
        </div>
        <div class="mb-3">
            <label class="form-label">Alamat</label>
            <textarea name="alamat" class="form-control" required></textarea>
        </div>
        <div class="mb-3">
            <label class="form-label">Nomor Telepon</label>
            <input type="text" name="nomorTelepon" class="form-control" required>
        </div>
        <button type="submit" class="btn btn-primary">Simpan</button>
        <a href="/pelanggan" class="btn btn-secondary">Kembali</a>
    </form>
@endsection