using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Startup
    {
        static void Main()
        {
            GenericList<int> nums = new GenericList<int>(4);

            int one = 1;
            int One = 1;

            nums.Add(4);
            nums.Add(6);
            nums.Add(8);
            nums.Add(9);

            Console.WriteLine(nums.ToString());

            nums.Add(4);
            nums.Add(6);
            nums.Add(8);
            nums.Add(9);

            Console.WriteLine(nums.ToString());

            nums.Add(5);
            nums.Add(5);
            Console.WriteLine(nums.ToString());
            nums.InsertValueAtIndex(7, 1);
            Console.WriteLine(nums.ToString());
            nums.RemoveAtIndex(1);
            Console.WriteLine(nums.ToString());
            var max = nums.Max();
            var min = nums.Min();
            Console.WriteLine(min);

        }
    }
}
