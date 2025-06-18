<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Produk extends Model
{
    protected $table = 'produk';
    protected $primaryKey = 'produkId';
    protected $fillable = ['namaProduk', 'harga', 'stok'];
}
