namespace ArcadeGameCafe
{
    interface IPlayer
    {
        public Menue TakeOrder();
        public int TakeMoney();
        public void CleanUp();
    }
}