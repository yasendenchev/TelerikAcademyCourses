using System;
class ThirdBit
{
    static void Main()
    {
        int position = 3;
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << position;
        int numAndMask = number & mask;
        int bit = numAndMask >> position;
        Console.WriteLine(bit);
    }
}