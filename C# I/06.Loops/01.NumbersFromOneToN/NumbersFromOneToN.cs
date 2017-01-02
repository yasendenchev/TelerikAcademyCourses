using System;
class NumbersFromOneToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int count = 1;count <= n;count++)
        {
            Console.Write("{0} ", count);
        }
    }
}
