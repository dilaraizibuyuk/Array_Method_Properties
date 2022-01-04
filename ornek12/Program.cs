using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek12
{
    class Program
    {
        static void Main(string[] args)
        {       //trim -->baştaki ve sondaki boşlukları sildi
            string metin = "                   github.com    ";
            Console.WriteLine(metin.Trim());

            Console.ReadLine();
        }
    }
}
