using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Call
    {
        private DateTime dateAndTime;
        private string dialedNumber;
        private uint duration;

        public Call (DateTime dateAndTime, string dialedNumber, uint duration)
        {
            this.dateAndTime = dateAndTime;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }

    }
}
