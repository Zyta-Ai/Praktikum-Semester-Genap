<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Pelanggan extends Model
{
    protected $table = 'pelanggan';
    protected $primaryKey = 'pelangganId';
    protected $fillable = ['namaPelanggan', 'alamat', 'nomorTelepon'];
}
