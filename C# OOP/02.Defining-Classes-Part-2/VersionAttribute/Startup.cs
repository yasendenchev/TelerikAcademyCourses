using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    class Startup
    {
        static void Main()
        {
            var test = new Test();
            

            Console.WriteLine(test.GetType().GetCustomAttribute<Version>().Vers);
        }
        
    }


    [Version(1.3)]
    public class Test
    {

    }
}

