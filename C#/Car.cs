//This is a comment
namespace CarFunction 
{
    public class Car
    {
        private string _color = "Blue";
        private int _GPM = 0;

        public string Color {
            get
            {
                return "The color is "+ _color;
            }
            set
            {
                _color = value;
            }
        }

        private string _owner;
        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
        
        public int fuel { get; set; }

        public void Start(int p_fuel)
        {
            fuel = p_fuel;
            Console.WriteLine("The car is starting");
            Console.WriteLine($"Current fuel: {fuel}");
        }

        public Car()
        {
            _color = "Purple";
            _GPM = 10;
            fuel = 100;
            _owner = "Bob";
        }

        public double TotalDistance()
        {
            return (double) fuel / _GPM;
        }
        
    }
}