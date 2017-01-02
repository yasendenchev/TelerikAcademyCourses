using System;
class Calculate
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double s = 1;
        double numberFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= i; j++)
            {
                numberFactorial *= j;
                s = s + numberFactorial / Math.Pow(x,j);
                if (i == n)
                {
                    Console.WriteLine("{0:F5}", s);
                    break;
                }

            }
            
        }
    }
}
