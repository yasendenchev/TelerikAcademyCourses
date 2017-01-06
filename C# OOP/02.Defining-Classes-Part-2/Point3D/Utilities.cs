using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class  Utilities
    {
        public static double CalculateDistance(Point3D pointOne, Point3D pointTwo)
        {
            double result = Math.Sqrt(Math.Pow(pointOne.X - pointTwo.X, 2) + Math.Pow(pointOne.Y - pointTwo.Y, 2) + Math.Pow(pointOne.Z - pointTwo.Z, 2));
            return result;
        }
    }
}
