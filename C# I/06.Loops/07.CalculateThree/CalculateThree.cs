using System;
using System.Numerics;
class CalculateThree
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int j = n - k;
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger jFactorial = 1;
        int nCount = 1;
        int kCount = 1;
        int jCount = 1;
        BigInteger result = 1;

        while (nCount <= n || kCount <= k || jCount <= j)
        {
            if (jCount <= j)
            {
                jFactorial *= jCount;
            }

            if (kCount <= k)
            {
                kFactorial *= kCount;
            }

            if (nCount > n)
            {
                nCount++;
                kCount++;
                jCount++;
                continue;
            }

            nFactorial *= nCount;
            nCount++;
            kCount++;
            jCount++;
        }
        result = nFactorial / (kFactorial * jFactorial);
        Console.WriteLine(result);
    }
}
