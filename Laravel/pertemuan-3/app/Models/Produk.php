<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Produk extends Model
{
    // Deklarasi nama tabel
    protected $table = "produk";
    protected $primaryKey = "kode_produk";
    public $incrementing = false;
    protected $keyType = 'string';
    protected $guarded = [];
}
