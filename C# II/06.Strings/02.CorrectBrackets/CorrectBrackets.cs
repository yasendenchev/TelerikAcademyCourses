using System;
class CorrectBrackets
{
    static void Main()
    {
        string input = Console.ReadLine();
        int openingBrackets = input.Split('(').Length - 1;
        int closingBrackets = input.Split(')').Length - 1;
        if (openingBrackets == closingBrackets && input.IndexOf('(') < input.IndexOf(')') && input.LastIndexOf(')') > input.LastIndexOf('('))
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}
