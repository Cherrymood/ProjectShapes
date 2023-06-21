namespace ArcadeGameCafe
{
    public class Player : IPlayer
    {
        private bool IsOrderReady = false;
        private bool IsgiveOrder = false;
        
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

            return IsOrderReady = true;
        }
        public bool GiveOrderToCustomer(bool IsOrderRady, string _key)
        {
            if (IsOrderReady)
            {
                Console.WriteLine("The order is ready. Here is your {0}", _key);
                return IsgiveOrder = true;
            }
            return false;
        }

        public void TakeMoney(string _key, bool IsgiveOrder)
        {
            if (IsgiveOrder)
            {
                var newmenue = new Menue();
                var money = newmenue.menue.GetValueOrDefault(_key);
                Console.WriteLine("You bill is {0}", money);
            }
        }
        public void CleanUp()
        {
            Console.WriteLine("It`s clean!");
        }
    }
}