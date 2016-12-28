using System;
class PrimeCheck
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        if (number == 1)
        {
            Console.WriteLine("false");
        }

        else if (number <= 0 || number >= 100)
        {
            Console.WriteLine("false");
        }

        else if (number > 0)
        {
            for (int count = 2; count < 10; count++)
            {
                if (number % count == 0 && number != count && number != 2)
                {
                    Console.WriteLine("false");
                    return;
                }
            }
            Console.WriteLine("true");
            return;
        }
        
    }
}

