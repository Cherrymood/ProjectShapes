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
            Console.WriteLine("My Perimetr is " + this.CalculatePerimeter());
            Console.WriteLine("My Area is " + this.CalculateArea());
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