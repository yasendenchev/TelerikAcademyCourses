using System;
class Circle
{
    static void Main()
    {
        double circleRadius = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double circlePerimeter = 2 * pi * circleRadius;
        double circleArea = pi * Math.Pow(circleRadius, 2);

        Console.WriteLine("{0:F2} {1:F2}", circlePerimeter, circleArea);
    }
}
