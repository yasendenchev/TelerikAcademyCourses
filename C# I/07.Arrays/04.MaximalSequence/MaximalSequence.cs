using System;
class MaximalSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int tempCount = 1;
        int maxCount = 1;
        int previousNumber = array[n - 1];

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            if (i > 0)
            {
                if (array[i] == previousNumber)
                {
                    tempCount++;
                    if (tempCount >= maxCount)
                    {
                        maxCount = tempCount;
                    }
                    else
                    {
                        tempCount = 1;
                    }

                }

                else
                {
                    tempCount = 1;
                }
            }
                previousNumber = array[i];
        }

        Console.WriteLine(maxCount);
    }
}
