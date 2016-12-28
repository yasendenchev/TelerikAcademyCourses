using System;
class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c;

        Console.WriteLine("A = {0}", a);
        Console.WriteLine("B = {0}", b);

        c = a;
        a = b;
        b = c;

        Console.WriteLine("A = {0}", a);
        Console.WriteLine("B = {0}", b);
    }
}

