using System;
    class ExchangeNumbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c;

            if (a > b)
            {
                c = a;
                a = b;
                b = c;

                Console.WriteLine(a + " " + b);
            }

            else
            {
                Console.WriteLine(a + " " + b);
            }
        }
    }
