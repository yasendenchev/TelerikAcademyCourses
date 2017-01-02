using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class CallHistoryTest
    {
       public static void CallHistory()
        {

            GSM lg = new GSM("LG", "V20", 3500, "Haralampi");


            lg.AddCall(DateTime.Today, "0878906359", 300);
            lg.AddCall(new DateTime(2016, 12, 31, 23, 58, 59), "0888888888", 360);
            lg.AddCall(new DateTime(2016, 05, 31, 13, 40, 53), "+359983475435", 600);

            decimal totalPrice = lg.CalculateTotalPrice();
            Console.WriteLine($"You owe {totalPrice} BGN");

            int longestCall = 0;
            int longestCallIndex = 0;

            for (int i = 0; i < lg.CallHistory.Count; i++)
            {
                if (lg.CallHistory[i].Duration > longestCall)
                {
                    longestCall = lg.CallHistory[i].Duration;
                    longestCallIndex = i;
                }
            }

            lg.RemoveCall(longestCallIndex);

            decimal newPrice = lg.CalculateTotalPrice();
            Console.WriteLine($"You owe {newPrice} BGN");

            lg.clearHistory();
            PrintCallHistory(lg);

        }

        static void PrintCallHistory(GSM phone)
        {
            if (phone.CallHistory.Count == 0)
            {
                Console.WriteLine("No calls to show!");
            }

            for (int i = 0; i < phone.CallHistory.Count; i++)
            {
                Console.WriteLine($"Call info: \nNumber called: {phone.CallHistory[i].DialedNumber} \nCalled on: {phone.CallHistory[i].DateAndTime} \nDuration: {phone.CallHistory[i].Duration}");
            }
        }
    }

}
