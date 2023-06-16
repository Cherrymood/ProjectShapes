namespace ArcadeGameCafe
{
    interface IPlayer
    {
        public string TakeOrder();
        public void PrepareOrder();
        public void GiveOrderToCustomer();
        public int TakeMoney();
        public void CleanUp();
    }
}