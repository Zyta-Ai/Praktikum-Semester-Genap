@extends('layouts.main')

@section('bagian-css')
    <style>
        .about-section {
            background-color: #f8f9fa;
            padding: 50px 0;
        }

        .about-section h1 {
            font-weight: bold;
            color: #343a40;
        }

        .about-section p {
            color: #6c757d;
            font-size: 1.1rem;
        }

        .product-card {
            transition: transform 0.3s, box-shadow 0.3s;
        }

        .product-card:hover {
            transform: translateY(-5px);
            box-shadow: 0 8px 16px rgba(0, 0, 0, 0.2);
        }

        .product-card img {
            height: 200px;
            object-fit: cover;
        }
    </style>
@endsection

@section('bagian-konten')
    <section class="about-section">
        <div class="container">
            <div class="text-center mb-5">
                <h1>Tentang Produk Kafenya</h1>
                <p class="lead">Kafenya menyajikan produk kopi berkualitas tinggi dengan cita rasa autentik,
                    diproduksi dari biji kopi pilihan terbaik di Indonesia.</p>
            </div>
            <div class="row g-4">
                <div class="col-md-4">
                    <div class="card product-card">
                        <img src="https://via.placeholder.com/400x200?text=Kopi+Arabika" class="card-img-top"
                            alt="Kopi Arabika">
                        <div class="card-body">
                            <h5 class="card-title">Kopi Arabika</h5>
                            <p class="card-text">Kopi Arabika dari dataran tinggi Gayo dengan aroma lembut dan rasa yang
                                kaya.</p>
                            <a href="#" class="btn btn-primary">Lihat Detail</a>
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="card product-card">
                        <img src="https://via.placeholder.com/400x200?text=Kopi+Robusta" class="card-img-top"
                            alt="Kopi Robusta">
                        <div class="card-body">
                            <h5 class="card-title">Kopi Robusta</h5>
                            <p class="card-text">Kopi Robusta Lampung dengan karakter kuat dan sedikit pahit yang
                                menyegarkan.</p>
                            <a href="#" class="btn btn-primary">Lihat Detail</a>
                        </div>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="card product-card">
                        <img src="https://via.placeholder.com/400x200?text=Blend+Kafenya" class="card-img-top"
                            alt="Blend Kafenya">
                        <div class="card-body">
                            <h5 class="card-title">Blend Kafenya</h5>
                            <p class="card-text">Perpaduan unik Arabika dan Robusta untuk pengalaman kopi yang seimbang.
                            </p>
                            <a href="#" class="btn btn-primary">Lihat Detail</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
@endsection
