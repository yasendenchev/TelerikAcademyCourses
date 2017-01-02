﻿using System;
class TriangleSurfaceByThreeSides
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double semiPerimeter = (a + b + c) / 2;
        double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
        Console.WriteLine("{0:F2}", area);
    }
}
