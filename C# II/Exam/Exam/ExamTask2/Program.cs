using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask2
{
    class Program
    {
        static void Main()
        {
            string[] matrixSize = Console.ReadLine().Split('x');
            int rows = int.Parse(matrixSize[0]);
            int cols = int.Parse(matrixSize[1]);
            string[,] matrix = new string[rows,cols];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
            }
        }
    }
}
