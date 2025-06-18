<?php
use App\Http\Controllers\DashboardController;
use App\Http\Controllers\ReflectionController;
use App\Http\Controllers\HistoryController;
use App\Http\Controllers\InsightController;
use App\Http\Controllers\SettingsController;
use App\Http\Controllers\Controller;
use Illuminate\Support\Facades\Route;

// Route::get('/', function () {
//     return view('welcome');
// });


Route::middleware(['auth'])->group(function () {
    Route::get('/dashboard', [DashboardController::class, 'index'])->name('dashboard');
    Route::get('/refleksi', [ReflectionController::class, 'index'])->name('refleksi');
    Route::get('/riwayat', [HistoryController::class, 'index'])->name('riwayat');
    Route::get('/insight', [InsightController::class, 'index'])->name('insight');
    Route::get('/pengaturan', [SettingsController::class, 'index'])->name('pengaturan');
    Route::post('/logout', function () {
        Auth::logout();
        return redirect('/login');
    })->name('logout');
});

Auth::routes();
Auth::routes();

Route::get('/home', [App\Http\Controllers\HomeController::class, 'index'])->name('home');
