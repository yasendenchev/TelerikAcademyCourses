using System;
using System.Text;
class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        string reverse = null;
        for (int i = 0; i < input.Length; i++)
        {
            reverse = reverse + input[input.Length - 1 - i].ToString();
        }
        Console.WriteLine(reverse);
    }
}
