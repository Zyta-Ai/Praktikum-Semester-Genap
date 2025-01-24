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
    public partial class ds_kasir_transaksi_baru_control : UserControl
    {
        private string connectionString = "server=localhost;user=root;database=db_tokobuku;port=3306;";

        private string idBuku;

        public ds_kasir_transaksi_baru_control()
        {
            InitializeComponent();
        }



        private void ds_kasir_transaksi_baru_control_Load(object sender, EventArgs e)
        {   

        }

        private void SimpanTransaksi()
        {
            decimal totalHarga = 0;

            foreach (DataGridViewRow row in tabel_transaksi.Rows)
            {
                if (row.Cells["Subtotal"].Value != null)
                {
                    totalHarga += Convert.ToDecimal(row.Cells["Subtotal"].Value);
                }
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO transactions (tanggal, total_harga, id_user) VALUES (NOW(), @totalHarga, @idUser)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@totalHarga", totalHarga);
                        cmd.Parameters.AddWithValue("@idUser", 1); 
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        private void bTambahT_Click(object sender, EventArgs e)
        {
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }

            DataBuku_Tabel formPopUp = new DataBuku_Tabel();

            string kodeBuku = formPopUp.ProdukId; 
            string judulBuku = tbNamaBuku.Text;
            decimal hargaBuku = decimal.Parse(tbHargaBuku.Text);
            int jumlahBuku = int.Parse(tbJumlahBuku.Text);
            decimal subtotal = hargaBuku * jumlahBuku;

            tabel_transaksi.Rows.Add(kodeBuku, judulBuku, hargaBuku.ToString("C"), jumlahBuku, subtotal.ToString("C"));
        }

        private void bCariProduk_Click(object sender, EventArgs e)
        {

            DataBuku_Tabel formPopUp = new DataBuku_Tabel();
            if (formPopUp.ShowDialog() == DialogResult.OK)
            {
                tbNamaBuku.Text = formPopUp.ProdukNama; 
                tbHargaBuku.Text = formPopUp.ProdukHarga;
                string idBuku = formPopUp.ProdukId;
            }
        }

        private void tbCari_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbJumlahBuku_TextChanged(object sender, EventArgs e)
        {
            if(int.TryParse(tbJumlahBuku.Text, out int jumlahBuku))
            {
               if(decimal.TryParse(tbHargaBuku.Text, out decimal harga))
                {
                    decimal subtotal = harga * jumlahBuku;

                    tbSubtotal.Text = subtotal.ToString("C");
                }
                else
                {
                    tbSubtotal.Text = "Harga tidak valid";
                }
            }
            else
            {
                tbSubtotal.Text = "Jumlah tidak valid";
            }
        }
    }
}
