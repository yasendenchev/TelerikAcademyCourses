namespace Shapes
{
    class Square : Shape
    {
        public Square(double height) : base(height, height)
        {
        }

        public override double CalculateSurface()
        {
            return this.Height * this.Height; 
        }
    }
}
