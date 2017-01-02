using System;
using System.Numerics;
class NumberAsArray
{
    static void Main()
    {
        string[] lengths = Console.ReadLine().Split(' ');
        int n = int.Parse(lengths[0]);
        int m = int.Parse(lengths[1]);
        int[] firstArray = GetArrays(n);
        int[] secondArray = GetArrays(m);
        int[] result = GetResult(firstArray, secondArray);
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write("{0} ", result[i]);
        }


    }

    static int[] GetArrays(int length)
    {
        string[] stringArray = Console.ReadLine().Split(' ');
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(stringArray[i]);
        }
        return array;
    }

    static int[] GetResult(int[] firstArray, int[] secondArray)
    {
        if (firstArray.Length != secondArray.Length)
        {
            int maxLength = Math.Max(firstArray.Length,
                secondArray.Length);


            int[] resultArray = new int[maxLength];


            if (firstArray.Length > secondArray.Length)
            {
                int[] thirdArray = new int[maxLength];
                for (int i = 0; i < secondArray.Length; i++)
                {
                    thirdArray[i] = secondArray[i];
                }
                for (int i = thirdArray.Length - 1; i >= secondArray.Length; i--)
                {
                    thirdArray[i] = 0;
                }

                for (int i = 0; i < maxLength; i++)
                {
                    resultArray[i] += firstArray[i] + thirdArray[i];
                    if (resultArray[i] >= 10)
                    {
                        resultArray[i] %= 10;
                        resultArray[i + 1] += 1;
                    }
                }
                return resultArray;
            }

            else
            {
                int[] thirdArray = new int[maxLength];

                for (int i = 0; i < firstArray.Length; i++)
                {
                    thirdArray[i] = firstArray[i];
                }

                for (int i = thirdArray.Length - 1; i >= firstArray.Length; i--)
                {
                    thirdArray[i] = 0;
                }

                for (int i = 0; i < maxLength; i++)
                {
                    resultArray[i] += secondArray[i] + thirdArray[i];
                    if (resultArray[i] >= 10)
                    {
                        resultArray[i] %= 10;
                        resultArray[i + 1] += 1;
                    }
                }

                return resultArray;
            }

        }

        else
        {
            int[] resultArray = new int[firstArray.Length];

            for (int i = 0; i < resultArray.Length; i++)
            {
                resultArray[i] += firstArray[i] + secondArray[i];
                if (resultArray[i] >= 10)
                {
                    resultArray[i] %= 10;
                    if (i < resultArray.Length - 1)
                    {
                        resultArray[i + 1] = 1;
                    }
                }
            }
            return resultArray;
        }

    }
}