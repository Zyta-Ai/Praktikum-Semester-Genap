@extends('layouts.app')

@section('content')
    <h1>Daftar Produk</h1>
    <a href="/produk/create" class="btn btn-primary">Tambah Produk</a>
    @if (session('success'))
        <div class="alert alert-success mt-3">{{ session('success') }}</div>
    @endif
    <table class="table mt-3">
        <thead>
            <tr>
                <th>ID</th>
                <th>Nama Produk</th>
                <th>Harga</th>
                <th>Stok</th>
                <th>Aksi</th>
            </tr>
        </thead>
        <tbody>
            @foreach ($produk as $p)
                <tr>
                    <td>{{ $p->produk_id }}</td>
                    <td>{{ $p->namaProduk }}</td>
                    <td>{{ $p->harga }}</td>
                    <td>{{ $p->stok }}</td>
                    <td>
                        <a href="/produk/edit/{{ $p->produk_id }}" class="btn btn-warning btn-sm">Edit</a>
                        <a href="/produk/delete/{{ $p->produk_id }}" class="btn btn-danger btn-sm">Hapus</a>
                    </td>
                </tr>
            @endforeach
        </tbody>
    </table>
@endsection