using System;
using System.Linq;
    class CompareArrays
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for(int i = 0;i < firstArray.Length;i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < secondArray.Length; j++)
            {
                secondArray[j] = int.Parse(Console.ReadLine());
            }

            bool arraysAreEqual = Enumerable.SequenceEqual(firstArray, secondArray);

            if (arraysAreEqual)
            {
                Console.WriteLine("Equal");
            }

            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
