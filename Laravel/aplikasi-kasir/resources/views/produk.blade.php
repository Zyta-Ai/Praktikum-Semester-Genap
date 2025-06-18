@extends('layouts.main')

@section('bagian-css')
    <style>
        .table-container {
            background-color: #ffffff;
            border-radius: 10px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
            padding: 20px;
            margin: 20px auto;
        }

        .table thead th {
            background-color: #007bff;
            color: white;
            border: none;
        }

        .table tbody tr:hover {
            background-color: #f1f3f5;
        }

        .table tbody td {
            vertical-align: middle;
        }
    </style>
@endsection

@section('bagian-konten')
    <div class="container">
        <div class="table-container">
            <table class="table table-hover table-bordered">
                <thead>
                    <tr>
                        <th scope="col">No</th>
                        <th scope="col">Nama Produk</th>
                        <th scope="col">Harga</th>
                        <th scope="col">Stok </th>
                    </tr>
                </thead>
                <tbody>
                    @foreach ($produk as $item)
                        <tr>
                            <th scope="row">{{ $item['id'] }}</th>
                            <td>{{ $item['nama'] }}</td>
                            <td>Rp {{ $item['harga'] }}</td>

                            @if ($item['stok'] > 0)
                                <td>{{ $item['stok'] }}</td>
                            @else
                                <td>Stok habis</td>
                            @endif

                        </tr>
                    @endforeach
                </tbody>
            </table>
        </div>
    </div>
@endsection
