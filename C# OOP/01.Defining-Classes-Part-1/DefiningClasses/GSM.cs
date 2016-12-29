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

        private static GSM iPhone4s = new GSM("Apple", "4S", 500, "Pesho")

        private string manufacturer;
        private string model;
        private int? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();
        private const double callCost = 0.37;

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
        
        // Methods

        public override string ToString()
        {
            string gsmInfo = $@"
{Model} information:
Manufacturer: {manufacturer}
Model: {Model}
Price: {Price} BGN
Owner: {Owner}
Battery type: {Battery.BatteryType}
Battery on idle: {Battery.HoursIdle}
Battery on talk: {Battery.HoursTalk}
Display size (inches): {Display.Size}
Display colors: {Display.NumberOfColors} 
";
            return gsmInfo;
        }

    }
}
