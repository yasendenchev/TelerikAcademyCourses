using System;

namespace DefiningClasses
{
    class GSMTest
    {
        public static void TestGSM()
        {
            GSM[] phones = new GSM[3];


            for (int i = 0; i < phones.Length; i++)
            {
                phones[i] = new GSM("Motorola", "C3", 350, "Petko", new Battery("c3 battery", 4, 3, BatteryType.NiCd), new Display(4.5, 1600000));
            }

            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ShowInfo());
                Console.WriteLine("---------------");
            }

            GSM.IPhone4s.ShowInfo();
        }
    }
}
