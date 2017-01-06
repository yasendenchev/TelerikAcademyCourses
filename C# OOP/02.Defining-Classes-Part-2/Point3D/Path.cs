using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    public class Path
    {
        private List<Point3D> sequence = new List<Point3D>() ;

        public Path()
        {

        }

        public void AddPoint(Point3D point)
        {
            this.sequence.Add(point);
        }

        public List<Point3D> Sequence
        {
            get
            {
                return this.sequence;
            }
        }

        public void PrintAllSequences()
        {
            foreach (Point3D point in sequence)
            {
                Console.WriteLine(point);
            }
        }
    }
}
