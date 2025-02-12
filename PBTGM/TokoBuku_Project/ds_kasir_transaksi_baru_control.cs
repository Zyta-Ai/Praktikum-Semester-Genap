using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoBuku_Project
{
    public partial class ds_kasir_transaksi_baru_control : UserControl
    {
        private string connectionString = "server=localhost;user=root;database=db_tokobuku;port=3306;";
        private string ProdukId;
        private readonly CultureInfo indonesianCulture = new CultureInfo("id-ID");

        private TextBox tbIdTransaki;
        private DataTable detailTransaksi;
        private string tanggalTransaksi;
        private decimal totalHarga;
        private decimal pembayaran;
        private decimal kembalian;


        public ds_kasir_transaksi_baru_control()
        {
            InitializeComponent();
        }

        private void ds_kasir_transaksi_baru_control_Load(object sender, EventArgs e)
        {
            tabel_transaksi.AllowUserToAddRows = false;

            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Termal 1", 850, 1000);
            printDocument1.DefaultPageSettings.Margins = new Margins(30,30,30,30);

            if (tabel_transaksi.Columns["Subtotal"] != null)
            {
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.Name = "Hapus";
                btnHapus.HeaderText = "Hapus";
                btnHapus.Text = "X";
                btnHapus.UseColumnTextForButtonValue = true;
                btnHapus.Width = 15;
                tabel_transaksi.Columns.Add(btnHapus);
            }

            tabel_transaksi.CellClick += Tabel_transaksi_CellClick;
        }

        private void Tabel_transaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && tabel_transaksi.Columns[e.ColumnIndex].Name == "Hapus" && e.RowIndex >= 0)
            {
                tabel_transaksi.Rows.RemoveAt(e.RowIndex);
                HitungTotalBayar(); 
            }
        }

        private void SimpanTransaksi(decimal totalHarga, decimal pembayaran, decimal kembalian)
        {
            int idTransaksi = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(
                        "INSERT INTO transactions (tanggal, total_harga, id_user) VALUES (NOW(), @totalHarga, @idUser)", conn))
                    {
                        cmd.Parameters.AddWithValue("@totalHarga", totalHarga);
                        cmd.Parameters.AddWithValue("@idUser", 1);
                        cmd.ExecuteNonQuery();

                        idTransaksi = (int)cmd.LastInsertedId;

                        foreach (DataGridViewRow row in tabel_transaksi.Rows)
                        {
                            if (row.Cells[4].Value != null &&
                                decimal.TryParse(row.Cells[4].Value.ToString(), NumberStyles.Currency, indonesianCulture, out decimal subtotal))
                            {
                                string detailQuery = @"INSERT INTO transaction_details 
                                    (id_transaksi, id_buku, jumlah, subtotal)
                                    VALUES (@idTransaksi, @idBuku, @jumlah, @subtotal)";

                                using (MySqlCommand detailCmd = new MySqlCommand(detailQuery, conn))
                                {
                                    detailCmd.Parameters.AddWithValue("@idTransaksi", idTransaksi);
                                    detailCmd.Parameters.AddWithValue("@idBuku", row.Cells[0].Value.ToString());
                                    detailCmd.Parameters.AddWithValue("@jumlah", Convert.ToInt32(row.Cells[3].Value));
                                    detailCmd.Parameters.AddWithValue("@subtotal", subtotal);
                                    detailCmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    PrintStruk(
                    totalHarga: totalHarga,
                    pembayaran: pembayaran,
                    kembalian: kembalian
                    );

                    tabel_transaksi.Rows.Clear();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        private void HitungKembalian()
        {
            string totalBayarText = tbTotalBayar.Text.Replace("Rp", "").Trim();
            string pembayaranText = tbPembayaran.Text.Replace("Rp", "").Trim();

            if (decimal.TryParse(totalBayarText, NumberStyles.Currency, indonesianCulture, out decimal totalBayar) &&
                decimal.TryParse(pembayaranText, NumberStyles.Currency, indonesianCulture, out decimal pembayaran))
            {
                decimal kembalian = pembayaran - totalBayar;
                tbKembalian.Text = kembalian.ToString("C0", indonesianCulture);
            }
            else
            {
                tbKembalian.Text = "Rp 0";
            }
        }

        private void HitungTotalBayar()
        {
            decimal totalBayar = 0;

            foreach (DataGridViewRow row in tabel_transaksi.Rows)
            {
                if (row.Cells[4].Value != null &&
                    decimal.TryParse(row.Cells[4].Value.ToString(), NumberStyles.Currency, indonesianCulture, out decimal subtotal))
                {
                    totalBayar += subtotal;
                }
            }

            tbTotalBayar.Text = totalBayar.ToString("C0", indonesianCulture);
        }

        private void PrintStruk(decimal totalHarga, decimal pembayaran, decimal kembalian)
        {


            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Buat data struk langsung dari DataGridView
                    DataTable dataStruk = new DataTable();
                    dataStruk.Columns.Add("Nama Produk");
                    dataStruk.Columns.Add("Qty");
                    dataStruk.Columns.Add("Subtotal");

                    foreach (DataGridViewRow row in tabel_transaksi.Rows)
                    {
                        if (row.Cells[4].Value != null)
                        {
                            DataRow newRow = dataStruk.NewRow();
                            newRow["Nama Produk"] = row.Cells[1].Value.ToString();
                            newRow["Qty"] = row.Cells[3].Value.ToString();
                            newRow["Subtotal"] = Convert.ToDecimal(row.Cells[4].Value).ToString("C0", indonesianCulture);
                            dataStruk.Rows.Add(newRow);
                        }
                    }

                    printPreviewDialog1.Document = printDocument1;
                    this.detailTransaksi = dataStruk;
                    this.tanggalTransaksi = DateTime.Now.ToString("dddd, dd MMMM yyyy - H:mm:ss");
                    this.totalHarga = totalHarga;
                    this.pembayaran = pembayaran;
                    this.kembalian = kembalian;

                    printPreviewDialog1 = new PrintPreviewDialog(); 
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();

                    tbTotalBayar.Text = "Rp 0";
                    tbPembayaran.Text = "Rp 0";
                    tbKembalian.Text = "Rp 0";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal mencetak struk: " + ex.Message);
                }
            }
        }


        private void bTambahT_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(tbHargaBuku.Text, NumberStyles.Currency, indonesianCulture, out decimal hargaBuku) ||
                !int.TryParse(tbJumlahBuku.Text, out int jumlahBuku))
            {
                MessageBox.Show("Input harga atau jumlah tidak valid!");
                return;
            }

            decimal subtotal = hargaBuku * jumlahBuku;

            tabel_transaksi.Rows.Add(
                ProdukId, tbNamaBuku.Text, hargaBuku, jumlahBuku, subtotal   
            );

            tbNamaBuku.Clear();
            tbHargaBuku.Text = "Rp 0";
            tbSubtotal.Text = "Rp 0";
            tbJumlahBuku.Clear();
            HitungTotalBayar();
        }

        private void bCariProduk_Click(object sender, EventArgs e)
        {
            using (DataBuku_Tabel formPopUp = new DataBuku_Tabel())
            {
                if (formPopUp.ShowDialog() == DialogResult.OK)
                {
                    ProdukId = formPopUp.ProdukId;
                    tbNamaBuku.Text = formPopUp.ProdukNama;

                    if (decimal.TryParse(formPopUp.ProdukHarga, out decimal harga))
                    {
                        tbHargaBuku.Text = harga.ToString("C0", indonesianCulture);
                    }
                }
            }
        }

        private void tbJumlahBuku_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(tbHargaBuku.Text, NumberStyles.Currency, indonesianCulture, out decimal harga) &&
                int.TryParse(tbJumlahBuku.Text, out int jumlah))
            {
                decimal subtotal = harga * jumlah;
                tbSubtotal.Text = subtotal.ToString("C0", indonesianCulture);
            }
        }

        private void tbPembayaran_TextChanged(object sender, EventArgs e)
        {
            HitungKembalian();
        }

        private void bSelesaiT_Click(object sender, EventArgs e)
        {
            if (tabel_transaksi.Rows.Count == 0)
            {
                MessageBox.Show("Belum ada item dalam transaksi!");
                return;
            }

            // Hitung total harga
            decimal totalHarga = 0;
            foreach (DataGridViewRow row in tabel_transaksi.Rows)
            {
                if (row.Cells[4].Value != null &&
                    decimal.TryParse(row.Cells[4].Value.ToString(), NumberStyles.Currency, indonesianCulture, out decimal subtotal))
                {
                    totalHarga += subtotal;
                }
            }

            // Ambil nilai pembayaran dan kembalian dari textbox
            string pembayaranText = tbPembayaran.Text.Replace("Rp", "").Trim();
            string kembalianText = tbKembalian.Text.Replace("Rp", "").Trim();

            if (!decimal.TryParse(pembayaranText, NumberStyles.Currency, indonesianCulture, out decimal pembayaran) ||
                !decimal.TryParse(kembalianText, NumberStyles.Currency, indonesianCulture, out decimal kembalian))
            {
                MessageBox.Show("Input pembayaran atau kembalian tidak valid!");
                return;
            }

            // Simpan transaksi dan cetak struk
            SimpanTransaksi(totalHarga, pembayaran, kembalian);
        }


        private void bHapus_Click(object sender, EventArgs e)
        {
            tbSubtotal.Text = "Rp 0";
            tbNamaBuku.Clear();
            tbHargaBuku.Text = "Rp 0";
            tbJumlahBuku.Text = "";
        }

        private void tbBatalkan_Click(object sender, EventArgs e)
        {
            tbTotalBayar.Text = "Rp 0";
            tbKembalian.Text = "Rp 0";
            cbDiskon.SelectedItem = null;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            float yPos = 50; // Koordinat vertikal awal
            int offset = 30; // Jarak antar baris
            Font fontJudul = new Font("Arial", 16, FontStyle.Bold); // Judul lebih besar
            Font fontIsi = new Font("Arial", 12); // Font isi
            Font fontTerimaKasih = new Font("Arial", 10, FontStyle.Italic);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Lebar kolom
            float col1X = 50; // Kolom Nama Barang
            float col2X = 550; // Kolom Qty
            float col3X = 670; // Kolom Subtotal

            // Header Toko (Tengah Halaman)
            string judul = "DuniaBuku Store";
            string alamat = "Jl. Raya Purwakarta, Jawa Barat";
            string noTelp = "Telp: 0812-3445-5543";

            // Menghitung posisi tengah halaman untuk judul
            SizeF judulSize = e.Graphics.MeasureString(judul, fontJudul);
            float centerX = (e.PageBounds.Width - judulSize.Width) / 2;

            e.Graphics.DrawString(judul, fontJudul, brush, centerX, yPos);
            yPos += offset * 2; // Spasi lebih besar setelah judul

            SizeF alamatSize = e.Graphics.MeasureString(alamat, fontIsi);
            float centerXAlamat = (e.PageBounds.Width - alamatSize.Width) / 2;
            e.Graphics.DrawString(alamat, fontIsi, brush, centerXAlamat, yPos);
            yPos += offset;

            SizeF noTelpSize = e.Graphics.MeasureString(noTelp, fontIsi);
            float centerXNoTelp = (e.PageBounds.Width - noTelpSize.Width) / 2;
            e.Graphics.DrawString(noTelp, fontIsi, brush, centerXNoTelp, yPos);
            yPos += offset;

            // Garis pemisah header
            e.Graphics.DrawString(new string('-', 133), fontIsi, brush, col1X, yPos);
            yPos += offset;

            // Tanggal Transaksi (Tengah Halaman)
            string tanggal = "Tanggal : " + tanggalTransaksi;
            SizeF tanggalSize = e.Graphics.MeasureString(tanggal, fontIsi);
            float centerXTanggal = (e.PageBounds.Width - tanggalSize.Width) / 2;
            e.Graphics.DrawString(tanggal, fontIsi, brush, centerXTanggal, yPos);
            yPos += offset;

            // Garis pemisah sebelum detail transaksi
            e.Graphics.DrawString(new string('=', 76), fontIsi, brush, col1X, yPos);
            yPos += offset;

            // Header tabel
            string headerNamaBarang = "Nama Buku";
            string headerQty = "Jumlah";
            string headerSubtotal = "Subtotal";

            e.Graphics.DrawString(headerNamaBarang, fontIsi, brush, col1X, yPos);
            e.Graphics.DrawString(headerQty, fontIsi, brush, col2X, yPos);
            e.Graphics.DrawString(headerSubtotal, fontIsi, brush, col3X, yPos);
            yPos += offset;

            // Garis pemisah header tabel
            e.Graphics.DrawString(new string('=', 76), fontIsi, brush, col1X, yPos);
            yPos += offset;

            // Data produk dari detailTransaksi
            foreach (DataRow row in detailTransaksi.Rows)
            {
                string namaProduk = row["Nama Produk"].ToString();
                string jumlah = row["Qty"].ToString();
                string subtotal = row["Subtotal"].ToString();

                e.Graphics.DrawString(namaProduk, fontIsi, brush, col1X, yPos);
                e.Graphics.DrawString(jumlah, fontIsi, brush, col2X, yPos);
                e.Graphics.DrawString(subtotal, fontIsi, brush, col3X, yPos);
                yPos += offset;
            }

            // Garis pemisah setelah detail transaksi
            e.Graphics.DrawString(new string('-', 133), fontIsi, brush, col1X, yPos);
            yPos += offset;

            // Total, Pembayaran, dan Kembalian
            string totalLabel = "Total";
            string pembayaranLabel = "Pembayaran";
            string kembalianLabel = "Kembali";

            e.Graphics.DrawString(totalLabel, fontIsi, brush, col1X, yPos);
            e.Graphics.DrawString("Rp " + totalHarga.ToString("N0", indonesianCulture), fontIsi, brush, col3X, yPos);
            yPos += offset;

            e.Graphics.DrawString(pembayaranLabel, fontIsi, brush, col1X, yPos);
            e.Graphics.DrawString("Rp " + pembayaran.ToString("N0", indonesianCulture), fontIsi, brush, col3X, yPos);
            yPos += offset;

            e.Graphics.DrawString(kembalianLabel, fontIsi, brush, col1X, yPos);
            e.Graphics.DrawString("Rp " + kembalian.ToString("N0", indonesianCulture), fontIsi, brush, col3X, yPos);
            yPos += offset;

            // Garis pemisah akhir
            e.Graphics.DrawString(new string('-', 133), fontIsi, brush, col1X, yPos);
            yPos += offset;

            // Pesan terima kasih (Tengah Halaman)
            string pesanTerimaKasih = "Terima kasih telah berbelanja!";
            SizeF pesanSize = e.Graphics.MeasureString(pesanTerimaKasih, fontTerimaKasih);
            float centerXPesan = (e.PageBounds.Width - pesanSize.Width) / 2;
            e.Graphics.DrawString(pesanTerimaKasih, fontTerimaKasih, brush, centerXPesan, yPos);
        }
    }
}   