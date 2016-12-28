using System;
class HexadecimalToDecimal
{
    static ulong HexToDec(string input)
    {
        ulong result = 0;
        ulong hexValue;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] > 65)
            {
                hexValue = (ulong)input[i] - 55;
                result = result * 16 + hexValue;
            }
            else
            {
                hexValue = (ulong)input[i] - 48;
                result = result * 16 + hexValue;
            }
        }

        input.Replace()

        return result;
    }
    static void Main()
    {
        ulong result = HexToDec(Console.ReadLine());
        Console.WriteLine(result);
    }
}
