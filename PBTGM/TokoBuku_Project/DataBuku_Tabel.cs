using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoBuku_Project
{
    public partial class DataBuku_Tabel : Form
    {
        private string connectionString = "server=localhost;user=root;database=db_tokobuku;port=3306;";

        public string ProdukNama { get; set; }
        public string ProdukHarga { get; set; }
        public string ProdukId { get; set; }

        public DataBuku_Tabel()
        {
            InitializeComponent();
            
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataBuku_Tabel_Load(object sender, EventArgs e)
        {
            LoadDataPelanggan();
            tbCari.Focus();
            data_buku.AllowUserToAddRows = false;
        }

        private void LoadDataPelanggan()
        {
            data_buku.Rows.Clear();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id_buku, judul, pengarang, harga, stok FROM books";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string id = reader["id_buku"].ToString();
                                string judul = reader["judul"].ToString();
                                string pengarang = reader["pengarang"].ToString();
                                string harga = reader["harga"].ToString();
                                string stok = reader["stok"].ToString();

                                data_buku.Rows.Add(id, judul, pengarang, harga, stok);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

   


        private void bCari_Click(object sender, EventArgs e)
        {
            string keyword = tbCari.Text;
            data_buku.Rows.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id_buku, judul, pengarang, harga, stok " +
                                   "FROM books WHERE id_buku LIKE @keyword OR " +
                                   "judul LIKE @keyword OR pengarang LIKE @keyword " +
                                   "OR harga LIKE @keyword OR stok LIKE @keyword";


                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string id = reader["id_buku"].ToString();
                                string judul = reader["judul"].ToString();
                                string pengarang = reader["pengarang"].ToString();
                                string harga = reader["harga"].ToString();
                                string stok = reader["stok"].ToString();

                                data_buku.Rows.Add(id, judul, pengarang, harga, stok);
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

        private void tbCari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                e.Handled = true;

               
                bCari_Click(sender, e);
            }
        }

        private void data_buku_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && data_buku.Rows[e.RowIndex].Cells[0].Value != null)
            {
                ProdukId = data_buku.Rows[e.RowIndex].Cells[0].Value.ToString();
                ProdukNama = data_buku.Rows[e.RowIndex].Cells[1].Value.ToString();
                ProdukHarga = data_buku.Rows[e.RowIndex].Cells[3].Value.ToString();

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Data tidak valid. Pastikan baris yang dipilih memiliki informasi yang lengkap.");
            }
        }

        private void data_buku_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
