@extends('layouts.app')

@section('content')
    <h1>Edit Pelanggan</h1>
    <form  method="POST">
        @csrf
        <div class="mb-3">
            <label class="form-label">Nama Pelanggan</label>
            <input type="text" name="namaPelanggan" class="form-control" value="{{$pelanggan->namaPelanggan}}">
        </div>
        <div class="mb-3">
            <label class="form-label">Alamat</label>
            <textarea name="alamat" class="form-control">{{ $pelanggan->alamat }}</textarea>
        </div>
        <div class="mb-3">
            <label class="form-label">Nomor Telepon</label>
            <input type="text" name="nomorTelepon" class="form-control" value="{{ $pelanggan->nomorTelepon }}">
        </div>
        <button type="submit" class="btn btn-primary">Update</button>
        <a href="/pelanggan" class="btn btn-secondary">Kembali</a>
    </form>
@endsection