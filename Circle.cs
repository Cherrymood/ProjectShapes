namespace DrawingShaps
{
    public class Circle : Ellipse
    {
        public Circle(double diametr, string name = "circle")
            :base(diametr, diametr, name)
        {

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