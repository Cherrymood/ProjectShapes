namespace DrawingShaps
{
    public class Rectangle : Shape
    {
        public Rectangle(double length, double width)
            :base(length, width)
        {
            
        }

        public override void PrintTostring(string rectangle)
        {
            base.PrintTostring(rectangle);
        }

        public override double CalculatePerimeter()
        {
            return (length + width) * 2;
        }

        public override double CalculateArea()
        {
            return length * width;
        }
    }
}
