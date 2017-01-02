using System;
class SumOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;

        for (int count = 0;count < n; count++)
        {
            double n2 = double.Parse(Console.ReadLine());
            sum += n2;
        }
        Console.WriteLine(sum);
    }
}
