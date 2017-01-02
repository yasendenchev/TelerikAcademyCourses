using System;
class LeapYear
{
    static void Main()
    {
        if (DateTime.IsLeapYear(int.Parse(Console.ReadLine())))
        {
            Console.WriteLine("Leap");
        }
        else
        {
            Console.WriteLine("Common");
        }
    }
}

