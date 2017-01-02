using System;
class TriangleSurfaceBySideAndAltitude
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F2}", a * h / 2);
    }
}
