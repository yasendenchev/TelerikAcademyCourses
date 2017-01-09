using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Extension
{
    public static class Extensions
    {

        public static T  CalulateSum<T>(this IEnumerable<T> list)
        {
            dynamic sum = 0;
            foreach (T number in list)
            {
                sum += number;
            }

            return sum;
        }


        public static T CalculateProduct<T>(this IEnumerable<T> list)
        {
            dynamic product = 1;
            foreach (T number in list)
            {
                product *= number;
            }

            return product;
        }

        
        public static T Min<T>(this IEnumerable<T> list)
        {
            dynamic min = int.MaxValue;
            foreach (T number in list)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> list)
        {
            dynamic max = int.MinValue;
            foreach (T number in list)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            return max;
        }

        public static T Average<T>(this IEnumerable<T> list)
        {
            T sum = CalulateSum<T>(list);
            dynamic length = list.Count();
            dynamic avg = sum / length;

            return avg;
            
        }
    }
}
