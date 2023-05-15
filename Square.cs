namespace DrawingShaps
{
    public class Square : Rectangle
    {
        public Square(double side)
            :base(side,side)
        {
            
        }

        public override void PrintTostring(string square)
        {
            base.PrintTostring(square);
        }
    }
}