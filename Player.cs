namespace ArcadeGameCafe
{
    public class Player : IPlayer
    {
        private bool IsOrderRady = false;
        private bool IsgiveOrder;
        
        public void TakeOrder(string _key)
        {
            Console.WriteLine("The order was recieved. {0} is spreparing.", _key);
        }
        public bool PrepareOrder(string _key)
        {
            var newmenue = new Menue();
            var waitingtime = newmenue.preparingTime.GetValueOrDefault(_key);
            waitingtime *= 60;
            for (double i = 0; i <= waitingtime; i ++)
            {
                i++;
            }
            
            return IsOrderRady = true;
        }
        public void GiveOrderToCustomer(bool IsOrderRady)
        {

        }


        public double TakeMoney(string _key);
        public void CleanUp();
    }
}