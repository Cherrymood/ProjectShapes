namespace DrawingShaps
{
    public class Shape
    {
        private double _length;
        private double _width;

        public void Shapes(double length, double width)
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

    }

}