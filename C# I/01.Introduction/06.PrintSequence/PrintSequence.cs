using System;
class PrintSequence
{
    static void Main()
    {
        int a = 2;

        while (a <= 1001)
        {
            if (a % 2 != 0)
            {
                Console.Write("-");
            }
            Console.WriteLine(a);
            a++;
        }
    }
}
