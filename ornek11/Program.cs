using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek11
{
    class Program
    {
        static void Main(string[] args)
        {   //kullanıcı metin ve kelime girecek ve girilen kelimenin metinde kaç tane olduğu bulunacak

            Console.WriteLine("İçinde arama yapılacak metni giriniz:");
            string metin = Console.ReadLine();
            Console.WriteLine("Aranacak kelimeyi giriniz:");
            string kelime = Console.ReadLine();
            int sayac = 0;
            int konum = metin.IndexOf(kelime);
            while (konum!=-1)
            {
                konum = metin.IndexOf(kelime, konum + 1);
                sayac++;

            }
            Console.WriteLine("Aradığınız kelimeden {0} tane var.",sayac);
            

            Console.ReadLine();
        }
    }
}
