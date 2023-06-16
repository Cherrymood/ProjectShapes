namespace ArcadeGameCafe

{
    public class Customer : ICustomers
    {
        private bool IsWaitingtimeOn = false;
        private string _key;
        private double _bill;
        
        
        public void Enter()
        {
            Console.WriteLine("Customer entered the cafe");
        }

        public (string, bool) MakeOrder()
        {
            Random choose = new Random();
            var newmenue = new Menue();
            int index = choose.Next(newmenue.menue.Count);
            string _key = newmenue.menue.Keys.ElementAt(index);

            return (_key, IsWaitingtimeOn = true);
        }
        /*
        how this method can get the return thing from the method in the other class???*/
        
        public bool GottheOrder()
        {
            return IsWaitingtimeOn = false;
        }

        public double PayBill(string _key)
        {
            var newmenue = new Menue();
            var _bill = newmenue.menue.GetValueOrDefault(_key);
            return _bill;
        }

        public void GoOut()
        {
            Console.WriteLine("Customer went out the cafe");
        }

        public void Wait()
        {
            for (int time = 0; time <= 6000; time ++)
            {
                if (IsWaitingtimeOn)
                {
                    time++;
                }
                
            }
        }
    }
}