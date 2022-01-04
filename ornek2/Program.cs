using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //isreadonly özellik
            Array isimler = new[] { "ALİ", "VELİ", "OKTAY", "ASLI", "SELİM", "MUSTAFA" };
            Console.WriteLine(isimler.IsReadOnly);
            Console.ReadKey();
        }
    }
}
