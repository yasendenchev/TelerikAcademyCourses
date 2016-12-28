using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Battery
    {
        private string model;
        private int hoursIdle, hoursTalk;

        public Battery(string model = null, int? hoursIdle = null, int? hoursTalk = null)
        {
            this.model = model;
            this.hoursIdle = (int)hoursIdle;
            this.hoursTalk = (int)hoursTalk;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Battery model should not be empty or null!");
                }

                if (model.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Battery model should be longer than 2 symbols!");
                }

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
                if(hoursTalk < 0)
                {
                    throw new ArgumentOutOfRangeException("The number of talk hours should be larger than 0!");
                }
            }
        }

    }
}
