namespace DrawingShaps
{
    public class ColorChangedEventArgs : EventArgs
   {
     public ShapeColor OldColor { get; set; }
     public ShapeColor NewColor { get; set; }
   }
}