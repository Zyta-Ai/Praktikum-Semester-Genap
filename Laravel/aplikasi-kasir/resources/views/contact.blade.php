@extends('layouts.main')

@section('bagian-css')
    <style>
        .contact-section {
            padding: 50px 0;
            background-color: #f8f9fa;
        }

        .contact-section h1 {
            font-weight: bold;
            color: #343a40;
        }

        .contact-section p {
            color: #6c757d;
            font-size: 1.1rem;
        }

        .contact-info {
            background-color: #ffffff;
            border-radius: 10px;
            padding: 20px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
        }
    </style>
@endsection

@section('bagian-konten')
    <section class="contact-section">
        <div class="container">
            <div class="text-center mb-5">
                <h1>Hubungi Kami</h1>
                <p class="lead">Kami siap membantu Anda dengan pertanyaan atau informasi tentang Kafenya.</p>
            </div>
            <div class="row justify-content-center">
                <div class="col-md-6">
                    <div class="contact-info">
                        <h5>Kontak Kami</h5>
                        <p><strong>Alamat:</strong> Jl. Kopi Nikmat No. 123, Jakarta, Indonesia</p>
                        <p><strong>Telepon:</strong> +62 812-3456-7890</p>
                        <p><strong>Email:</strong> info@kafenya.com</p>
                        <p><strong>Jam Operasional:</strong> Senin - Minggu, 08:00 - 20:00</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
@endsection
