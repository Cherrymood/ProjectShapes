namespace ArcadeGameCafe
{
    public class Menue
    {
        private Dictionary<string, double> _menue;

        public Dictionary<string, double> menue
        {
            set {_menue = new Dictionary<string, double>()
        {
            {"Americano", 2.30},
            {"Latte", 3.20},
            {"Raf", 4.15},
            {"Green Tea", 1.20},
            {"Black Tea", 1.25},
            {"Bubble Tea", 3.25},
            {"Cake", 1.34},
            {"Ice-cream", 2.25},
            {"Waffles", 2.65},
            {"Chocolate topings", 1.05},
            {"Caramel topings", 1.02},
            {"Vanilla topings", 0.97}

        };}
            get {return _menue;}
        }
        private int billtoPAy;
    }
}