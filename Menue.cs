namespace ArcadeGameCafe
{
    public class Menue
    {
        private Dictionary<string, double> _menue;
        private Dictionary<string, double> _preparingtime;


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

        public Dictionary<string, double> preparingTime
        {
            set {_menue = new Dictionary<string, double>()
        {
            {"Americano", 1.30},
            {"Latte", 3.00},
            {"Raf", 4.00},
            {"Green Tea", 1.00},
            {"Black Tea", 1.00},
            {"Bubble Tea", 3.00},
            {"Cake", 0.40},
            {"Ice-cream", 3.00},
            {"Waffles", 9.00},
            {"Chocolate topings", 0.30},
            {"Caramel topings", 0.30},
            {"Vanilla topings", 0.30}

        };}
            get {return _preparingtime;}
        }
    }
}