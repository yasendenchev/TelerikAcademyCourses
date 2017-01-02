using System;
    class QuadraticEquation
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double discriminant = Math.Pow(b, 2) - 4 * a * c;
            double firstRoot;
            double secondRoot;

            if (discriminant < 0)
            {
                Console.WriteLine("no real roots");
            }

            else if (discriminant == 0)
            {
                firstRoot = -b / (2 * a);
                Console.WriteLine("{0:F2}", firstRoot);
            }

            else
            {
                firstRoot = (-b - Math.Sqrt(discriminant)) / (2 * a);
                secondRoot = (-b + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("{0:F2}", firstRoot);
                Console.WriteLine("{0:F2}", secondRoot);
            }
        }
    }
