using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek6
{
    class Program
    {
        static void Main(string[] args)
        {       //array.indexof
            int[] sayilar = { 2, 3, 6, 8, 7, 10, 1, 5 };

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Sayılar[" + i + "]=" + sayilar[i]);
            }
            Console.WriteLine(Array.IndexOf(sayilar,8).ToString()); //8 elemanının index numarasını yazdırdı
            Console.ReadLine();
        }
    }
}
