@extends('layouts.app')

@section('title', 'Insight & Statistik')

@section('content')
<main class="flex-1 p-8 space-y-8">
    
    <section class="grid grid-cols-1 md:grid-cols-3 gap-6">
        <div class="glass p-6 rounded-2xl shadow-lg">
            <h3 class="text-lg font-semibold text-gray-400">Total Habit</h3>
            <p class="text-4xl font-bold text-lime-300 mt-2">{{ $totalHabits }}</p>
        </div>
        <div class="glass p-6 rounded-2xl shadow-lg">
            <h3 class="text-lg font-semibold text-gray-400">Total Refleksi</h3>
            <p class="text-4xl font-bold text-lime-300 mt-2">{{ $totalEntries }}</p>
        </div>
        <div class="glass p-6 rounded-2xl shadow-lg">
            <h3 class="text-lg font-semibold text-gray-400">Streak Saat Ini</h3>
            <p class="text-4xl font-bold text-lime-300 mt-2">{{ $currentStreak }} <span class="text-2xl">hari</span></p>
        </div>
    </section>

    <section class="grid grid-cols-1 lg:grid-cols-3 gap-8">
        <div class="lg:col-span-1 glass p-6 rounded-2xl shadow-lg">
            <h3 class="text-xl font-semibold text-gray-200 mb-4">Komposisi Habit</h3>
            <div id="categoryPieChart"></div>
        </div>

        <div class="lg:col-span-2 glass p-6 rounded-2xl shadow-lg">
            <h3 class="text-xl font-semibold text-gray-200 mb-4">Aktivitas Refleksi (30 Hari Terakhir)</h3>
            <div id="activityLineChart"></div>
        </div>
    </section>

</main>

@endsection

@push('scripts')
<script>
document.addEventListener('DOMContentLoaded', function () {
    const chartOptions = {
        chart: {
            background: 'transparent',
            toolbar: { show: false }
        },
        theme: {
            mode: 'dark',
            palette: 'palette1',
            monochrome: {
                enabled: false,
            }
        },
        stroke: {
            curve: 'smooth',
            width: 2
        },
        dataLabels: { enabled: false },
        legend: {
            labels: { colors: '#9ca3af' }
        }
    };

    var pieOptions = {
        ...chartOptions,
        series: {!! json_encode($categoryDistribution->values()) !!},
        chart: { ...chartOptions.chart, type: 'pie' },
        labels: {!! json_encode($categoryDistribution->keys()) !!},
        responsive: [{
            breakpoint: 480,
            options: {
                chart: { width: 200 },
                legend: { position: 'bottom' }
            }
        }]
    };
    var pieChart = new ApexCharts(document.querySelector("#categoryPieChart"), pieOptions);
    pieChart.render();
    var lineOptions = {
        ...chartOptions,
        series: [{
            name: "Refleksi",
            data: {!! json_encode($activityData) !!}
        }],
        chart: { ...chartOptions.chart, type: 'area' },
        xaxis: {
            categories: {!! json_encode($activityLabels) !!},
            labels: {
                style: { colors: '#9ca3af' }
            }
        },
        yaxis: {
            labels: {
                style: { colors: '#9ca3af' },
                formatter: function (val) { return val.toFixed(0); } 
            }
        },
        fill: {
            type: "gradient",
            gradient: {
                shadeIntensity: 1,
                opacityFrom: 0.7,
                opacityTo: 0.2,
                stops: [0, 90, 100]
            }
        },
    };
    var lineChart = new ApexCharts(document.querySelector("#activityLineChart"), lineOptions);
    lineChart.render();
});
</script>
@endpush