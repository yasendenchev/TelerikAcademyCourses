using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Display
    {
        private double size;
        private ulong numberOfColors;

        public Display(double size, ulong numberOfColors)
        {
            Size = size;
            NumberOfColors = numberOfColors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }

            set
            {
                this.size = value;
            }
        }

        public ulong NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }

            set
            {
                this.numberOfColors = value;
            }
        }
    }
}
