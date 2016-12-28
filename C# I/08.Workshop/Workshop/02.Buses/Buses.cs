using System;
class Buses
{
    static void Main()
    {
        int c = int.Parse(Console.ReadLine());
        int groups = 0;
        int groupSpeed = int.MaxValue;
            
        for (int i = 1; i <= c; i++)
        {
            int busSpeed = int.Parse(Console.ReadLine());
            if (busSpeed <= groupSpeed)
            {
                groups++;
                groupSpeed = busSpeed;
            }


        }
        Console.WriteLine(groups);
    }
}
