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

        }
    }
}
