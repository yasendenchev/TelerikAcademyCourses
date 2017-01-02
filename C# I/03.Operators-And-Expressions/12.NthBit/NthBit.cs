using System;
class NthBit
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int pos = int.Parse(Console.ReadLine());


        int mask = 1 << pos;
        int numAndMask = num & mask;
        int bit = numAndMask >> pos;

        if (pos > 24)
        {
            bit = 0;
        }
        Console.WriteLine(bit);


    }
}
