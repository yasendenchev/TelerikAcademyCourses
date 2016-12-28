using System;

class sequenceMatrix
{
    static void Main()
    {
        // input
        int[,] matrix = new int[5, 6];
        bool[,] isVisited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

        int maxCount = -1;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int currentX = i;
                int currentY = j;
                isVisited[i, j] = true;
                int totalCount = equalNeighboursCount(isVisited, matrix, currentX, currentY, 1);

                if (maxCount < totalCount)
                {
                    maxCount = totalCount;
                }
                Console.WriteLine(totalCount);

            }
        }



    }

    static int equalNeighboursCount(bool[,] isVisited, int[,] array, int x, int y, int currentCount)
    {



        // left
        if (y - 1 >= 0 && array[x, y - 1] == array[x, y] && (isVisited[x, y - 1] = false))
        {
            currentCount = equalNeighboursCount(isVisited, array, x, y - 1, currentCount);
        }

        // top
        if (x - 1 >= 0 && array[x - 1, y] == array[x, y] && (isVisited[x - 1, y] = false))
        {
            currentCount = equalNeighboursCount(isVisited, array, x - 1, y, currentCount);
        }


        // right
        if (y + 1 <= array.GetLength(0) && array[x, y + 1] == array[x, y] && (isVisited[x, y + 1] = false))
        {
            currentCount = equalNeighboursCount(isVisited, array, x, y + 1, currentCount);
        }

        // bottom
        if (x + 1 <= array.GetLength(1) && array[x + 1, y] == array[x, y] && (isVisited[x + 1, y] = false))
        {
            currentCount = equalNeighboursCount(isVisited, array, x + 1, y, currentCount);
        }

        return currentCount + 1;
    }
}