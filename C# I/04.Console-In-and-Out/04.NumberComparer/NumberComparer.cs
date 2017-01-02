using System;
class NumberComparer
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double maxValue = Math.Max(a, b);
        Console.WriteLine(maxValue);

    }
}

