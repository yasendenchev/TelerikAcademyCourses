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

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> result = new Matrix<T>(m1.Col, m1.Row);

            if (m1.Col != m2.Col || m1.Row != m2.Row)
            {
                throw new Exception("The matrices don't have the same size!");
            }
            else
            {
                for (int i = 0; i < m1.Row; i++)
                {
                    for (int j = 0; j < m1.Col; j++)
                    {
                        result[i, j] = (dynamic)m1[i, j] + m2[i, j];
                    }
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> result = new Matrix<T>(m1.Col, m1.Row);

            if (m1.Col != m2.Col || m1.Row != m2.Row)
            {
                throw new Exception("The matrices don't have the same size!");
            }
            else
            {
                for (int i = 0; i < m1.Row; i++)
                {
                    for (int j = 0; j < m1.Col; j++)
                    {
                        result[i, j] = (dynamic)m1[i, j] - m2[i, j];
                    }
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> result = new Matrix<T>(m1.Col, m1.Row);
            T temp = default(T);

            if (m1.Col != m2.Col || m1.Row != m2.Row)
            {
                throw new Exception("The matrices don't have the same size!");
            }
            else
            {
                for (int i = 0; i < m1.Row; i++)
                {
                    for (int j = 0; j < m1.Col; j++)
                    {
                        for (int k = 0; k < m1.Row; k++)
                        {
                            temp += (dynamic)m1[i, k] * m2[i, j];
                        }

                        result[i, j] = temp;
                        temp = default(T);
                    }
                }
                return result;
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool result = false;

            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic) matrix[i, j] == 0)
                    {
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool result = false;

            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic) matrix[i, j] == 0)
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }

        public  void Print()
        {
            Console.WriteLine("===============================");
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Col; j++)
                {
                    Console.Write($"{this.matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("===============================");
        }

    }
}
