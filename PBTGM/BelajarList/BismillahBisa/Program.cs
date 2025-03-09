//List <string> nama_siswa = new List<string>();

//// Menambahkan data pada LIST
//nama_siswa.Add("Epul");
//nama_siswa.Add("Amauri");
//nama_siswa.Add("Buji Adi");
//nama_siswa.Add("Lord X");

//Console.WriteLine(nama_siswa[3]);

//// Menghapus item pada LIST
//nama_siswa.Remove("Epul");

//// Filter Item dengan FindAll
//List<string> siswa_r = nama_siswa.FindAll(item => item.Contains("r")); 

//Console.WriteLine(siswa_r.Count);

using BismillahBisa;

List<Siswa> siswa = new List<Siswa>();
// Ambil Nama Siswa 
siswa.Add(new Siswa("Epul", "XI-PPL", 15));
siswa.Add(new Siswa("Amar", "XI-PPL", 17));
siswa.Add(new Siswa("Laura", "XI-PPL", 19));
siswa.Add(new Siswa("Angel", "XI-PPL", 25));


//siswa.ForEach (aamiin => {
//    Console.WriteLine($"Nama Lengkap: {aamiin.Nama}");
//}) ;

siswa.ForEach(item => 
{
    if (item.Umur >= 15)
    {
        Console.WriteLine($"Nama Lengkap: {item.Nama}");
    }

  
});
