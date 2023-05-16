namespace DrawingShaps
{
    public class Rectangle : Shape
    {
        public Rectangle(double length, double width, string shape)
            :base(length, width, shape)
        {
        }

        public override void PrintTostring()
        {
            base.PrintTostring();
        }

        public override double CalculatePerimeter()
        {
            return (length + width) * 2;
        }

        public override double CalculateArea()
        {
            return Math.Round(length * width);
        }
    }
}
