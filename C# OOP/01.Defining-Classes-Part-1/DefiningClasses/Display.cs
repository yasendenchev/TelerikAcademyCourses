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

        public Display(double? size = null, ulong? numberOfColors = null)
        {
            Size = (double)size;
            NumberOfColors = (ulong)numberOfColors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }

            set
            {
                if (size <= 0)
                {
                    throw new ArgumentOutOfRangeException("Display size must be larger than 0!");
                }

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
                if (numberOfColors <= 0)
                {
                    throw new ArgumentOutOfRangeException("Number of colors must be larger than 0!");
                }
            }
        }
    }
}
