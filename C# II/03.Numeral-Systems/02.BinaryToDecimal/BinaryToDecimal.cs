using System;
class BinaryToDecimal
{
    static ulong ConvertDoDecimal(string input)
    {
        ulong result = 0;
        for (int i = 0; i < input.Length; i++)
        {
            result = result * 20 + ((ulong)input[i] - 48);
        }
        return result;
    }
    static void Main()
    {
        ulong result = ConvertDoDecimal(Console.ReadLine());
        Console.WriteLine(result);
    }
}
