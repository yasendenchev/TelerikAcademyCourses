using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class GSM
    {
        // Fields


        private static GSM iPhone4s = new GSM("Apple", "4S", 500, "Pesho");

        private string manufacturer;
        private string model;
        private int? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();
        private const decimal costPerMinute = 0.37M;

        // Constructor

        public GSM(string manufacturer, string model, int? price = null, string owner = null, Battery battery = null, Display display = null)
        {
            Manufacturer = manufacturer;
            Model = model;
            Owner = owner;
            Price = price;
            Battery = battery;
            Display = display;
        }

        // Properties


        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The manufacturer cannot be null or empty");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("The manufacturer's name must be shorter than 2 symbols");
                }

                this.manufacturer = value;
            }
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
                    throw new ArgumentNullException("The model cannot be null or empty");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("The model's name must be shorter than 2 symbols");
                }

                this.model = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public int? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }

            set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }

            set
            {
                this.callHistory = value;
            }
        }

        // Methods

        public string ShowInfo()
        {
            
           

            StringBuilder info = new StringBuilder();
            info.Append(this.model + " Information");
            info.Append("\n" + "Manufacturer:" + this.manufacturer);
            info.Append("\n" + "Model:" + this.model);
            info.Append("\n" + "Price:" + this.price);
            info.Append("\n" + "Owner:" + this.Owner);
            if (this.battery == null)
            {
                info.Append("\nNO BATTERY FOUND");
            }

            else
            {
                
                info.Append("\n" + "Battery type:" + this.battery.BatteryType);
                info.Append("\nBattery hours on idle:" + this.battery.HoursIdle);
                info.Append("\nBatterry hours for talking:" + this.battery.HoursIdle);
            }

            if (this.display == null)
            {
                info.Append("\nNO DISPLAY FOUND");
            }

            else
            {
                info.Append("\nDisplay size (inches):" + this.display.Size);
                info.Append("\nNumber of colors" + this.display.NumberOfColors);
            }
            

            return info.ToString();
        }

        public void AddCall(DateTime dateAndTime, string dialedNumber, int duration)
        {
            this.callHistory.Add(new Call( dateAndTime, dialedNumber, duration));
        }

        public void RemoveCall(int callIndex)
        {
            this.callHistory.RemoveAt(callIndex);
        }

        public void clearHistory()
        {
            this.callHistory.Clear();
        }
       
        public decimal CalculateTotalPrice()
        {
            decimal totalCost = 0;
            foreach (var call in callHistory)
            {
                totalCost += (call.Duration / 60) * costPerMinute;
            }

            return totalCost;
        }
    }
}
