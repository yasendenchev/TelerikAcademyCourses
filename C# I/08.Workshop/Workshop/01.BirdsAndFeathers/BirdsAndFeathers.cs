using System;
class BirdsAndFeathers
{
    static void Main()
    {
        double b = double.Parse(Console.ReadLine());
        double f = double.Parse(Console.ReadLine());
        double averageFeathers = f / b;
        double result;

        if (b % 2 == 0)
        {
            result = averageFeathers * 123123123123;
        }
        
        else
        {
            result = averageFeathers / 317;
        }

        Console.WriteLine("{0:F4}", result);
    }
}
