namespace ArcadeGameCafe

{
    public class Customer : ICustomers
    {
        public void Enter()
        {
            Console.WriteLine("Customer entered the cafe");
        }

        public string MakeOrder()
        {
            Random choose = new Random();
            var newmenue = new Menue();
            int index = choose.Next(newmenue.menue.Count);
            string key = newmenue.menue.Keys.ElementAt(index);

            return key;
        }

        public int PayBill()
        {
            
        }
    }
}