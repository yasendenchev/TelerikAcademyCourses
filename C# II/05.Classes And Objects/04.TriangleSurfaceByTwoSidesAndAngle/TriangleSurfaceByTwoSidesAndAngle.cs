using System;
class TriangleSurfaceByTwoSidesAndAngle
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double angleC = double.Parse(Console.ReadLine());
        double result = 0.5 * a * b * Math.Sin(angleC * Math.PI / 180);
        Console.WriteLine("{0:F2}", result);
    }
}
