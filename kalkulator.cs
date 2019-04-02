using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak4
{
    public class Kalkulator
    {
        public int Penjumlahan(int a, int b)
        {
            return a + b;
        }

        public int Penjumlahan(int a, int b, int c)
        {
            return a + b + c;
        }

        //overload method

        public int Pengurangan(int a, int b)
        {
            return a - b;
        }

        //method static

        public static int Perkalian (int a, int b)
        {
            return a * b;
        
        }

    }

   

}
