using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek5
{
    class Program
    {
        static void Main(string[] args)
        {   //array.clear()
            int[] sayilar = { 2, 3, 6, 8, 7, 10, 1, 5 };
            Array.Clear(sayilar, 0, 3);//dizinin baştan ilk 3 elemanını sıfırlar

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Sayılar["+i+"]="+sayilar[i]);
            }
            Console.ReadLine();
        }
    }
}
