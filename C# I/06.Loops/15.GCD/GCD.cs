using System;
using System.Numerics;
class asd
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int a = Math.Abs(int.Parse(input[0]));
        int b = Math.Abs(int.Parse(input[1]));
        int biggerNumber = Math.Max(a, b);
        int smallerNumber = Math.Min(a, b);
        int divRes = biggerNumber / smallerNumber;
        int gcd;

        while (biggerNumber % smallerNumber != 0)
        {
            int remainder = biggerNumber % smallerNumber;
            biggerNumber = smallerNumber;
            smallerNumber = remainder;

        }
        gcd = smallerNumber;

        Console.WriteLine("{0}", gcd);
    }
}
