using System;
    class PointCircleRectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double distance = Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2);
            double circleRadius = 1.5;
            string inCircle = "outside circle";
            string inRectangle = "inside rectangle";

            if (distance <= + Math.Pow(circleRadius, 2))
            {
                inCircle = "inside circle";
            }

            if (y > 1 || y < -1 || x < -1 || x > 5)
            {
                inRectangle = "outside rectangle";
            }
            
            Console.WriteLine("{0} {1}", inCircle, inRectangle);
            
        }
    }
