namespace ArcadeGameCafe
{
    public class Player : IPlayer
    {
        
        
        public void TakeOrder(string _key)
        {
            Console.WriteLine("The order was recieved. {0} is spreparing.", _key);
        }
        public void PrepareOrder();
        public void GiveOrderToCustomer();
        public int TakeMoney();
        public void CleanUp();
    }
}