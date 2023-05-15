namespace DrawingShaps
{
    public class Shape
    {
        private double _length;
        private double _width;
        private string _shape;
        
        public Shape(double length, double width, string shape)
        {
            _length = length;
            _width = width;
            _shape = shape;
        }

        public double length
        {
            get { return _length; }
        }

        public double width
        {
            get { return _width; }
        }

        public string shape
        {
            get { return _shape; }
        }

        public virtual void PrintTostring()
        {
            Console.WriteLine("I am a {0} with measures {1} length and {2} width", _shape, _length, _width);
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