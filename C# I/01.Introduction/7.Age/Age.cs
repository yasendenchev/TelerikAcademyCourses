using System;
using System.Globalization;

class Age
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] dateAsArray = input.Split('.');
        DateTime myBirthDate = new DateTime(int.Parse(dateAsArray[2]), int.Parse(dateAsArray[0]), int.Parse(dateAsArray[1]));
        DateTime today = DateTime.Now;
        double  span = (today - myBirthDate).TotalDays;
        double age = Math.Floor(span / 365.25);
        Console.WriteLine(age);
        Console.WriteLine(age + 10);
    }
}

