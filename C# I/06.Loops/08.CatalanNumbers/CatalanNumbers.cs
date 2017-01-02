using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int doubleN = n * 2;
        int nPlus1 = n + 1;
        BigInteger nFactorial = 1;
        BigInteger doubleNFact = 1;
        BigInteger nPlus1Fact = 1;
        int nCount = 1;
        int doubleNCount = 1;
        int nPlus1Count = 1;
        BigInteger result = 1;

        while (doubleNCount <= doubleN || nPlus1Count <= nPlus1 || nCount <= n)
        {
            if (nCount <= n)
            {
                nFactorial *= nCount;
            }

            if (nPlus1Count <= nPlus1)
            {
                nPlus1Fact *= nPlus1Count;
            }

            if (doubleNCount > doubleN || nPlus1Count > nPlus1)
            {
                nPlus1Count++;
                nCount++;
            }


            doubleNFact *= doubleNCount;
            doubleNCount++;
            nPlus1Count++;
            nCount++;
        }
        result = doubleNFact / (nPlus1Fact * nFactorial);
        Console.WriteLine(result);
    }
}
