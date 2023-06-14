namespace ArcadeGameCafe
{
    interface ICostomers
    {
        public void Enter();
        public Order MakeOrder();
        public int GiveMoney();
        public void GoOut();
        public void Wait();
    }
}