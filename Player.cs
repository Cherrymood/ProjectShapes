namespace ArcadeGameCafe
{
    public class Player : IPlayer
    {
        private bool IsOrderRady = false;
        
        public void TakeOrder(string _key)
        {
            Console.WriteLine("The order was recieved. {0} is spreparing.", _key);
        }
        public bool PrepareOrder(string _key)
        {
            return IsOrderRady = true;
        }
        public void GiveOrderToCustomer();
        public double TakeMoney(string _key);
        public void CleanUp();
    }
}