namespace ArcadeGameCafe
{
    public class FoodandToppings : IMenue
    {
       public string wafflesFood = "Waffle";
       public string icecreamFood = "Ice-Cream";

       public string vanillaTopping = "Vanilla Topping";
       public string chocolateTopping = "Chocolate Topping";
       public string caramelTopping = "Caramel Topping";

       public void PreparationOrderTime()
        {
            for (int i = 0; i <= 1200; i++)
            {
                i++;
            }
        }
    }
}