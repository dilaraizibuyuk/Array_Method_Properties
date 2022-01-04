using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek9
{
    class Program
    {
        static void Main(string[] args)
        {           //array.reverse
            int[] sayilar = { 2, 3, 6, 8, 7, 10, 1, 5 };
            Array.Reverse(sayilar); //diziyi tersine çevirir

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Sayılar[" + i + "]=" + sayilar[i]);
            }

            Console.ReadLine();
        }
    }
}
