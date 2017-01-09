using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Methods
{
   public static class Extension
    {
        public static StringBuilder Substring(this StringBuilder text, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            string resultAsString = (text.ToString()).Substring(index, length);
            result.Append(resultAsString);
            return result;
            
        }
    }
}
