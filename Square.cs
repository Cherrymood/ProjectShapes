namespace DrawingShaps
{
    public class Square : Rectangle
    {
        public Square(double side, ShapeColor backgroundcolor, ShapeColor boardcolor, string name = "square")
            :base(side, side, backgroundcolor, boardcolor, name)
        {
            
        }

    }
}