using System;
using System.Globalization;
class Program
{
    static void Main()
    {

        double weight = double.Parse(Console.ReadLine());
        double moonGravity = 0.17;
        double weightOnMoon = weight * moonGravity;
        Console.WriteLine("{0:F3}", weightOnMoon);
    }
}

