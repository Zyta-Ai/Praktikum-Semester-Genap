using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BismillahBisa
{
    internal class Siswa
    {
        public Siswa()
        {
        }

        public Siswa(string nama, string kelas, int umur)
        {
            Nama = nama;
            Kelas = kelas;
            Umur = umur;
        }

        public string? Nama { get; set; }
        public string? Kelas { get; set; }
        public int Umur {  get; set; }

    }
}
