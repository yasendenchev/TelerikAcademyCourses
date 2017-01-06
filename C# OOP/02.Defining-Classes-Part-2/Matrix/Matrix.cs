using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix<T> where T : IComparable<T>
    {
        private T[,] matrix;
        private int col;
        private int row;

        public Matrix(int row, int col)
        {
            this.matrix = new T[row, col];
            this.col = col;
            this.row = row;

        }

        public int Col
        {
            get
            {
                return this.col;
            }
            
            set
            {
                this.col = value;
            }
        }

        public int Row
        {
            get
            {
                return this.col;
            }

            set
            {
                this.col = value;
            }
        }
        
        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }

            set
            {
                this.matrix[row, col] = value;
            }
        }
        


    }
}
