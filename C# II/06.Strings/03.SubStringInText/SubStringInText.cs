using System;
using System.Text;
using System.Numerics;
class SubStringInText
{
    static void Main()
    {
        string searchValue = Console.ReadLine();
        searchValue = searchValue.ToLower();
        string textToLower = Console.ReadLine();
        string text = textToLower.ToLower();
        int currentIndex = text.IndexOf(searchValue, 0);
        BigInteger counter = 0;

        while (currentIndex != -1)
        {
            currentIndex = text.IndexOf(searchValue, currentIndex + 1);
            counter++;
        }
        Console.WriteLine(counter);
    }
}
