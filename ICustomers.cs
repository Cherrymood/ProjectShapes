namespace ArcadeGameCafe
{
    interface ICustomers
    {
        public void Enter();
        public (string, bool) MakeOrder();
        public bool GottheOrder();
        public double PayBill(string name);
        public void GoOut();
        public void Wait();
    }
}