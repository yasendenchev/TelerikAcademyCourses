using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Startup
    {
        static void Main()
        {
            Path path = new Path();

            path.AddPoint(new Point3D(2, 3, 5));
            path.AddPoint(new Point3D(6, 3, 5));
            path.AddPoint(new Point3D(5, 3, 5));
            path.AddPoint(new Point3D(4, 3, 2.3));
            path.AddPoint(new Point3D(3, 3, 8));
            path.AddPoint(new Point3D(7, 3, 7));
            path.AddPoint(new Point3D(12, 3, 5));
            path.AddPoint(new Point3D(2, 6, 5));
            path.AddPoint(new Point3D(9, 3, 5));

            PathStorage.Save(path);

            Path loaded = PathStorage.LoadPath("path.txt");
            
            Console.WriteLine(Utilities.CalculateDistance(new Point3D(2, 3, 5), new Point3D(2, 4, 5)));
        }
    }
}
