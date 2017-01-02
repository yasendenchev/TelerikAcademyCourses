using System;
class MaximalSum
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        int[,] matrix = new int[n, m];
        int sum = 0;
        int maxSum = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            string readline = Console.ReadLine();
            string[] stringArray = readline.Split(' ');
            int[] intArray = new int[stringArray.Length];

            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(stringArray[j]);
            }
        }

        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < m - 2; j++)
            {
                sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }

        Console.WriteLine(maxSum);
    }
}
