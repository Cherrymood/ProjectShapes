namespace DrawingShaps
{
    public class Ellipse : Shape
    {
        public Ellipse(double SemiMajorAxes, double SemiMinorAxes)
            :base(SemiMajorAxes,SemiMajorAxes)
        {
            
        }
        public override void PrintTostring()
        {
            Console.WriteLine("I am a ellipse with measures {0} SemiMajorAxes and {1} SemiMajorAxes", length, width);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI*(Math.Sqrt((Math.Pow(length, 2) + Math.Pow(width, 2)/2)));
        }




    }
}