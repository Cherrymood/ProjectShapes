namespace DrawingShaps
{
    public class Program
    {
        static void Main(string[]args)
        {
            var shape = new Shape(20, 10);
            shape.PrintTostring("shape");

            var rectangle = new Rectangle(25, 60);
            rectangle.PrintTostring("rectangle");

            var ellipse = new Ellipse(22.4, 66.9);
            ellipse.PrintTostring("ellipse");

            var square = new Square(15.8);
            square.PrintTostring("square");


        }
    }
}
