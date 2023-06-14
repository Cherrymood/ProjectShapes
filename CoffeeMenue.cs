namespace ArcadeGameCafe
{
public class Coffee : IMenue
{

        public string americanoCoffee = "Americano";
        public string latteCoffee =  "Latte";
        public string cakesFood = "Cake";
        private int _cofeePrice;

        public void PreparationOrderTime()
        {
            for (int i = 0; i <= 3000; i++)
            {
                i++;
            }
        }
    }
}