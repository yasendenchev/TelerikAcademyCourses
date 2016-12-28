using System;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        char a = '©';
        Console.WriteLine("    " + a + "\n");
        Console.WriteLine("  " + a + "   " + a + "\n");
        Console.WriteLine(" " + a + " " +  "    " + a + "\n");
        Console.WriteLine(a + "  " + a + " " + a + "  " + a);
    }
}

