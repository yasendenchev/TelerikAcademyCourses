using System;
class CompareCharArrays
{
    static void Main()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        if (first.Length == second.Length)
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] > second[i])
                {
                    Console.WriteLine(">");
                    break;
                }

                else if (first[i] < second[i])
                {
                    Console.WriteLine("<");
                    break;
                }

                else if (first[i] == second[i] && i == first.Length - 1)
                {
                    Console.WriteLine("=");
                    break;
                }

                else if (first[i] == second[i])
                {
                    continue;
                }

            }
        else if (first.Length > second.Length)
        {
            for (int i = 0; i < second.Length; i++)
            {
                if (first[i] > second[i])
                {
                    Console.WriteLine(">");
                    break;
                }

                else if (first[i] < second[i])
                {
                    Console.WriteLine("<");
                    break;
                }

                if (i == (second.Length - 1))
                {
                    Console.WriteLine(">");
                }
            }
        }
        else
        {
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] > second[i])
                {
                    Console.WriteLine(">");
                    break;
                }

                else if (first[i] < second[i])
                {
                    Console.WriteLine("<");
                    break;
                }

                if (i == (first.Length - 1))
                {
                    Console.WriteLine("<");
                }
            }

        }
    }
}
