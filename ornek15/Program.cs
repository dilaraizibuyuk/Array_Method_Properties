using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek15
{
    class Program
    {
        static void Main(string[] args)
        {   //replace kullanarak dışarıdan girilen metindeki virgülleri noktaya çevirme

            Console.WriteLine("İçinde değişiklik yapılacak metni giriniz:");
            string metin = Console.ReadLine();
            string yeni = metin.Replace(',', '.');//metinde , yerine . yazılıyor
            Console.WriteLine(yeni);
            Console.ReadLine();
        }
    }
}
