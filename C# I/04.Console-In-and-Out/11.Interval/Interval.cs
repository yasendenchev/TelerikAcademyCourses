using System;
class Interval
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int lastNumber = int.Parse(Console.ReadLine());
        int counter = 0;

        if (firstNumber == lastNumber)
        {
            counter = 0;
        }

        else
        {
            while (firstNumber < lastNumber)
            {
                firstNumber++;
                if (firstNumber % 5 == 0)
                {
                    counter++;
                }
            }

            if (lastNumber % 5 == 0)
            {
                counter--;
            }
        }

        Console.WriteLine(counter);
    }
}
