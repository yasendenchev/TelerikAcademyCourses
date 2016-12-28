using System;
using System.Text;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder output = new StringBuilder();
        if (input.IndexOf("<upcase>") < input.IndexOf("</upcase>"))
        {
            while (input.Contains("<upcase>") == true && input.Contains("</upcase>") == true)
            {
                string[] inputToArray = input.Split(new[] { "<upcase>", "</upcase>" }, StringSplitOptions.None);

                for (int i = 0; i < inputToArray.Length; i += 2)
                {
                    output.Append(inputToArray[i]);
                    if (i % 2 == 0 && i + 1 < inputToArray.Length - 1)
                    {
                        output.Append(inputToArray[i + 1].ToUpper());
                    }
                }
                input = output.ToString();
            }
        }

        else
        {
            output.Append(input);
        }
        Console.WriteLine(output);
    }

}