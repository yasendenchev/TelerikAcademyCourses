sufaing System;
class Dealer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] occurrenceCount = new int[52];
        string[] cards = new string[] {"2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "Tc", "Jc", "Qc", "Kc", "Ac",
        "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "Td", "Jd", "Qd", "Kd", "Ad",
        "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "Th", "Jh", "Qh", "Kh", "Ah",
        "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "Ts", "Js", "Qs", "Ks", "As"};
        long bitAtPosition;
        bool isFullDeck = true;
        long[] hands = new long[n];
        for (int i = 0; i < n; i++)
        {
            hands[i] = long.Parse(Console.ReadLine());
            for (int j = 0; j <= 51; j++)
            {
                bitAtPosition = BitValueAtPosition(hands[i], j);
                if (bitAtPosition == 1)
                {
                    occurrenceCount[j]++;
                }
            }
        }
        foreach (int occurrences in occurrenceCount)
        {
            if (occurrences == 0)
            {
                isFullDeck = false;
                break;
            }

        }
        string message = isFullDeck ? "Full deck" : "Wa wa!";
        Console.WriteLine(message);

        for (int i = 0; i < occurrenceCount.Length; i++)
        {
            if (occurrenceCount[i] % 2 == 0)
            {
                Console.Write("{0}{1}", cards[i], i == occurrenceCount.Length - 1 ? "" : " ");
            }
        }


    }

    static long BitValueAtPosition(long number, int position)
    {
        long mask = (long)1 << position;
        long numAndMask = number & mask;
        long bit = numAndMask >> position;

        return bit;
    }
}