<?php

namespace App\Http\Controllers;

use App\Models\Habit;
use App\Models\Entry;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Carbon\Carbon;

class HabitController extends Controller
{
    public function index()
    {
        $userId = Auth::id();
        $habits = Habit::where('user_id', $userId)->latest()->get();
        $stagnantHabits = Habit::where('user_id', $userId)
                                ->where('updated_at', '<', Carbon::now()->subDays(5))
                                ->get();

        $entryCount = Entry::where('user_id', $userId)->count();

        $streak = 0;
        $entryDates = Entry::where('user_id', $userId)
                             ->select('date')
                             ->distinct()
                             ->orderBy('date', 'desc')
                             ->pluck('date');

        if ($entryDates->isNotEmpty()) {
            $today = Carbon::today();
            $currentDate = Carbon::parse($entryDates->first());

            if ($currentDate->isSameDay($today) || $currentDate->isSameDay($today->copy()->subDay())) {
                $streak = 1;
                $previousDate = $currentDate;

                for ($i = 1; $i < $entryDates->count(); $i++) {
                    $currentDate = Carbon::parse($entryDates[$i]);
                    if ($previousDate->diffInDays($currentDate) === 1) {
                        $streak++;
                        $previousDate = $currentDate;
                    } else {
                        break;
                    }
                }
            }
        }

        return view('habits.index', [
            'habits' => $habits,
            'stagnantHabits' => $stagnantHabits,
            'streak' => $streak,
            'entryCount' => $entryCount,
        ]);
    }

    public function create()
    {
        return view('habits.create');
    }

    public function store(Request $request)
    {
        $request->validate([
            'title' => 'required|string|max:255|unique:habits,title,NULL,id,user_id,' . Auth::id(),
            'category' => 'required|string|in:Coding,Bahasa,Soft Skill',
        ], [
            'title.unique' => 'Habit dengan judul ini sudah ada.',
            'category.in' => 'Kategori harus Coding, Bahasa, atau Soft Skill.',
        ]);

        Habit::create([
            'user_id' => Auth::id(),
            'title' => $request->title,
            'category' => $request->category,
        ]);

        return redirect('/habits')->with('success', 'Habit berhasil ditambahkan!');
    }

    public function edit($id)
    {
        $habit = Habit::findOrFail($id);
        
        if (Auth::id() !== $habit->user_id) {
            abort(403, 'TIDAK DIIZINKAN');
        }

        return view('habits.edit', ['habit' => $habit]);
    }

    public function update(Request $request, $id)
    {
        $habit = Habit::findOrFail($id);
        if (Auth::id() !== $habit->user_id) {
            abort(403, 'TIDAK DIIZINKAN');
        }

        $request->validate([
            'title' => 'required|string|max:255|unique:habits,title,' . $id . ',id,user_id,' . Auth::id(),
            'category' => 'required|string|in:Coding,Bahasa,Soft Skill',
        ], [
            'title.unique' => 'Habit dengan judul ini sudah ada.',
            'category.in' => 'Kategori harus Coding, Bahasa, atau Soft Skill.',
        ]);

        $habit->update([
            'title' => $request->title,
            'category' => $request->category,
        ]);

        return redirect('/habits')->with('success', 'Habit berhasil diperbarui!');
    }

    public function destroy($id)
    {
        $habit = Habit::findOrFail($id);
        
        if (Auth::id() !== $habit->user_id) {
            abort(403, 'TIDAK DIIZINKAN');
        }

        $habit->delete();

        return redirect('/habits')->with('success', 'Habit berhasil dihapus!');
    }
}