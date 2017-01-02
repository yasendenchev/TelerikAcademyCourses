using System;
class BitExchange
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        ulong mask3 = (number & (7 << 3)) >> 3;
        ulong mask24 = (number & (7 << 24)) >> 24;
        ulong identity = mask3 ^ mask24;

        number = number ^ identity << 3;
        number = number ^ identity << 24;

        Console.WriteLine(number);

    }
}
