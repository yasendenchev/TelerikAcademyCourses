using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class GSM
    {
        //private static string iPhone4S = "Some information about iphone 4s: 1gb hdd; 512mb ram; 5mp camera;";

        //public static string IPhone4S
        //{
        //    get { return iPhone4S; }
        //}

        private static GSM iPhone4s = new GSM("Apple", "4S", 500, "Pesho")


        private string manufacturer;
        private string model;
        private int price;
        private string owner;
        private Battery battery;
        private Display display;

        public GSM(string manufacturer, string model, int? price = null, string owner = null)
        {
            Manufacturer = manufacturer;
            Model = model;
            Owner = owner;
            Price = (int)price;
        }

        public int Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (price <= 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be less or equal to 0.");
                }
                this.price = value;
            }
        }

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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The owner's name cannot be null or empty");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("The owner's name cannot be shorter than 2 symbols");
                }

                this.owner = value;
            }
        }

    }
}
