namespace Shapes
{
    public abstract class Shape
    {
        private double height;
        private double width;

        public Shape(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
