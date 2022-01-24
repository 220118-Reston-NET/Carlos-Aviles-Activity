using System.Text.Json;

namespace DataFunction
{
    public class Data
    {

        /*
         * The file location.
         */
        private String _filepath = "./db/Mcdonalds.json";

        /*
         * Represents the cost of a big mac.
         */
        public static int BIG_MAC_COST = 5;

        /*
         * Represents the cost of a beyond meat burger.
         */
        public static int BEYOND_COST = 7;

        /*
         * Represents the amount of cash the user has.
         */
        public int _cash { get; set; }

        /*
         * Represents the total cart balance.
         */
        public int _balance { get; set; }

        /*
         * An array that stores how many burgers a user has ordered.
         */
        public int[] _amountOrdered = new int[2];

        public int[] AmountOrdered
        {
            get { return _amountOrdered; }
            set { _amountOrdered = value; }
        }
    
        /*
         * Initalize all needed variables.
         */
        public void init()
        {
            //_cash = 60;
            //_balance = 0;
            loadFile();
            
            //0 = big macs ordred
            //1 = beyond burgers ordered
            //_amountOrdered[0] = 0;
            //_amountOrdered[1] = 0;
        }

        /*
         * Reset the user's cart.
         */
        public void reset()
        {
            _amountOrdered[0] = 0;
            _amountOrdered[1] = 0;
            _balance = 0;
        }

        /*
        * Adds a specified amount of big macs to the cart.
        */
        public void addBigMac(int amount)
        {
            _amountOrdered[0] = _amountOrdered[0] + amount;
            _balance = _balance + (Data.BIG_MAC_COST * amount);
        }

        /*
        * Adds a specified amount of beyond burgers to the cart.
        */
        public void addBeyond(int amount)
        {
            _amountOrdered[1] = _amountOrdered[1] + amount;
            _balance = _balance + (Data.BEYOND_COST * amount);
        }

        /*
         * Remove a single big mac from the cart.
         */
        public void removeBigMac()
        {
            _amountOrdered[0] = _amountOrdered[0] - 1;
            Console.WriteLine("You now have "+ _amountOrdered[0] +" Big Mac(s) in your cart.");
        }

        /*
         * Remove a single beyond meat burger from the cart.
         */
        public void removeBeyond()
        {
            _amountOrdered[1] = _amountOrdered[1] - 1;
            Console.WriteLine("You now have "+ _amountOrdered[1] +" Beyond Burger(s) in your cart.");
        }

        /*
         * A flag that checks if the user has ordered a specific item.
         */
        public bool hasOrdered(int index)
        {
            if (_amountOrdered[index] == 0)
            {
                return false;
            }
            return true;
        }

        /*
         * Displays the items in the cart.
         */
        public void printCart()
        {
            Console.WriteLine("You have ordered "+ _amountOrdered[0] +" Big Mac(s)");
            Console.WriteLine("You have ordered "+ _amountOrdered[1] +" Beyond Burger(s)");
            Console.WriteLine();
        }

        /*
         * Gets the total costs of the items in the cart.
         */
        public int getTotalCost()
        {
            return (_amountOrdered[0] * BIG_MAC_COST) + (_amountOrdered[1] * BEYOND_COST);
        }

        /*
         * Save the user data onto a file.
         */
        public void saveFile()
        {
            string jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filepath, jsonString);
            Console.WriteLine("Saving file...");
            Console.WriteLine(jsonString);
        }

        /*
         * Load the user data from a file.
         */
        public void loadFile()
        {
            try
            {
                string jsonString = File.ReadAllText(_filepath);
                Data newUser = JsonSerializer.Deserialize<Data>(jsonString);
                _cash = newUser._cash;
                _balance = newUser._balance;
                AmountOrdered = newUser.AmountOrdered;

                Console.WriteLine("Loaded old user file...");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found. Creating default file.");
                _cash = 100;
                _balance = 0;
                string jsonString = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_filepath, jsonString);
            }
        }
    }
}