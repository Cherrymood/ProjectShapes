namespace DrawingShaps
{
    public class Shape
    {
        private double _length;
        private double _width;

        private string _shape;

        public Shape(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public double length
        {
            get { return _length; }
        }

        public double width
        {
            get { return _width; }
        }

        public virtual void PrintTostring(string shape)
        {
            _shape = shape;

            Console.WriteLine("I am a {0} with measures {1} length and {2} width", shape, _length, _width);
            Console.WriteLine("My Perimetr is " + this.CalculatePerimeter());
            Console.WriteLine("My Area is " + this.CalculateArea());
        }

        public virtual double CalculatePerimeter()
        {
            return -1.0;
        }
        public virtual double CalculateArea()
        {
            return -1.0;
        }

    }

}