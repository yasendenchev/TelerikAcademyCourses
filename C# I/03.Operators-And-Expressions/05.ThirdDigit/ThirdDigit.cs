using System;
class ThirdDigit
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int count = 0;
        while (count < 2)
        {
            number /= 10;
            count++;
        }

        if (number % 10 == 7)
        {
            Console.WriteLine("true");
        }

        else
        {
            Console.WriteLine("false {0}", number % 10);
        }
    }
}
