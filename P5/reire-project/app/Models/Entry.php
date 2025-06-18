<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use Illuminate\Database\Eloquent\Factories\HasFactory;

class Entry extends Model
{
   use HasFactory;

    protected $fillable = ['user_id', 'habit_id', 'learned', 'mistake', 'improvement', 'date'];

    protected $casts = [
        'date' => 'date',
    ];
    
    public function habit()
    {
        return $this->belongsTo(Habit::class, 'habit_id');
    }
}
