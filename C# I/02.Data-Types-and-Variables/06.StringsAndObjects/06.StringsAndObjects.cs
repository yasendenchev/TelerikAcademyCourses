using System;
class Program
{
    static void Main()
    {
        string hello = "Hello";
        string world = "World";
        object hWorld = hello + " " + world;
        string helloWorld = (string) hWorld;
        
        Console.WriteLine(helloWorld);
    }
}
