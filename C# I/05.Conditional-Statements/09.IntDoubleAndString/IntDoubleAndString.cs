using System;
class IntDoubleAndString
{
    static void Main()
    {
        string variable = Console.ReadLine();
        int integer;
        double real;
        string text;

        switch (variable)
        {
            case "integer": 
                integer = int.Parse(Console.ReadLine());
                Console.WriteLine(++integer);
                break;
            case "real":
                real = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", ++real);
                break;
            case "text":
                text = Console.ReadLine();
                Console.WriteLine("{0}*", text);
                break;

        }
    }
}
