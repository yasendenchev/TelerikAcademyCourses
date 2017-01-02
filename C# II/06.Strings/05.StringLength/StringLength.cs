using System;
using System.Text;
class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder output = new StringBuilder();
        output.Append(input);
        while (output.Length < 20)
        {
            output.Append("*");
        }
        Console.WriteLine(output);

    }
}
