using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    class Startup
    {
        static void Main()
        {
            List<string> strings = new List<string>();

            strings.Add("ivan");
            strings.Add("petko");
            strings.Add("georginikol");
            strings.Add("izdislav");
            strings.Add("ivan3245");
            strings.Add("plataOPlomo");
            strings.Add("comingcloseronceyoutellmeisthislove");

            string longestString = strings.OrderByDescending(x => x.Length).First();
            Console.WriteLine(longestString);
        }
    }
}
