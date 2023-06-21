namespace ArcadeGameCafe
{
    interface ICustomers
    {
        public void Enter();
        public (string, bool) MakeOrder();
        public bool GottheOrder(bool IsOrderReady);
        public double PayBill(string name, bool IsOrderReady);
        public void GoOut();
        public void Wait();
    }
}