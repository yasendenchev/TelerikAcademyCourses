using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleByThreeAndSeven
{
    class Startup
    {
        static void Main(string[] args)
        {
            int[] myNumbers = new int[] { 1, 700, 35, 25, 50, 70 };



            Action<int> FilterNums = num =>
                {
                    if (num % 7 == 0 && num % 5 == 0)
                    {
                        Console.WriteLine($"{num}");
                    }
                };

            foreach (int number in myNumbers)
            {
                FilterNums(number);
            }


            Console.WriteLine("-----------------------------");
            Console.WriteLine("Same done with LINQ");

            var result = from n in myNumbers
                         where (n % 7 == 0 && n % 5 == 0)
                         select n;

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
        }


    }
}
