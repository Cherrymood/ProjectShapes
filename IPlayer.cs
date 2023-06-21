namespace ArcadeGameCafe
{
    interface IPlayer
    {
       public void TakeOrder(string _key);
         public bool PrepareOrder(string _key);
        public bool GiveOrderToCustomer(bool IsOrderRady, string _key);
        public void TakeMoney(string _key, bool IsgiveOrder);
        public void CleanUp();
    }
}