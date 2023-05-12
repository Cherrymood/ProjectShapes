namespace DrawingShaps
{
    public class Program
    {
        static void Main(string[]args)
        {
            var shape = new Shape(20, 10);
            shape.CalculateArea();
            shape.CalculatePerimeter();
            shape.ToString();

            var rectangle = new Rectangle(25, 60);
            rectangle.ToString();

        }
    }
}
