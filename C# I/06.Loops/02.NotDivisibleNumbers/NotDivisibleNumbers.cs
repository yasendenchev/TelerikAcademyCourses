using System;
class NotDivisibleNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int count = 1;count <= n;count++)
        {
            if (count % 3 == 0 || count % 7 ==0)
            {
                continue;
            }
            else
            {
                Console.Write("{0} ", count);
            }
        }
    }
}
