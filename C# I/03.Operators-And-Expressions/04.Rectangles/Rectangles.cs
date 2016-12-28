using System;
class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimeter = width * 2 + height * 2;
        double area = width * height;
        Console.WriteLine("{0:F2} {1:F2}", area, perimeter);
    }
}
