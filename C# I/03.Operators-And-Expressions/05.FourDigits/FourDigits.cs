using System;
class FourDigits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int units = number % 10;
        int tens = number % 100 / 10;
        int hundreds = number % 1000 / 100;
        int thousands = number % 10000/ 1000 ;
        int sum = units + tens + hundreds + thousands;

        Console.WriteLine(sum);
        Console.WriteLine("{0}{1}{2}{3}", units, tens, hundreds, thousands);
        Console.WriteLine("{0}{1}{2}{3}", units, thousands, hundreds, tens);
        Console.WriteLine("{0}{1}{2}{3}", thousands, tens, hundreds, units);
    }
}

