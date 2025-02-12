using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelajarVariabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Siswa siswa = new Siswa();
            siswa.nama = "Epul";    
            
            Siswa murid = new Siswa();

            Siswa.jenis_kelamin = "Laki-laki";

            Form2 form = new Form2();
            form.Show();
        }
    }
}
