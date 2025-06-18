<?php

namespace App\Http\Controllers;

use App\Models\Entry;
use App\Models\Habit;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

class EntryController extends Controller
{
    public function index()
    {

        $entries = Entry::where('user_id', Auth::id())->with('habit')->latest()->paginate(10);
        return view('entries.index', ['entries' => $entries]);
    }

    public function create()
    {
        $habits = Habit::where('user_id', Auth::id())->get();
        return view('entries.create', ['habits' => $habits]);
    }

    public function store(Request $request)
    {
        $request->validate([
            'habit_id' => 'required|exists:habits,id',
            'learned' => 'required|string|max:1000',
            'mistake' => 'nullable|string|max:1000',
            'improvement' => 'nullable|string|max:1000',
        ], [
            'habit_id.required' => 'Pilih habit terlebih dahulu.',
            'habit_id.exists' => 'Habit tidak valid.',
            'learned.required' => 'Isi apa yang dipelajari.',
        ]);

        Entry::create([
            'user_id' => Auth::id(),
            'habit_id' => $request->habit_id,
            'learned' => $request->learned,
            'mistake' => $request->mistake,
            'improvement' => $request->improvement,
            'date' => today(),
        ]);

        return redirect()->route('habits.index')->with('success', 'Refleksi berhasil disimpan!');
    }

    public function show(Entry $entry)
    {

        if (auth()->id() !== $entry->user_id) {
            abort(403, 'TIDAK DIIZINKAN');
        }

        return view('entries.show', ['entry' => $entry]);
    }

    public function edit($id)
    {
        $entry = Entry::findOrFail($id);
        $habits = Habit::all();
        return view('entries.edit', ['entry' => $entry, 'habits' => $habits]);
    }

    public function update(Request $request, $id)
    {
        $request->validate([
            'habit_id' => 'required|exists:habits,id',
            'learned' => 'required|string|max:1000',
            'mistake' => 'nullable|string|max:1000',
            'improvement' => 'nullable|string|max:1000',
        ], [
            'habit_id.required' => 'Pilih habit terlebih dahulu.',
            'habit_id.exists' => 'Habit tidak valid.',
            'learned.required' => 'Isi apa yang dipelajari.',
        ]);

        $entry = Entry::findOrFail($id);
        $entry->update([
            'habit_id' => $request->habit_id,
            'learned' => $request->learned,
            'mistake' => $request->mistake,
            'improvement' => $request->improvement,
            'date' => today(),
        ]);

        return redirect()->route('entries.index')->with('success', 'Refleksi berhasil diperbarui!');
    }

    public function destroy($id)
    {
        $entry = Entry::findOrFail($id);
        $entry->delete();

        return redirect()->route('entries.index')->with('success', 'Refleksi berhasil dihapus!');
    }


}

