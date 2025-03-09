using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nusantara_Uprak
{
    public partial class dashboard : Form
    {
        private string koneksi = "server=localhost;user=root;database=db_nusantara;port=3306;";
        private List<string> provinsiList = new List<string>();
        private List<string> kabupatenList = new List<string>();
        private List<string> kecamatanList = new List<string>();
        private int memberCounter = 1;

        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

            provinsiList = AmbilData("SELECT nama FROM provinsi");
            cbProvinsi.DataSource = provinsiList;

   
            tbKode.Enabled = false;
            cbKab.Enabled = false;
            cbKec.Enabled = false;

            cbProvinsi.Text = "";
            cbKab.Text = "";

            tbKode.Text = GenerateKodeMember();
        }



        private List<string> AmbilData(string query)
        {
            List<string> data = new List<string>();
            using (MySqlConnection conn = new MySqlConnection(koneksi))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        data.Add(reader["nama"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            return data;
        }

        private int DapatkanId(string query, string nama)
        {
            int id = -1;
            using (MySqlConnection conn = new MySqlConnection(koneksi))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        id = reader.GetInt32("id");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            return id;
        }


        private void cbProvinsi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvinsi.SelectedItem != null)
            {
                string provinsi = cbProvinsi.SelectedItem.ToString();
                int provinsiId = DapatkanId("SELECT id FROM provinsi WHERE nama = @nama", provinsi);

                if (provinsiId != -1)
                {
                    kabupatenList = AmbilData($"SELECT nama FROM kabupaten WHERE provinsi_id = {provinsiId}");
                    cbKab.DataSource = kabupatenList;
                    cbKab.Enabled = true;

                    cbKec.DataSource = null;
                    cbKec.Enabled = false;
                }
            }
        }

        private void cbKab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKab.SelectedItem != null)
            {
                string kabupaten = cbKab.SelectedItem.ToString();
                int kabupatenId = DapatkanId("SELECT id FROM kabupaten WHERE nama = @nama", kabupaten);

                if (kabupatenId != -1)
                {
                    kecamatanList = AmbilData($"SELECT nama FROM kecamatan WHERE kabupaten_id = {kabupatenId}");
                    cbKec.DataSource = kecamatanList;
                    cbKec.Enabled = true;
                }
            }
        }

        private string GenerateKodeMember()
        {
            int jumlahMember = 0;
            using (MySqlConnection conn = new MySqlConnection(koneksi))
            {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM member";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    jumlahMember = Convert.ToInt32(cmd.ExecuteScalar());
            }
            jumlahMember++;

            string tahun = DateTime.Now.ToString("yy");
            string nomor = jumlahMember.ToString("D3"); 
            return $"UP-{tahun}-{nomor}";
        }
    }
}

