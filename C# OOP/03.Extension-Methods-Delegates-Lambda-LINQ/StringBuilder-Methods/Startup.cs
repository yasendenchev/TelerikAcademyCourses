using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Methods
{
    class Startup
    {
        static void Main()
        {
            StringBuilder sample = new StringBuilder();
            sample.Append("01234567");
            Console.WriteLine(sample.Substring(1, 3));

        }
    }
}
