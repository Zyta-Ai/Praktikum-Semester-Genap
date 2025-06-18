using System;
using System.Drawing;
using System.Globalization;
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
        private DateTime tanggalSekarang;

        private void Dashboard_Load(object sender, EventArgs e)
        {
            tanggalSekarang = DateTime.Now;
            lHariIni.Text = tanggalSekarang.ToString("dddd, dd MMMM yyyy");
            TampilkanData("Minggu");

            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void TampilkanData(string rentangWaktu)
        {
            using (MySqlConnection conn = new MySqlConnection(koneksi))
            {
                conn.Open();
                string tanggalAwal, tanggalAkhir;
                if (rentangWaktu == "HariIni")
                {
                    tanggalAwal = tanggalSekarang.ToString("yyyy-MM-dd");
                    tanggalAkhir = tanggalAwal;
                }
                else if (rentangWaktu == "Minggu")
                {
                    tanggalAwal = tanggalSekarang.AddDays(-7).ToString("yyyy-MM-dd");
                    tanggalAkhir = tanggalSekarang.ToString("yyyy-MM-dd");
                }
                else if (rentangWaktu == "30Hari")
                {
                    tanggalAwal = tanggalSekarang.AddDays(-30).ToString("yyyy-MM-dd");
                    tanggalAkhir = tanggalSekarang.ToString("yyyy-MM-dd");
                }
                else
                {
                    tanggalAwal = new DateTime(tanggalSekarang.Year, tanggalSekarang.Month, 1).ToString("yyyy-MM-dd");
                    tanggalAkhir = tanggalSekarang.ToString("yyyy-MM-dd");
                }

                dateTimePicker1.Value = DateTime.Parse(tanggalAwal);
                dateTimePicker2.Value = DateTime.Parse(tanggalAkhir);

                string queryData = @"
                    SELECT 
                        (SELECT COUNT(*) FROM penjualan WHERE tanggalPenjualan BETWEEN @tanggalAwal AND @tanggalAkhir) AS totalPenjualan,
                        (SELECT SUM(detail_penjualan.subtotal) FROM detail_penjualan JOIN penjualan ON detail_penjualan.penjualan_id = penjualan.penjualan_id WHERE penjualan.tanggalPenjualan BETWEEN @tanggalAwal AND @tanggalAkhir) AS totalPendapatan,
                        (SELECT SUM(detail_penjualan.subtotal * 0.2) FROM detail_penjualan JOIN penjualan ON detail_penjualan.penjualan_id = penjualan.penjualan_id WHERE penjualan.tanggalPenjualan BETWEEN @tanggalAwal AND @tanggalAkhir) AS totalProfit,
                        (SELECT COUNT(*) FROM produk) AS totalProduk,
                        (SELECT COUNT(*) FROM pelanggan) AS totalPelanggan;";

                using (MySqlCommand command = new MySqlCommand(queryData, conn))
                {
                    command.Parameters.AddWithValue("@tanggalAwal", tanggalAwal);
                    command.Parameters.AddWithValue("@tanggalAkhir", tanggalAkhir);

                    using (MySqlDataReader hasil = command.ExecuteReader())
                    {
                        if (hasil.Read())
                        {
                            lTotalPenjualan.Text = hasil.GetInt64("totalPenjualan").ToString();
                            lTotalPendapatan.Text = hasil.IsDBNull(hasil.GetOrdinal("totalPendapatan")) ? "Rp 0" : hasil.GetInt64("totalPendapatan").ToString("C");
                            lTotalProfit.Text = hasil.IsDBNull(hasil.GetOrdinal("totalProfit")) ? "Rp 0" : hasil.GetInt64("totalProfit").ToString("C");
                            lTotalProduk.Text = hasil.GetInt32("totalProduk").ToString();
                            lTotalPelanggan.Text = hasil.GetInt32("totalPelanggan").ToString();
                        }
                    }
                }
                chart1.Series.Clear();
                var grafikPenjualan = chart1.Series.Add("Jumlah Penjualan");
                grafikPenjualan.ChartType = SeriesChartType.Column;

                DateTime startDate = DateTime.Parse(tanggalAwal);
                DateTime endDate = DateTime.Parse(tanggalAkhir);
                int selisihHari = (endDate - startDate).Days;

                MessageBox.Show(selisihHari.ToString());

                string queryGrafik;
                if (selisihHari <= 7)
                {
                    queryGrafik = @"
                        SELECT DATE(tanggalPenjualan) AS tanggal,
                               COUNT(*) AS total_penjualan
                        FROM penjualan
                        WHERE tanggalPenjualan BETWEEN @tanggalAwal AND @tanggalAkhir
                        GROUP BY DATE(tanggalPenjualan)
                        ORDER BY DATE(tanggalPenjualan);";
                }
                else if (selisihHari < 30)
                {
                    queryGrafik = @"
                        SELECT WEEK(tanggalPenjualan) AS minggu,
                               MIN(tanggalPenjualan) AS tanggal_minggu,
                               COUNT(*) AS total_penjualan
                        FROM penjualan
                        WHERE tanggalPenjualan BETWEEN @tanggalAwal AND @tanggalAkhir
                        GROUP BY WEEK(tanggalPenjualan)
                        ORDER BY MIN(tanggalPenjualan);";
                }
                else
                {
                    queryGrafik = @"
                        SELECT MONTH(tanggalPenjualan) AS bulan,
                               COUNT(*) AS total_penjualan
                        FROM penjualan
                        WHERE tanggalPenjualan BETWEEN @tanggalAwal AND @tanggalAkhir
                        GROUP BY MONTH(tanggalPenjualan)
                        ORDER BY MONTH(tanggalPenjualan);";
                }

                using (MySqlCommand cmdGrafik = new MySqlCommand(queryGrafik, conn))
                {
                    cmdGrafik.Parameters.AddWithValue("@tanggalAwal", tanggalAwal);
                    cmdGrafik.Parameters.AddWithValue("@tanggalAkhir", tanggalAkhir);

                    using (MySqlDataReader hasilGrafik = cmdGrafik.ExecuteReader())
                    {
                        if (!hasilGrafik.HasRows)
                        {
                            MessageBox.Show("Tidak ada data penjualan untuk periode ini.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string[] namaBulan = { "", "Jan", "Feb", "Mar", "Apr", "Mei", "Jun", "Jul", "Agu", "Sep", "Okt", "Nov", "Des" };
                            int nomorMinggu = 1;

                            while (hasilGrafik.Read())
                            {
                                decimal total = hasilGrafik.GetDecimal("total_penjualan");
                                string label;

                                if (selisihHari <= 7)
                                {
                                    DateTime tanggal = hasilGrafik.GetDateTime("tanggal");
                                    label = tanggal.ToString("dd-MMM");
                                }
                                else if (selisihHari < 30)
                                {
                                    DateTime tanggalMinggu = hasilGrafik.GetDateTime("tanggal_minggu");
                                    label = $"Minggu {nomorMinggu} ({tanggalMinggu:dd-MMM})";
                                    nomorMinggu++;
                                }
                                else
                                {
                                    int bulan = hasilGrafik.GetInt32("bulan");
                                    label = namaBulan[bulan];
                                }

                                grafikPenjualan.Points.AddXY(label, total);
                            }
                        }
                    }
                }

                chart2.Series.Clear();
                var grafikBarang = chart2.Series.Add("Jumlah Penjualan");
                grafikBarang.ChartType = SeriesChartType.Pie;

                string queryTop5Barang = @"
                SELECT produk.nama_produk, SUM(detail_penjualan.jumlah_produk) AS total_penjualan
                FROM detail_penjualan
                JOIN produk ON detail_penjualan.produk_id = produk.produk_id
                JOIN penjualan ON detail_penjualan.penjualan_id = penjualan.penjualan_id
                WHERE penjualan.tanggalPenjualan BETWEEN @tanggalAwal AND @tanggalAkhir
                GROUP BY produk.produk_id, produk.nama_produk
                ORDER BY total_penjualan DESC
                LIMIT 10;";

                using (MySqlCommand cmdBarang = new MySqlCommand(queryTop5Barang, conn))
                {
                    cmdBarang.Parameters.AddWithValue("@tanggalAwal", tanggalAwal);
                    cmdBarang.Parameters.AddWithValue("@tanggalAkhir", tanggalAkhir);

                    using (MySqlDataReader hasilBarang = cmdBarang.ExecuteReader())
                    {
                        if (!hasilBarang.HasRows)
                        {
                            MessageBox.Show("Tidak ada data penjualan untuk periode ini.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            while (hasilBarang.Read())
                            {
                                string namaProduk = hasilBarang.GetString("nama_produk");
                                double totalPenjualan = hasilBarang.IsDBNull(hasilBarang.GetOrdinal("total_penjualan")) ? 0 : hasilBarang.GetDouble("total_penjualan");
                                var point = grafikBarang.Points.Add(totalPenjualan);
                                point.LegendText = namaProduk;
                                point.Label = totalPenjualan.ToString("N0"); 
                            }
                        }
                    }
                }

                grafikBarang.IsValueShownAsLabel = true;
                grafikBarang.LabelForeColor = Color.Black; 
                grafikBarang.Font = new Font("Arial", 8, FontStyle.Regular); 
                grafikBarang["PieLabelStyle"] = "Inside";
                grafikBarang["LabelOutsideLineColor"] = "Transparent";
                chart2.Legends.Clear();
                var legend = chart2.Legends.Add("Produk");
                legend.Font = new Font("Arial", 8, FontStyle.Regular); 
                grafikBarang.Legend = "Produk";
            }
        }

        private void btnHariIni_Click(object sender, EventArgs e)
        {
            TampilkanData("HariIni");
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void btnMinggu_Click(object sender, EventArgs e)
        {
            TampilkanData("Minggu");
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void btn30Hari_Click(object sender, EventArgs e)
        {
            TampilkanData("30Hari");
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void btnBulanIni_Click(object sender, EventArgs e)
        {
            TampilkanData("BulanIni");
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void bCustom_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void bOke_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(koneksi))
            {
                conn.Open();
                string hasil_tanggalSebelum = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string hasil_tanggalSesudah = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                string queryData = @"
                    SELECT 
                    (SELECT COUNT(*) FROM penjualan WHERE tanggalPenjualan BETWEEN @tanggalAwal AND @tanggalAkhir) AS totalPenjualan,
                    (SELECT SUM(detail_penjualan.subtotal) FROM detail_penjualan JOIN penjualan ON detail_penjualan.penjualan_id = penjualan.penjualan_id WHERE penjualan.tanggalPenjualan BETWEEN @tanggalAwal AND @tanggalAkhir) AS totalPendapatan,
                    (SELECT SUM(detail_penjualan.subtotal * 0.2) FROM detail_penjualan JOIN penjualan ON detail_penjualan.penjualan_id = penjualan.penjualan_id WHERE penjualan.tanggalPenjualan BETWEEN @tanggalAwal AND @tanggalAkhir) AS totalProfit,
                    (SELECT COUNT(*) FROM produk) AS totalProduk,
                    (SELECT COUNT(*) FROM pelanggan) AS totalPelanggan;";

                using (MySqlCommand command = new MySqlCommand(queryData, conn))
                {
                    command.Parameters.AddWithValue("@tanggalAwal", hasil_tanggalSebelum);
                    command.Parameters.AddWithValue("@tanggalAkhir", hasil_tanggalSesudah);

                    using (MySqlDataReader hasil = command.ExecuteReader())
                    {
                        if (hasil.Read())
                        {
                            lTotalPenjualan.Text = hasil.GetInt64("totalPenjualan").ToString();
                            lTotalPendapatan.Text = hasil.IsDBNull(hasil.GetOrdinal("totalPendapatan")) ? "Rp 0" : hasil.GetInt64("totalPendapatan").ToString("C");
                            lTotalProfit.Text = hasil.IsDBNull(hasil.GetOrdinal("totalProfit")) ? "Rp 0" : hasil.GetInt64("totalProfit").ToString("C");
                            lTotalProduk.Text = hasil.GetInt32("totalProduk").ToString();
                            lTotalPelanggan.Text = hasil.GetInt32("totalPelanggan").ToString();
                        }
                    }
                }

                chart1.Series.Clear();
                var grafikPenjualan = chart1.Series.Add("Jumlah Penjualan");
                grafikPenjualan.ChartType = SeriesChartType.Column;

                DateTime startDate = DateTime.Parse(hasil_tanggalSebelum);
                DateTime endDate = DateTime.Parse(hasil_tanggalSesudah);
                int selisihHari = (endDate - startDate).Days + 1;

                string queryGrafik;
                if (selisihHari < 7)
                {
                    queryGrafik = @"
                        SELECT DATE(tanggalPenjualan) AS tanggal,
                               COUNT(*) AS total_penjualan
                        FROM penjualan
                        WHERE tanggalPenjualan BETWEEN @tanggalAwal AND @tanggalAkhir
                        GROUP BY DATE(tanggalPenjualan)
                        ORDER BY DATE(tanggalPenjualan);";
                }
                else if (selisihHari < 30)
                {
                    queryGrafik = @"
                        SELECT WEEK(tanggalPenjualan) AS minggu,
                               MIN(tanggalPenjualan) AS tanggal_minggu,
                               COUNT(*) AS total_penjualan
                        FROM penjualan
                        WHERE tanggalPenjualan BETWEEN @tanggalAwal AND @tanggalAkhir
                        GROUP BY WEEK(tanggalPenjualan)
                        ORDER BY MIN(tanggalPenjualan);";
                }
                else
                {
                    queryGrafik = @"
                        SELECT MONTH(tanggalPenjualan) AS bulan,
                               COUNT(*) AS total_penjualan
                        FROM penjualan
                        WHERE tanggalPenjualan BETWEEN @tanggalAwal AND @tanggalAkhir
                        GROUP BY MONTH(tanggalPenjualan)
                        ORDER BY MONTH(tanggalPenjualan);";
                }

                using (MySqlCommand cmdGrafik = new MySqlCommand(queryGrafik, conn))
                {
                    cmdGrafik.Parameters.AddWithValue("@tanggalAwal", hasil_tanggalSebelum);
                    cmdGrafik.Parameters.AddWithValue("@tanggalAkhir", hasil_tanggalSesudah);

                    using (MySqlDataReader hasilGrafik = cmdGrafik.ExecuteReader())
                    {
                        if (!hasilGrafik.HasRows)
                        {
                           
                        }
                        else
                        {
                            string[] namaBulan = { "", "Jan", "Feb", "Mar", "Apr", "Mei", "Jun", "Jul", "Agu", "Sep", "Okt", "Nov", "Des" };
                            int nomorMinggu = 1;

                            while (hasilGrafik.Read())
                            {
                                decimal total = hasilGrafik.GetDecimal("total_penjualan");
                                string label;

                                if (selisihHari < 7)
                                {
                                    DateTime tanggal = hasilGrafik.GetDateTime("tanggal");
                                    label = tanggal.ToString("dd-MMM");
                                }
                                else if (selisihHari < 30)
                                {
                                    DateTime tanggalMinggu = hasilGrafik.GetDateTime("tanggal_minggu");
                                    label = $"Minggu {nomorMinggu} ({tanggalMinggu:dd-MMM})";
                                    nomorMinggu++;
                                }
                                else
                                {
                                    int bulan = hasilGrafik.GetInt32("bulan");
                                    label = namaBulan[bulan];
                                }

                                grafikPenjualan.Points.AddXY(label, total);
                            }
                        }
                    }
                }

                chart2.Series.Clear();
                var grafikBarang = chart2.Series.Add("Jumlah Penjualan");
                grafikBarang.ChartType = SeriesChartType.Pie;

                string queryTop5Barang = @"
                SELECT produk.nama_produk, SUM(detail_penjualan.jumlah_produk) AS total_penjualan
                FROM detail_penjualan
                JOIN produk ON detail_penjualan.produk_id = produk.produk_id
                JOIN penjualan ON detail_penjualan.penjualan_id = penjualan.penjualan_id
                WHERE penjualan.tanggalPenjualan BETWEEN @tanggalAwal AND @tanggalAkhir
                GROUP BY produk.produk_id, produk.nama_produk
                ORDER BY total_penjualan DESC
                LIMIT 10;";

                using (MySqlCommand cmdBarang = new MySqlCommand(queryTop5Barang, conn))
                {
                    cmdBarang.Parameters.AddWithValue("@tanggalAwal", hasil_tanggalSebelum);
                    cmdBarang.Parameters.AddWithValue("@tanggalAkhir", hasil_tanggalSesudah);

                    using (MySqlDataReader hasilBarang = cmdBarang.ExecuteReader())
                    {
                        if (!hasilBarang.HasRows)
                        {
                            MessageBox.Show("Tidak ada data penjualan untuk periode ini.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            while (hasilBarang.Read())
                            {
                                string namaProduk = hasilBarang.GetString("nama_produk");
                                double totalPenjualan = hasilBarang.IsDBNull(hasilBarang.GetOrdinal("total_penjualan")) ? 0 : hasilBarang.GetDouble("total_penjualan");
                                var point = grafikBarang.Points.Add(totalPenjualan);
                                point.LegendText = namaProduk;
                                point.Label = totalPenjualan.ToString("N0");
                            }
                        }
                    }

                    grafikBarang.IsValueShownAsLabel = true;
                    grafikBarang.LabelForeColor = Color.Black;
                    grafikBarang.Font = new Font("Arial", 8, FontStyle.Regular);
                    grafikBarang["PieLabelStyle"] = "Inside";
                    grafikBarang["LabelOutsideLineColor"] = "Transparent";
                    chart2.Legends.Clear();
                    var legend = chart2.Legends.Add("Produk");
                    legend.Font = new Font("Arial", 8, FontStyle.Regular);
                    grafikBarang.Legend = "Produk";
                }
            }
        }
    }
}