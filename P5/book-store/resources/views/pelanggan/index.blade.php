@extends('layouts.app')

@section('content')
    <h1>Daftar Pelanggan</h1>
    <a href="/pelanggan/create" class="btn btn-primary">Tambah Pelanggan</a>
    @if (session('success'))
        <div class="alert alert-success mt-3">{{ session('success') }}</div>
    @endif
    <table class="table mt-3">
        <thead>
            <tr>
                <th>ID</th>
                <th>Nama</th>
                <th>Alamat</th>
                <th>Nomor Telepon</th>
                <th>Aksi</th>
            </tr>
        </thead>
        <tbody>
            @foreach ($pelanggan as $p)
                <tr>
                    <td>{{ $p->pelanggan_id }}</td>
                    <td>{{ $p->namaPelanggan }}</td>
                    <td>{{ $p->alamat }}</td>
                    <td>{{ $p->nomorTelepon }}</td>
                    <td>
                        <a href="/pelanggan/edit/{{ $p->pelanggan_id }}" class="btn btn-warning btn-sm">Edit</a>
                        <a href="/pelanggan/delete/{{ $p->pelanggan_id }}" class="btn btn-danger btn-sm">Hapus</a>
                    </td>
                </tr>
            @endforeach
        </tbody>
    </table>
@endsection