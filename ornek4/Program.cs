using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek4
{
    class Program
    {
        static void Main(string[] args)
        {
            //rank özellik
            Array isimler = new[] { "ALİ", "VELİ", "OKTAY", "ASLI", "SELİM", "MUSTAFA" };
            Console.WriteLine(isimler.Rank);
            Console.ReadKey();
        }
    }
}
