namespace ArcadeGameCafe
{
    interface IPlayer
    {
        public string TakeOrder();
        public double PrepareOrder(string key);
        public void GiveOrderToCustomer();
        public double TakeMoney(string _key);
        public void CleanUp();
    }
}