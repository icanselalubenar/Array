using System;
namespace Array
{
    public class Mahasiswa
    {
        public int Nim { get; set; }
        public string Nama { get; set; }
        public int Nilai { get; set; }

        public Mahasiswa(int nim, string nama, int nilai)
        {
            Nim = nim;
            Nama = nama;
            Nilai = nilai;
        }
    }
}

