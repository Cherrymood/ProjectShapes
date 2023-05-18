namespace DrawingShaps
{
    public class Rectangle : Shape
    {
        public Rectangle(double length, double width, ShapeColor backgroundcolor, ShapeColor bordercolor, string name = "rectangle")
            :base(length, width, backgroundcolor, bordercolor, name)
        {
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
