using System;
using System.Numerics;
class TrailingZeroInN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int zeroCount = 0;

        const int fives = 5;
        int fiveSquare = 1;

        while (n > fiveSquare)
        {
            fiveSquare *= fives;
            if (n <= fiveSquare)
            {
                break;
            }
            zeroCount += n / fiveSquare;
        }
        Console.WriteLine(zeroCount);



        //BigInteger n = int.Parse(Console.ReadLine());
        //BigInteger nFactorial = 1;
        //int Five = 5;
        //int count = 0;

        //while (n >= 5)
        //{
        //    n /= Five;
        //    Five *= Five;
        //    count++;
        //}


        //for (int i = 1; i <= n; i++)
        //{
        //    nFactorial *= i;
        //}
        //Console.WriteLine(nFactorial);
        //while (nFactorial % 100000 == 0)
        //{
        //    nFactorial /= 100000;
        //    count += 6;
        //}

        //Console.WriteLine(count);
    }
}
