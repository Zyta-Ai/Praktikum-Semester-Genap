using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokoBuku_Project
{
    internal class Book
    {
        public Book(int id_buku, string kode_buku, string judul, string pengarang, string penerbit, float harga, int hanga)
        {
            this.id_buku = id_buku;
            this.kode_buku = kode_buku;
            this.judul = judul;
            this.pengarang = pengarang;
            this.penerbit = penerbit;
            this.harga = harga;
            this.hanga = hanga;
        }

        public Book()
        {
        }

        public int id_buku {  get; set; }  
        public string kode_buku { get; set; }
        public string judul {  get; set; }
        public string pengarang { get; set; }
        public string penerbit {  get; set; }
        public float harga  { get; set; }
        public int hanga { get; set; }


        public static List<Book> books = new List<Book>();
    }
}
