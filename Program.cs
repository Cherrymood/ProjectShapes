namespace DrawingShaps
{
    public class Program
    {
        static void Main(string[]args)
        {
            var shape = new Shape(20, 10);
            shape.CalculateArea();
            shape.CalculatePerimeter();
            shape.PrintTostring();

            var rectangle = new Rectangle(25, 60);
            rectangle.CalculateArea();
            rectangle.CalculatePerimeter();
            rectangle.PrintTostring();

            var ellipse = new Ellipse(22.4, 66.9);
            ellipse.CalculateArea();
            ellipse.CalculatePerimeter();
            ellipse.PrintTostring();


        }
    }
}
