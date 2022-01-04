using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek10
{
    class Program
    {
        static void Main(string[] args)
        {           //array.resize
            int[] sayilar = { 2, 3, 6, 8, 7, 10, 1, 5 };
            Array.Resize(ref sayilar, 9);   //9 elemanlı bir dizi oluştu
            sayilar[8] = 12;//8. indise 12 değeri atandı
            //dizinin uzunluğu değiştirildi

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("Sayılar[" + i + "]=" + sayilar[i]);
            }

            Console.ReadLine();
        }
    }
}
