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
    public partial class Struk_form : Form
    {
        public Struk_form()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Toko Beban", new Font("Poppins", 12, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Termal 1", 230, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }
    }
}
