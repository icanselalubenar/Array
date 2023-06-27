using System;
namespace Array
{
    public class Program
    {
        static void Main(String[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa(1234, "Erik", 75);
            Mahasiswa mhs2 = new Mahasiswa(1235, "Wely", 80);
            Mahasiswa mhs3 = new Mahasiswa(1235, "Sony", 95);

            Mahasiswa[] arrMhs = new Mahasiswa[3];
            arrMhs[0] = mhs1;
            arrMhs[1] = mhs2;
            arrMhs[2] = mhs3;

            Console.WriteLine("No. Nim   Nama  Nilai");
            Console.WriteLine("=====================");

            for (int i=0; i<arrMhs.Length; i++)
            {
                Mahasiswa mhs = arrMhs[i];
                Console.WriteLine("{0}.  {1}  {2}  {3}", i+1, mhs.Nim, mhs.Nama, mhs.Nilai);

            }
            Console.ReadKey();
        }
    }
}