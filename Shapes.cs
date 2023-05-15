namespace DrawingShaps
{
    public class Shape
    {
        private double _length;
        private double _width;

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

        public virtual void PrintTostring()
        {
            Console.WriteLine("I am a shape with measures {0} length and {1} width", _length, _width);
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