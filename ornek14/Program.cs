using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek14
{
    class Program
    {
        static void Main(string[] args)
        {       //replace
            string value1 = "Merhaba Tünya";
            string value2 = value1.Replace('T', 'D');//metindeki t harfiyle d harfini değiştiriyor
            Console.WriteLine(value2);

            string metin = "Dilara               İzibüyük";
            string replace = metin.Replace(" ", string.Empty);//aradaki boşlukları yok ediyor
            Console.WriteLine(replace);
            Console.ReadLine();
        }
    }
}
