using System;
class Program
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double difference = 0.000001;

        if (firstNumber > secondNumber)
        {
            if (firstNumber - secondNumber > difference)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }

        else if (secondNumber > firstNumber)
        {
            if (secondNumber - firstNumber > difference)
            {
                Console.WriteLine("false");
            }

            else
            {
                Console.WriteLine("true");
            }
        }

        
    }
}
