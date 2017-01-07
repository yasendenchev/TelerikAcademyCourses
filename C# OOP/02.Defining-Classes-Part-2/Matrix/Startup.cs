using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Startup
    {
        static void Main(string[] args)
        {
            Matrix<int> matrix = new Matrix<int>(2, 2);

            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            if (matrix)
            {
                Console.WriteLine("There is a zero cell");
            }
            else
            {
                Console.WriteLine("There are no zeroes");
            }
            matrix.Print();

        }
    }
}
