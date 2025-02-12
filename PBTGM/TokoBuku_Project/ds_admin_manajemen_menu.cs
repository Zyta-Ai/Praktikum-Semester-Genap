using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TokoBuku_Project
{
    public partial class ds_admin_manajemen_menu : Form
    {
        private string connectionString = "server=localhost;user=root;database=db_tokobuku;port=3306;";

        private int halamanSaatIni = 1; 
        private int jumlahDataPerHalaman = 10;
        private int totalHalaman = 0;


        public ds_admin_manajemen_menu()
        {
            InitializeComponent();
        }

        private void ds_admin_manajemen_menu_Load(object sender, EventArgs e)
        {
            CountTotalPage();
            LoadDataPelanggan(halamanSaatIni);
            data_buku.AllowUserToAddRows = false;
        }
        private void CountTotalPage()
        {
            int totalData = GetTotalRecords();

            using (MySqlConnection koneksi = new MySqlConnection(connectionString))
            {
                try
                {
                    koneksi.Open();
                    string queryHitung = "SELECT COUNT(*) FROM books";
                    using (MySqlCommand perintah = new MySqlCommand(queryHitung, koneksi))
                    {
                        totalData = Convert.ToInt32(perintah.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan saat menghitung total data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            totalHalaman = (int)Math.Ceiling((double)totalData / jumlahDataPerHalaman);
        }

        private int GetTotalRecords()
        {
            int totalRecords = 0;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM books"; // Menghitung total data
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        totalRecords = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return totalRecords;
        }


        private void LoadDataPelanggan(int halaman) { 
            data_buku.Rows.Clear();
            int offset = (halaman - 1) * jumlahDataPerHalaman;

            using (MySqlConnection  conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    //Mengambil Data Buku
                    string query = "SELECT id_buku, kode_buku, judul, pengarang, penerbit, harga, stok FROM books LIMIT @batas OFFSET @mulai";

                    using(MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@batas", jumlahDataPerHalaman);
                        cmd.Parameters.AddWithValue("@mulai", offset);


                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string id = reader["id_buku"].ToString();
                                string kode = reader["kode_buku"].ToString();
                                string judul = reader["judul"].ToString();
                                string pengarang = reader["pengarang"].ToString();
                                string penerbit = reader["penerbit"].ToString();
                                string harga = reader["harga"].ToString();
                                string stok = reader["stok"].ToString();

                                data_buku.Rows.Add(id, kode, judul, pengarang,penerbit, harga, stok);
                            }
                        }
                    }

                    lblHalaman.Text = $"Halaman {halamanSaatIni} dari {totalHalaman}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bSimpan_Click(object sender, EventArgs e)
        {
            
        }


        private void bHapus_Click(object sender, EventArgs e)
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "DELETE FROM books WHERE id_buku = @id_buku";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_buku", tbIdBuku.Text);

                        int baris = cmd.ExecuteNonQuery();

                        if (baris > 0)
                        {
                            MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataPelanggan(halamanSaatIni);
                        }
                        else
                        {
                            MessageBox.Show("ID Buku tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        private void bPerbaharui_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE books SET id_buku = @id_buku, kode_buku = @kode_buku, judul = @judul, pengarang = @pengarang, penerbit = @penerbit, harga = @harga, stok = @stok WHERE id_buku = @id_buku;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_buku", tbIdBuku.Text);
                        cmd.Parameters.AddWithValue("@kode_buku", tbKodeBuku.Text);
                        cmd.Parameters.AddWithValue("@judul", tbJudul.Text);
                        cmd.Parameters.AddWithValue("@pengarang", tbPengarang.Text);
                        cmd.Parameters.AddWithValue("@penerbit", tbPenerbit.Text);
                        cmd.Parameters.AddWithValue("@harga", tbHarga.Text);
                        cmd.Parameters.AddWithValue("@stok", tbStok.Text);

                        int baris = cmd.ExecuteNonQuery();

                        if (baris > 0)
                        {
                            MessageBox.Show("Data berhasil diupdate.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataPelanggan(halamanSaatIni);
                        }
                        else
                        {
                            MessageBox.Show("ID Pelanggan tidak ditemukan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            LoadDataPelanggan(halamanSaatIni);
        }

        private void bCari_Click(object sender, EventArgs e)
        {
            string keyword = tbCari.Text;
            data_buku.Rows.Clear();

            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id_buku, kode_buku, judul, pengarang, penerbit, harga, stok " +
                      "FROM books WHERE id_buku LIKE @keyword OR kode_buku LIKE @keyword " +
                        "OR judul LIKE @keyword OR pengarang LIKE @keyword " +
                        "OR penerbit LIKE @keyword OR harga LIKE @keyword OR stok LIKE @keyword";


                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        using(MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string id = reader["id_buku"].ToString();
                                string kode = reader["kode_buku"].ToString();
                                string judul = reader["judul"].ToString();
                                string pengarang = reader["pengarang"].ToString();
                                string penerbit = reader["penerbit"].ToString();
                                string harga = reader["harga"].ToString();
                                string stok = reader["stok"].ToString();

                                data_buku.Rows.Add(id, kode, judul, pengarang, penerbit, harga, stok);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        private void data_buku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tbIdBuku.Text = data_buku.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbKodeBuku.Text = data_buku.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbJudul.Text = data_buku.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbPengarang.Text = data_buku.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbPenerbit.Text = data_buku.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbHarga.Text = data_buku.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbStok.Text = data_buku.Rows[e.RowIndex].Cells[6].Value.ToString();

                bPerbaharui.Enabled = true;
                bHapus.Enabled = true;
            }
        }

        private void bSimpan_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            int totalData = GetTotalRecords();
            int maxPage = (int)Math.Ceiling((double)totalData / jumlahDataPerHalaman);

            if(halamanSaatIni < maxPage)
            {
                halamanSaatIni++;
                LoadDataPelanggan(halamanSaatIni);
    
            }
            else
            {
                MessageBox.Show("Tidak ada data, anda sudah di halaman paling akhir.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
  
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            int totalData = GetTotalRecords();
            int maxPage = (int)Math.Ceiling((double)totalData / jumlahDataPerHalaman);

            if (halamanSaatIni > 1)
            {
                halamanSaatIni--;
                LoadDataPelanggan(halamanSaatIni);

            }
            else
            {
                MessageBox.Show("Tidak ada data, anda sudah di halaman pertama.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
  
            }
        }

        private void bSimpan_Click_1(object sender, EventArgs e)
        {

        }

        private void data_buku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bSimpan_Click_2(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                if (string.IsNullOrEmpty(tbIdBuku.Text) || string.IsNullOrEmpty(tbKodeBuku.Text) ||
                    string.IsNullOrEmpty(tbJudul.Text) || string.IsNullOrEmpty(tbPengarang.Text) ||
                    string.IsNullOrEmpty(tbPenerbit.Text) || string.IsNullOrEmpty(tbHarga.Text) ||
                    string.IsNullOrEmpty(tbStok.Text))
                {
                    MessageBox.Show("Error! Jangan ada yang kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(tbHarga.Text, out decimal harga) || harga <= 0)
                {
                    MessageBox.Show("Harga harus berupa angka positif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(tbStok.Text, out int stok) || stok < 0)
                {
                    MessageBox.Show("Stok harus berupa angka non-negatif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (MySqlConnection connect = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        string checkQuery = "SELECT COUNT(*) FROM books WHERE id_buku = @id_buku";
                        using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@id_buku", tbIdBuku.Text);
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                            if (count > 0)
                            {
                                MessageBox.Show("ID Buku sudah ada. Gunakan ID yang berbeda.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        string query = "INSERT INTO books (id_buku, kode_buku, judul, pengarang, penerbit, harga, stok) " +
                                       "VALUES (@id_buku, @kode_buku, @judul, @pengarang, @penerbit, @harga, @stok);";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@id_buku", tbIdBuku.Text);
                            cmd.Parameters.AddWithValue("@kode_buku", tbKodeBuku.Text);
                            cmd.Parameters.AddWithValue("@judul", tbJudul.Text);
                            cmd.Parameters.AddWithValue("@pengarang", tbPengarang.Text);
                            cmd.Parameters.AddWithValue("@penerbit", tbPenerbit.Text);
                            cmd.Parameters.AddWithValue("@harga", harga);
                            cmd.Parameters.AddWithValue("@stok", stok);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);


                            tbIdBuku.Clear();
                            tbKodeBuku.Clear();
                            tbJudul.Clear();
                            tbPengarang.Clear();
                            tbPenerbit.Clear();
                            tbHarga.Clear();
                            tbStok.Clear();

                            LoadDataPelanggan(halamanSaatIni);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
