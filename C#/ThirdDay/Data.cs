namespace DataFunction
{
    public class Data
    {

        public static int BIG_MAC_COST = 5;
        public static int BEYOND_COST = 7;

        public bool _ordered { get; set; }
        public int _cash { get; set; }
        public int _balance { get; set; }
        public int[] _amountOrdered = new int[2];
    
        public void init()
        {
            _ordered = false;
            _cash = 60;
            _balance = 0;
            
            //0 = big macs ordred
            //1 = beyond burgers ordered
            _amountOrdered[0] = 0;
            _amountOrdered[1] = 0;
        }

        public void reset()
        {
            _amountOrdered[0] = 0;
            _amountOrdered[1] = 0;
            _balance = 0;
            _ordered = false;
        }

        public void removeBigMac()
        {
            _amountOrdered[0] = _amountOrdered[0] - 1;
            Console.WriteLine("You now have "+ _amountOrdered[0] +" Big Mac(s) in your cart.");
        }

        public void removeBeyond()
        {
            _amountOrdered[0] = _amountOrdered[0] - 1;
            Console.WriteLine("You now have "+ _amountOrdered[0] +" Beyond Burger(s) in your cart.");
        }
    }
}