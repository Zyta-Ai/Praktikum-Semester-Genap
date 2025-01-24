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
    public partial class ds_kasir_stok_barang_control : UserControl
    {
        public ds_kasir_stok_barang_control()
        {
            InitializeComponent();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void ds_kasir_stok_barang_control_Load(object sender, EventArgs e)
        {
            tbSearch.Focus();
            cbFilter.Text = "Filter";
        }
    }
}
