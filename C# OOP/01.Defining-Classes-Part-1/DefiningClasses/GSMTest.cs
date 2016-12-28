using System;

namespace DefiningClasses
{
    class GSMTest
    {
        public static void Main()
        {
            GSM Galaxy = new GSM("Samsung", "Galaxy S5");
            Console.WriteLine(Galaxy.Owner);
          
        }
    }
}
