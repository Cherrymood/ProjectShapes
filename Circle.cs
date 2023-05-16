namespace DrawingShaps
{
    public class Circle : Ellipse
    {
        public Circle(double diametr, string shape)
            :base(diametr, diametr, shape)
        {

        }
        public override void PrintTostring()
        {
            base.PrintTostring();
        }

        public override double CalculateArea()
        {
            return Math.Round(Math.PI*(Math.Pow(length/2, 2)));
        }

        public override double CalculatePerimeter()
        {
            return Math.Round(2*Math.PI*length/2);
        }
    }
}