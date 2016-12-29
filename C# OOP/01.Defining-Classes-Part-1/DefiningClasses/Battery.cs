using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Battery
    {
        private BatteryType batteryType;
        private string model;
        private int hoursIdle;
        private int hoursTalk;

        public Battery(string model = null, int? hoursIdle = null, int? hoursTalk = null, BatteryType batteryType = 0)
        {

            Model = model;
            HoursIdle = (int)hoursIdle;
            HoursTalk = (int)hoursTalk;
            BatteryType = batteryType;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }

        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (hoursIdle <= 0)
                {
                    throw new ArgumentOutOfRangeException("The numbers of idle hours should be larger than 0!");
                }

                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (hoursTalk < 0)
                {
                    throw new ArgumentOutOfRangeException("The number of talk hours should be larger than 0!");
                }
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }

            set
            {
                this.batteryType = value;
            }
        }

    }
}
