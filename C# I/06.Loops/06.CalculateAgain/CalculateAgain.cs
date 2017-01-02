using System;
using System.Numerics;
class CalculateAgain
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        ulong k = ulong.Parse(Console.ReadLine());
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger nCount = 1;
        BigInteger kCount = 1;
        BigInteger result = 1;

        if ( k >= n)
        {
            
        }

        while (nCount <= n || kCount <= k)
        {

            if (kCount <= k)
            {
                kFactorial *= kCount;
            }
            if (nCount <= n)
            {
                nFactorial *= nCount;
            }

            if (nCount > n)
            {
                nCount++;
                kCount++;
                continue;
            }

            nCount++;
            kCount++;
        }

        result = nFactorial / kFactorial;
        Console.WriteLine(result);
    }
}
