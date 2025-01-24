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
    public partial class dashboard_kasir : Form
    {
        private Form ds_kasir_menu_utama;

        public dashboard_kasir()
        {
            InitializeComponent();
        }

        private void bManagement_Click(object sender, EventArgs e)
        {
            CloseAllMdiChildren();

            if(ds_kasir_menu_utama == null || ds_kasir_menu_utama.IsDisposed)
            {
                ds_kasir_menu_utama = new ds_kasir_menu_utama();
                ds_kasir_menu_utama.MdiParent = this;   
                ds_kasir_menu_utama.Dock = DockStyle.Fill;
                ds_kasir_menu_utama.FormClosed += Ds_kasir_menu_utama_FormClosed;
                ds_kasir_menu_utama.Show();
            }


        }

        private void Ds_kasir_menu_utama_FormClosed(object sender, FormClosedEventArgs e)
        {
            ds_kasir_menu_utama = null;
        }

        private void CloseAllMdiChildren()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }
    }
}
