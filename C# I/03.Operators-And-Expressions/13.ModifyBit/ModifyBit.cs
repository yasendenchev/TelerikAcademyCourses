using System;
class ModifyBit
{
    static void Main()
    {
        ulong num = ulong.Parse(Console.ReadLine());
        int pos = int.Parse(Console.ReadLine());
        ulong value = ulong.Parse(Console.ReadLine());
        ulong mask = (ulong)1 << pos;
        ulong numAndMask = (ulong) num & mask;
        ulong bit = numAndMask >> pos;
        ulong result = num;

        if (value == 1)
        {
            bit = value;
            mask = bit << pos;
            result = num | mask;
            Console.WriteLine(result);
        }

        else
        {
            bit = value;
            mask = (ulong) ~(1 << pos);
            result = num & mask;
            Console.WriteLine(result);
        }

    }
}
