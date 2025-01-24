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
    public partial class admin_dashboard : Form
    {

        private Form beranda_menu;
        private Form manajemen_page;
        private Form laporan_page;
        private Form diskon_menu;

        public admin_dashboard()
        {
            InitializeComponent();
        }

        private void bBeranda_Click(object sender, EventArgs e)
        {
            CloseAllMdiChildren();

            if (beranda_menu == null || beranda_menu.IsDisposed)
            {
                beranda_menu = new ds_admin_beranda_menu();
                beranda_menu.MdiParent = this;
                beranda_menu.Dock = DockStyle.Fill;
                beranda_menu.FormClosed += Beranda_menu_FormClosed;
                beranda_menu.Show();
            }
            
        }

        private void Beranda_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            beranda_menu = null;
 
        }

        private void bManagement_Click(object sender, EventArgs e)
        {
            CloseAllMdiChildren();

            if (manajemen_page == null || manajemen_page.IsDisposed)
            {
                manajemen_page = new ds_admin_manajemen_menu();
                manajemen_page.MdiParent = this;
                manajemen_page.Dock = DockStyle.Fill;
                manajemen_page.FormClosed += Manajemen_page_FormClosed;
                manajemen_page.Show();
            }
            
        }

        private void Manajemen_page_FormClosed(object sender, FormClosedEventArgs e)
        {
            manajemen_page = null;
        }

        private void bLaporan_Click(object sender, EventArgs e)
        {
            CloseAllMdiChildren();

            if (laporan_page == null  || laporan_page.IsDisposed)
            {
                laporan_page = new ds_admin_laporan_menu();
                laporan_page.MdiParent = this;   
                laporan_page.Dock= DockStyle.Fill;
                laporan_page.FormClosed += Laporan_page_FormClosed;
                laporan_page.Show();
            }
        }

        private void Laporan_page_FormClosed(object sender, FormClosedEventArgs e)
        {
            laporan_page = null;    
        }

        private void bDiskon_Click(object sender, EventArgs e)
        {
            CloseAllMdiChildren();

            if (diskon_menu == null || diskon_menu.IsDisposed)
            {
                diskon_menu = new ds_admin_diskon_menu();
                diskon_menu.MdiParent = this;
                diskon_menu.Dock = DockStyle.Fill;
                diskon_menu.FormClosed += Diskon_menu_FormClosed;
                diskon_menu.Show();
            }
        }

        private void Diskon_menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            diskon_menu = null;
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
