﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{

    class Startup
    {
        static void Main()
        {
            GSMTest.TestGSM();

            Console.WriteLine("=============");

            CallHistoryTest.CallHistory();
        }
    }
}
