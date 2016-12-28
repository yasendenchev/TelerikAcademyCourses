using System;
using System.Text;
class Program
{
    static char[] DecimalToBinary(ulong input)
    {
        ulong binary = 0;
        ulong remainder = 0;
        string revResult = null;

        while (input != 0)
        {
            remainder = input / 2;
            binary = input % 2;
            revResult = revResult + binary;
            input = remainder;
        }

        char[] result = new char[revResult.Length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = revResult[result.Length - 1 - i];
        }

        return result;
    }
    static void Main()
    {
        char[] result = DecimalToBinary(ulong.Parse(Console.ReadLine()));
        foreach (char digit in result)
        {
            Console.Write(digit);
        }
    }
}
