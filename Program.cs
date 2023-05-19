namespace DrawingShaps
{
    public class Program
    {
        static void Main(string[]args)
        {
            var shape = new Shape(20, 10, ShapeColor.Red, ShapeColor.Blue);
            shape.PrintTostring();

            var rectangle = new Rectangle(15.8, 60, ShapeColor.Yellow, ShapeColor.Blue);
            rectangle.PrintTostring();

            var ellipse = new Ellipse(22.4, 66.9, ShapeColor.Green, ShapeColor.Cyan);
            ellipse.PrintTostring();

            var square = new Square(15.8, ShapeColor.Cyan, ShapeColor.Unknown);
            square.PrintTostring();

            var circle = new Circle(12.5, ShapeColor.Red, ShapeColor.Magenta);
            circle.PrintTostring();


            var ListOfShapes = new List<Shape>();
            ListOfShapes.Add(shape);
            ListOfShapes.Add(rectangle);
            ListOfShapes.Add(ellipse);
            ListOfShapes.Add(square);
            ListOfShapes.Add(circle);

            foreach (var item in ListOfShapes)
            {
                if (item == square)
                {
                    Console.WriteLine("I am instantiated from class Square");
                    Console.WriteLine("Am I a Shape - {0}", (item == shape));
                    Console.WriteLine("Am I a Rectangle - {0}", (item == rectangle));
                    Console.WriteLine("Am I a Square - {0}", (item == square));
                    Console.WriteLine("Am I an Ellipse - {0}", (item == ellipse));
                    Console.WriteLine("Am I a Circle - {0}", (item == circle));
                }
                if (item == rectangle)
                {
                    Console.WriteLine("I am instantiated from class Rectangle");
                    Console.WriteLine("Am I a Shape - {0}", (item == shape));
                    Console.WriteLine("Am I a Rectangle - {0}", (item == rectangle));
                    Console.WriteLine("Am I a Square - {0}", (item == square));
                    Console.WriteLine("Am I an Ellipse - {0}", (item == ellipse));
                    Console.WriteLine("Am I a Circle - {0}", (item == circle));
                }
            }

            foreach (var item in ListOfShapes)
            {
                if ( item.BackgroundColor == ShapeColor.Red)
                {
                    Console.WriteLine(item.BorderColor);
                }
                else if ( item.BackgroundColor == ShapeColor.Green)
                {
                   Console.WriteLine(item.length);
                }
                else if ( item.BackgroundColor == ShapeColor.Yellow)
                {
                   item.ToString();
                }

            }


        }
    }
}
