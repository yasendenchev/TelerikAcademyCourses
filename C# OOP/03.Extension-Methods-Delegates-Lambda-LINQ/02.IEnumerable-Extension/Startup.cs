using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Extension
{
    class Startup
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine(list.CalulateSum());
            Console.WriteLine(list.CalculateProduct());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Average());
        }
    }
}
