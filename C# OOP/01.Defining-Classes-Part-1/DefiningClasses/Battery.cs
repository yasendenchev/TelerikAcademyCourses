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


        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType batteryType)
        {

            Model = model;
            HoursIdle = hoursIdle;
            HoursTalk = hoursTalk;
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
                this.hoursTalk = value;
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

    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }
}
