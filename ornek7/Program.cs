using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek7
{
    class Program
    {
        static void Main(string[] args)
        {       //array.lastindexof
            int[] sayilar = { 2, 3, 6, 8, 7, 10, 1, 5 };

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Sayılar[" + i + "]=" + sayilar[i]);
            }
            Console.WriteLine(Array.LastIndexOf(sayilar, 8).ToString()); //8 elemanının index numarasını yazdırdı aramayı sondan yapar.
            Console.ReadLine();
        }
    }
}
