namespace DrawingShaps
{
    public class Program
    {
        static void Main(string[]args)
        {
            var shape = new Shape(20, 10);
            shape.PrintTostring();

            var rectangle = new Rectangle(15.8, 60);
            rectangle.PrintTostring();

            var ellipse = new Ellipse(22.4, 66.9);
            ellipse.PrintTostring();

            var square = new Square(15.8);
            square.PrintTostring();

            var circle = new Circle(12.5);
            circle.PrintTostring();


        }
    }
}
