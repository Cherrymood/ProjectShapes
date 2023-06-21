namespace ArcadeGameCafe
{
    public class GameCafe
    {
        public Player player;
        public Customer customer;

        public void IsCafeOpen()
        {
            for (int i = 0; i <= 7000; i++)
            {
                customer.Enter();
                customer.MakeOrder();
                player.TakeOrder(string _key);
                player.PrepareOrder(string _key);
            }
        }
    }
}