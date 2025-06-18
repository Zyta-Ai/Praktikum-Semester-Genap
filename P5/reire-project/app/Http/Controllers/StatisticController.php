<?php

namespace App\Http\Controllers;

use App\Models\Entry;
use App\Models\Habit;
use Carbon\Carbon;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\DB;

class StatisticController extends Controller
{
    public function index()
    {
        $userId = Auth::id();

        $totalHabits = Habit::where('user_id', $userId)->count();
        $totalEntries = Entry::where('user_id', $userId)->count();

        $currentStreak = $this->calculateStreak($userId);

        $categoryDistribution = Habit::where('user_id', $userId)
            ->select('category', DB::raw('count(*) as count'))
            ->groupBy('category')
            ->pluck('count', 'category');

        $entriesLast30Days = Entry::where('user_id', $userId)
            ->where('date', '>=', Carbon::now()->subDays(29))
            ->groupBy('date')
            ->orderBy('date', 'asc')
            ->get([
                DB::raw('DATE(date) as date'),
                DB::raw('COUNT(*) as count')
            ]);
 
        $activityLabels = [];
        $activityData = [];
        $period = Carbon::now()->subDays(29)->startOfDay()->toPeriod(Carbon::now()->endOfDay());
        $entriesMap = $entriesLast30Days->keyBy('date');

        foreach ($period as $date) {
            $formattedDate = $date->format('Y-m-d');
            $activityLabels[] = $date->format('d M');
            $activityData[] = $entriesMap->has($formattedDate) ? $entriesMap[$formattedDate]->count : 0;
        }

        return view('statistics.index', [
            'totalHabits' => $totalHabits,
            'totalEntries' => $totalEntries,
            'currentStreak' => $currentStreak,
            'categoryDistribution' => $categoryDistribution,
            'activityLabels' => $activityLabels,
            'activityData' => $activityData,
        ]);
    }

    private function calculateStreak($userId)
    {
        $streak = 0;
        $entryDates = Entry::where('user_id', $userId)
                             ->select('date')
                             ->distinct()
                             ->orderBy('date', 'desc')
                             ->pluck('date');

        if ($entryDates->isEmpty()) {
            return 0;
        }

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
        
        return $streak;
    }
}