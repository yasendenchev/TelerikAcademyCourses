﻿using System;
using System.Threading;
using System.Globalization;
class UnicodeCharacters
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write("\\u{0:X4}", (int)input[i]);
        }
        Console.WriteLine();
    }
}
