using System;
using System.Collections.Generic;
class SumIntegers
{
    static void Main()
    {

        string[] numbers = Console.ReadLine().Split(' ');
        int result = 0;
        foreach (string number in numbers)
        {
            result += int.Parse(number);
        }
        Console.WriteLine(result);
    }
}
