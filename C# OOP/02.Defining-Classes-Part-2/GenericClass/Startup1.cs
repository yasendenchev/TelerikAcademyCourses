using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Startup1
    {
        static void Main()
        {
            GenericList<double> nums = new GenericList<double>(4);

            nums.Add(4);
            nums.Add(6);
            nums.Add(8);
            nums.Add(10);

            nums.ToString();
        }
    }
}
