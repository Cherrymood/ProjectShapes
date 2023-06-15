namespace ArcadeGameCafe
{
    interface ICustomers
    {
        public void Enter();
        public string MakeOrder();
        public int PayBill();
        public void GoOut();
        public void Wait();
    }
}