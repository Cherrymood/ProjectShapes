namespace DrawingShaps
{
    public class Rectangle : Shape
    {
        public Rectangle(double length, double width)
            :base(length, width)
        {
            
        }

        public override void PrintTostring()
        {
            Console.WriteLine("I am a rectangle with measures {0} length and {1} width", length, width);
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
