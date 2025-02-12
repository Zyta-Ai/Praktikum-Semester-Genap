using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TokoBuku_Project
{
    public partial class page_login : Form
    {
        private string connection = "server=localhost;user=root;database=db_tokobuku;port=3306;";


        public page_login()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim(); 

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT role FROM users WHERE username = @username AND password = @password;";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string roles = reader["role"].ToString();

                                if (roles == "admin")
                                {
                                    admin_dashboard dashboard_admin = new admin_dashboard();
                                    dashboard_admin.Show();
                                    this.Hide();
                                    dashboard_admin.FormClosed += (s, args) => this.Show(); 
                                }
                                else if (roles == "kasir")
                                {
                                    dashboard_kasir kasir_dashboard = new dashboard_kasir();
                                    kasir_dashboard.Show();
                                    this.Hide(); // Sembunyikan Login_Page
                                    kasir_dashboard.FormClosed += (s, args) => this.Show(); 
                                }
                                else
                                {
                                    MessageBox.Show("Role tidak dikenali.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Username atau Password salah.", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi Kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
