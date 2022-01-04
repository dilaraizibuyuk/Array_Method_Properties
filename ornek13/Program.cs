using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek13
{
    class Program
    {
        static void Main(string[] args)
        {   //trimdtart()

            string metin = "           Merhaba Dünya         ";
            Console.WriteLine(metin.TrimStart());//baştaki boşluğu siler
            Console.WriteLine(metin.TrimEnd());//sondaki boşluğu siler

            Console.ReadLine();
        }
    }
}
