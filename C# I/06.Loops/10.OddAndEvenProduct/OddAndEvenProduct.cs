using System;
using System.Numerics;
class OddAndEvenProduct
{
    static void Main()
    {
       
        
        
        int n = int.Parse(Console.ReadLine());
        BigInteger oddProduct = 1;
        BigInteger evenProduct = 1;
        string input = Console.ReadLine();


        for (int i = 0; i < n; i++)
        {

            if (i % 2 != 0)
            {
                evenProduct *= int.Parse(input.Split(' ')[i]);
            }

            else
            {
                oddProduct *= int.Parse(input.Split(' ')[i]);
            }

        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes {0}", oddProduct);
        }

        else
        {
            Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
        }
    }
}