using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_text2num
{
    class Program
    {
        static void Main(string[] args)
        {
            int module = int.Parse(Console.ReadLine());
            string text = "Hello .NET 5! My name is Peter 8-)@";//Console.ReadLine();
            int result = 0;
            int sum = 1;
            int n;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '@')
                {
                    break;
                }
                else if (char.IsDigit(text[i]))
                {
                    result *= (int)Char.GetNumericValue(text[i]);
                }
                else if (char.IsLetter(text[i]))
                {
                    char.ToUpper(text[i]);
                    int textToInt = (int)text[i] - 65;
                    result += textToInt;
                }
                else if (char.IsPunctuation(text[i]) || text[i] == ' ')
                {
                    result = result % module;
                }
                Console.WriteLine(result);
            }

        }
    }
}