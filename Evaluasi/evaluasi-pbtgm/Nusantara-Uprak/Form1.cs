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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nusantara_Uprak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
  


    private string koneksi = "server=localhost;user=root;database=db_nusantara;port=3306;";

        private void bLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string kata_sandi = tbKataSandi.Text;

            using (MySqlConnection conn = new MySqlConnection(koneksi))
            {
                conn.Open();

                string query = "SELECT * FROM user WHERE email = @email AND kata_sandi = @kata_sandi";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@kata_sandi", kata_sandi);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (tbEmail.Text.Length < 1 || tbKataSandi.Text.Length < 1)
                        {
                            MessageBox.Show("Form Tidak Boleh Kosong!");
                        }
                        else
                        {
                            if (tbEmail.Text.Contains("@"))
                            {

                                if (reader.Read())
                                {
                                    dashboard brando = new dashboard();
                                    brando.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Email atau Kata Sandi Salah!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Format harus berbentuk E-mail");
                            }
                        }
                        
                    }
                }
            }
        }
    }
}
