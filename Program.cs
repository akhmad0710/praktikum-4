using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak4
{
    class Program
    {
        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }

        static void Main(string[] args)
        {
            //deklarasi variabel

            int hasil;

            //membuat objek dari class kalkulator
            Kalkulator kalkulator = new Kalkulator();

            //panggil method penjumlahan

            hasil = kalkulator.Penjumlahan(10, 2);
            CetakHasil("hasil penjumlahan  :" + hasil);

            //panggil method penjumlhan dengan 3 parameter (overload  method)
            hasil = kalkulator.Penjumlahan(10, 2, 3);
            CetakHasil("hasil penjumlahan overload : " + hasil);

            //panggil methode prngurangan 
            hasil = kalkulator.Pengurangan(7, 2);
            CetakHasil("hasil  pengurangan: " + hasil);

            //panggil static method . langsung dari nama classnya
            hasil = Kalkulator.Perkalian(5, 2);
            CetakHasil("hasil perkalian: " + hasil);

            Console.ReadKey();
        }
    }
}
