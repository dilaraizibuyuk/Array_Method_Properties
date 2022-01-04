using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Method_Properties
{
    class Program
    {
        static void Main(string[] args)
        {   //isfixedsize özellik
            Array isimler = new[] { "ALİ", "VELİ", "OKTAY", "ASLI", "SELİM", "MUSTAFA" };
            Console.WriteLine(isimler.IsFixedSize);
            Console.ReadKey();
        }
    }
}
