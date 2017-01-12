using System;
using System.Collections.Generic;

namespace Shapes
{
    class Startup
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Rectangle(4, 2));
            shapes.Add(new Triangle(3, 2));
            shapes.Add(new Square(2));

            foreach (var shape in shapes)
            {
                Console.WriteLine($"The surface of this {shape.GetType()} is: {shape.CalculateSurface()}");
            }
        }
    }
}
