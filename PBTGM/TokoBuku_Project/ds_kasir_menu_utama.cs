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
    public partial class ds_kasir_menu_utama : Form
    {
        public ds_kasir_menu_utama()
        {
            InitializeComponent();
        }

        private void bTransaksi_Click(object sender, EventArgs e)
        {
           LoadUserControl(new ds_kasir_transaksi_baru_control());
        }

        private void LoadUserControl(UserControl usercontrol)
        {
            panelMain.Controls.Clear();

            usercontrol.Dock = DockStyle.Fill;

            panelMain.Controls.Add(usercontrol);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ds_kasir_transaksi_baru_control());
        }

        private void tbStokBarang_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ds_kasir_stok_barang_control());
        }

        private void bTransaksiBaru_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ds_kasir_transaksi_baru_control());
        }

        private void ds_kasir_menu_utama_Load(object sender, EventArgs e)
        {
            LoadUserControl(new ds_kasir_transaksi_baru_control());
        }
    }
}
