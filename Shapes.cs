namespace DrawingShaps
{
    public class Shape
    {
        public event EventHandler<ColorChangedEventArgs> BackgroundColorChanged; 
        public event EventHandler<ColorChangedEventArgs> BorderColorChanged;
        private double _length;
        public double length
        {
            get { return _length; }
        }
        private double _width;
        public double width
        {
            get { return _width; }
        }
        private string _shape;
        
        private ShapeColor _BackgroundColor;
        public ShapeColor BackgroundColor
        {            
            get { return _BackgroundColor; }
            set { if (_BackgroundColor != value)
                    {
                        _BackgroundColor = value;
                    }
                }
        }

        private ShapeColor  _BorderColor;
        public ShapeColor BorderColor
        {
            get { return _BorderColor; }
            set { if (_BorderColor != value)
                    {
                        _BorderColor = value;
                    }
                }
        }



        public Shape(double length, double width, ShapeColor backgroundcolor, ShapeColor bordercolor, string shape = "shape")
        {
            _length = length;
            _width = width;
            _shape = shape;
            _BackgroundColor = backgroundcolor;
            _BorderColor = bordercolor;
        }
        public void PrintTostring()
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

        protected virtual void OnBackgroundColorChanged(ColorChangedEventArgs e) =>
        BackgroundColorChanged?.Invoke(this, e);
        protected virtual void OnBorderColorChanged(ColorChangedEventArgs e) =>
        BorderColorChanged?.Invoke(this, e);

    }

}