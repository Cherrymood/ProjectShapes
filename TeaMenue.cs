namespace ArcadeGameCafe
{
    public class Tea : IMenue
       {
       public string greenTea = "Geen tea";
       public string blackTea = "Black tea";
       public string bubbleTea = "Bubble tea";

       public void PreparationOrderTime()
        {
            for (int i = 0; i <= 1800; i++)
            {
                i++;
            }
        }
       
       }
}