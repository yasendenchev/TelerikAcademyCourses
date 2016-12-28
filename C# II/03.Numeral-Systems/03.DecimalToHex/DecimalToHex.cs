using System;
class DecimalToHex
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        ulong remainder = 0;
        ulong hexadecimal = 0;
        string result = null;
        while (n != 0)
        {
            remainder = n / 16;
            hexadecimal = n % 16;
            n = remainder;

            if(hexadecimal > 9)
            {
                hexadecimal += 55;
                result = result + (char)hexadecimal;
            }
            else
            {
                result = result + hexadecimal;
            }
        }

        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
    }
}
