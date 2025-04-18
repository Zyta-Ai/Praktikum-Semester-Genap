using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace TokoSebelah_Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        string koneksi = "server=localhost;database=db_toko_sebelah;user=root;password='';";
        private DateTime tanggalSebelum;
        private DateTime tanggalSesudah;
        private DateTime tanggalSekarang;

        private void Dashboard_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(koneksi);
            conn.Open();
            tanggalSekarang = DateTime.Now;
            lHariIni.Text = tanggalSekarang.ToString("dddd, dd MMMM yyyy");

            tanggalSebelum = dateTimePicker1.Value;
            tanggalSesudah = dateTimePicker2.Value;
            string hasil_tanggalSebelum = tanggalSebelum.ToString("yyyy-MM-dd");
            string hasil_tanggalSesudah = tanggalSesudah.ToString("yyyy-MM-dd");

            string query_jumlahPenjualan = "SELECT COUNT(*) FROM penjualan WHERE tanggalPenjualan BETWEEN DATE_SUB(@tanggalSebelum, INTERVAL 7 DAY) AND @tanggalSesudah;";
            string query_jumlahPendapatan = "SELECT SUM(detail_penjualan.subtotal) FROM detail_penjualan\r\nJOIN penjualan\r\nON detail_penjualan.penjualan_id = penjualan.penjualan_id\r\nWHERE penjualan.tanggalPenjualan BETWEEN DATE_SUB(@tanggalSebelum, INTERVAL 7 DAY) AND @tanggalSesudah;";
            string query_jumlahProfit = "SELECT SUM(detail_penjualan.subtotal * 20/100) FROM detail_penjualan\r\nJOIN penjualan\r\nON detail_penjualan.penjualan_id = penjualan.penjualan_id\r\nWHERE penjualan.tanggalPenjualan BETWEEN DATE_SUB(@tanggalSebelum, INTERVAL 7 DAY) AND @tanggalSesudah";
            string query_totalProduk = "SELECT COUNT(*) FROM produk";
            string query_totalPelanggan = "SELECT COUNT(*) FROM pelanggan";

            using (MySqlCommand cmd = new MySqlCommand(query_jumlahPenjualan, conn))
            {
                cmd.Parameters.AddWithValue("tanggalSebelum", hasil_tanggalSebelum);
                cmd.Parameters.AddWithValue("tanggalSesudah", hasil_tanggalSesudah);

                using (MySqlDataReader hasil = cmd.ExecuteReader())
                {
                    if (hasil.Read())
                    {
                        string total_penjualan = Convert.ToString(hasil.GetInt64(0));
                        lTotalPenjualan.Text = total_penjualan;
                    }

                }
            }

            using (MySqlCommand command = new MySqlCommand(query_jumlahProfit, conn))
            {
                command.Parameters.AddWithValue("tanggalSebelum", hasil_tanggalSebelum);
                command.Parameters.AddWithValue("tanggalSesudah", hasil_tanggalSesudah);
                using (MySqlDataReader hasil_pendapatan = command.ExecuteReader())
                {
                    if (hasil_pendapatan.Read())
                    {
                        long pendapatan = hasil_pendapatan.GetInt64(0);
                        CultureInfo culture = new CultureInfo("id-ID");
                        string total_pendapatan = pendapatan.ToString("C", culture);
                        lTotalProfit.Text = total_pendapatan;
                    }
                }
            }


            using (MySqlCommand command = new MySqlCommand(query_jumlahPendapatan, conn))
            {
                command.Parameters.AddWithValue("tanggalSebelum", hasil_tanggalSebelum);
                command.Parameters.AddWithValue("tanggalSesudah", hasil_tanggalSesudah);
                using (MySqlDataReader hasil_pendapatan = command.ExecuteReader())
                {
                    if (hasil_pendapatan.Read())
                    {
                        long pendapatan = hasil_pendapatan.GetInt64(0);
                        CultureInfo culture = new CultureInfo("id-ID");
                        string total_pendapatan = pendapatan.ToString("C", culture);
                        lTotalPendapatan.Text = total_pendapatan;
                    }
                }
            }

            using (MySqlCommand cmd_pelanggan = new MySqlCommand(query_totalPelanggan, conn))
            {
                using (MySqlDataReader hasil_pelanggan = cmd_pelanggan.ExecuteReader())
                {
                    if (hasil_pelanggan.Read())
                    {
                        lTotalPelanggan.Text = hasil_pelanggan.GetInt32(0).ToString();
                    }
                }
            }

            using (MySqlCommand cmd_produk = new MySqlCommand(query_totalProduk, conn))
            {
                using (MySqlDataReader hasil_produk = cmd_produk.ExecuteReader())
                {
                    if (hasil_produk.Read())
                    {
                        lTotalProduk.Text = hasil_produk.GetInt32(0).ToString();
                    }
                }
            }

            // Bagian Data Chart
            chart1.Series[0].Points.Clear();
            chart1.Series.Add("Jumlah Penjualan");
            chart1.Series[0].ChartType = SeriesChartType.Column;

            string query_dataChart = "SELECT MONTH(tanggalPenjualan) AS bulan, COUNT(*) AS total_penjualan FROM penjualan WHERE tanggalPenjualan GROUP BY MONTH(tanggalPenjualan) ORDER BY MONTH(tanggalPenjualan);";

            string[] namaBulan = { "", "Jan", "Feb", "Mar", "Apr", "Mei", "Jun", "Jul", "Agu", "Sep", "Okt", "Nov", "Des" };

            using (MySqlCommand cmd_dataChart = new MySqlCommand(query_dataChart, conn))
            {
                using (MySqlDataReader hasil_dataChart = cmd_dataChart.ExecuteReader())
                {
                    while (hasil_dataChart.Read())
                    {
                        int bulan = hasil_dataChart.GetInt32("bulan");
                        decimal total = hasil_dataChart.GetDecimal("total_penjualan");

                        chart1.Series[0].Points.AddXY(namaBulan[bulan], total);
                    }
                }
            }
        }

    }
}
