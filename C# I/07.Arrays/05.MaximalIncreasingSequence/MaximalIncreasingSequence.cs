using System;
class MaximalIncreasingSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        int tempCount = 1;
        int maxCount = 1;


        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());

            if (i == 0)
            {
                continue;
            }

            if (array[i] > array[i - 1])
            {
                ++tempCount;

                if (tempCount > maxCount)
                {
                    maxCount = tempCount;
                }
            }

            else
            {
                tempCount = 1;
            }
        }

        Console.WriteLine(maxCount);
    }
}

