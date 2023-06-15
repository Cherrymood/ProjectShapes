namespace ArcadeGameCafe
{
    interface ICostomers
    {
        public void Enter();
        public Menue MakeOrder();
        public int GiveMoney();
        public void GoOut();
        public void Wait();
    }
}