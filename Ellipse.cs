namespace DrawingShaps
{
    public class Ellipse : Shape
    {
        public Ellipse(double SemiMajorAxes, double SemiMinorAxes)
            :base(SemiMajorAxes,SemiMajorAxes)
        {
            
        }
        public override void PrintTostring(string ellipse)
        {
            base.PrintTostring(ellipse);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI*(Math.Sqrt((Math.Pow(length, 2) + Math.Pow(width, 2)/2)));
        }

        public override double CalculateArea()
        {
            return Math.PI * length * width;
        }

    }
}