namespace DrawingShaps
{
    public class Ellipse : Shape
    {
        public Ellipse(double SemiMajorAxes, double SemiMinorAxes, ShapeColor backgroundcolor, ShapeColor bordercolor, string name = "ellipse")
            :base(SemiMajorAxes,SemiMajorAxes, backgroundcolor, bordercolor, name)
        {
            
        }

        public override double CalculatePerimeter()
        {
            return Math.Round(2 * Math.PI*(Math.Sqrt((Math.Pow(length, 2) + Math.Pow(width, 2)/2))));
        }

        public override double CalculateArea()
        {
            return Math.Round(Math.PI * length * width);
        }

    }
}