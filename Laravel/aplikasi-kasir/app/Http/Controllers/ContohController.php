<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class ContohController extends Controller
{
    public function contoh(){
        return view('contoh', [
            'nama'=>' Syaeful Imam Ganteng',
            'usia'=> 17,
            'kelas'=>'XI-PPLG',
            'hobi'=>'Main ML',
            'teman'=>[
                ['nama'=>'Amauri', 'status'=> 'Teman Mabar'],
                ['nama'=>'Lordy', 'status'=> 'Teman Remedial'],
                ['nama'=>'Aji', 'status'=> 'Teman Sok Asik'],
                ['nama'=>'Ghaisan', 'status'=> 'Teman Paling Baik Sedunia']
            ]
        ]);
    }

}
