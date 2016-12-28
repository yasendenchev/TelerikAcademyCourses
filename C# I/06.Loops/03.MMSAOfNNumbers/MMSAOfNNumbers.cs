using System;
class MMSAOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double min = 10000;
        double max = 0;
        double sum = 0;
        double average;
        double number;
        double previousNumber = -10000;

        for (int count = 1; count <= n; count++)
        {
            number = double.Parse(Console.ReadLine());

            if (number > previousNumber)
            {
                 max = number;
                previousNumber = number;
            }
            if (number < min)
            {
                min = number;
            }
            sum += number;
        }
        average = sum / n;
        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", average);
    }
}
