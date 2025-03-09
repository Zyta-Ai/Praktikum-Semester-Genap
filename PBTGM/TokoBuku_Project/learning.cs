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
    public partial class learning : Form
    {
        public learning()
        {
            InitializeComponent();
        }

        private void tbKodeBuku_Enter(object sender, EventArgs e)
        {
            AutoCompleteStringCollection sumberBuku = new AutoCompleteStringCollection();
            Book.books.ForEach(item => sumberBuku.Add(item.kode_buku));

            tbKodeBuku.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbKodeBuku.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbKodeBuku.AutoCompleteCustomSource = sumberBuku;
        }

        private void tbJumlahBuku_Enter(object sender, EventArgs e)
        {
            Book bukuPilih = Book.books.Find(item => item.kode_buku == tbKodeBuku.Text);
            tbJudul.Text = bukuPilih.judul;
            tbPenerbit.Text = bukuPilih.penerbit;
            tbHargaBuku.Text = bukuPilih.harga.ToString("N0");
        }
    }
}
