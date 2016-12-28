using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                int sqrt = Math.Sqrt(int.Parse(input));
                
                Console.WriteLine("{0:F3}", sqrt);
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("NaN");
                throw;

            }
            catch (FormatException)
            {
                
                Console.WriteLine("Invalid number");
                throw;
            }

            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
