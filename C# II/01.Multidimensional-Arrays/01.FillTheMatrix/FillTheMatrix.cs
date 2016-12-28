using System;
class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string pattern = Console.ReadLine();
        int counter = 1;
        int[,] matrix = new int[n, n];
        switch (pattern)
        {
            case "a":
                for (int rows = 0; rows < matrix.GetLength(1); rows++)
                {
                    for (int cols = 0; cols < matrix.GetLength(0); cols++)
                    {
                        matrix[cols, rows] = counter;
                        counter++;
                    }
                }
                break;


            case "b":
                for (int rows = 0; rows < matrix.GetLength(1); rows++)
                {
                    if (rows % 2 != 0)
                    {
                        counter += n;
                        for (int cols = 0; cols < matrix.GetLength(1); cols++)
                        {
                            counter--;
                            matrix[cols, rows] = counter;
                        }
                        counter += n;
                        continue;
                    }
                    for (int cols = 0; cols < matrix.GetLength(0); cols++)
                    {
                        matrix[cols, rows] = counter;
                        counter++;
                    }
                }

                break;
            case "c":
                for (int rows = n - 1; rows >= 0; rows--)
                {
                    int tracker = rows;
                    for (int cols = 0; cols < matrix.GetLength(0); cols++)
                    {


                        if (tracker == matrix.GetLength(0))
                        {
                            break;
                        }
                        matrix[tracker, cols] = counter;
                        counter++;
                        tracker++;




                    }
                }
                counter = n * n;
                for (int i = 0 ; i < n - 1; i++)
                {
                    int tracker = i;
                    for (int j = n - 1; j >= 0; j--)
                    {
                        if (tracker == -1)
                        {
                            break;
                        }
                        matrix[tracker, j] = counter;
                        counter--;
                        tracker--;
                    }
                }

                break;

            case "d":
                int top = 0;
                int bottom = 0;
                int left = 0;
                int right = 0;
                do
                {

                    int direction = 0;
                    if (direction == 0)
                    {
                        for (int i = 0 + top; i <= n - 1 - bottom; i++)
                        {
                            matrix[i, left] = counter++;

                        }
                        ++left;
                        ++direction;
                    }

                    if (direction == 1)
                    {
                        for (int i = 0 + left; i <= n - 1 - right; i++)
                        {
                            matrix[n - 1 - bottom, i] = counter++;
                        }
                        ++bottom;
                        ++direction;
                    }

                    if (direction == 2)
                    {
                        for (int i = n - 1 - bottom; i >= 0 + top; i--)
                        {
                            matrix[i, n - 1 - right] = counter++;
                        }
                        ++right;
                        ++direction;
                    }

                    if (direction == 3)
                    {
                        for (int i = n - 1 - right; i >= 0 + left; i--)
                        {

                            matrix[0 + top, i] = counter++;
                        }
                        ++top;
                    }
                } while (counter <= n * n);
                break;

        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0, 5}{1}", matrix[i, j], j == matrix.GetLength(1) - 1 ? "\n" : " ");
            }
        }
    }
}









