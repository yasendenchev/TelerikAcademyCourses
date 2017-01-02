using System;
class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstMember = 0;
        int currentNumber = 1;
        int nextNumber;
        int previousNumber;
        
        if (n == 1)
        {
            Console.WriteLine(firstMember);
        }

        else 
        {
            Console.Write("{0}, {1}", firstMember, currentNumber);
            for (int count = 2; count < n;count++)
            {
                currentNumber += firstMember;
                firstMember = currentNumber - firstMember;
                Console.Write(", {0}", currentNumber);
            }
        }
    }
}
