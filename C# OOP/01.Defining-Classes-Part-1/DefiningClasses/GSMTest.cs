using System;

namespace DefiningClasses
{
    class GSMTest
    {
        public static void GSMtest()
        {
            GSM[] phones = new GSM[3];


            for (int i = 0; i < phones.Length; i++)
            {
                phones[i] = new GSM("Motorola", "C3", 350, "Petko");
            }

            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ShowInfo());
                Console.WriteLine("=============");
            }
        }
    }
}
