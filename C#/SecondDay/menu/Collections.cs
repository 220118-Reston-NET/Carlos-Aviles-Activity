using System.Collections;

namespace CollectionFunction
{
    public class Collections
    {
        //Array function
        private int[] _nums = new int[5];

        //Non-Generic collection
        private ArrayList _nonGeneric = new ArrayList();

        //Generic collection

        //List collection
        private List<string> strings = new List<string>();

        //Hashset
        private HashSet<int> nums = new HashSet<int>();

        //Map
        private Dictionary<string, int> directory = new Dictionary<string, int>();

        public void main()
        {
            Console.WriteLine("Collection demo");
            _nums[0] = 3;
            _nums[1] = 10;
            _nums[2] = 4;

            foreach (int num in _nums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Generic collection");
            Console.WriteLine("List");
            strings.Add("first string");
            strings.Add("second string");
            strings.Add("third string");
            
            foreach (string item in strings)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List");
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(1);
            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }

             Console.WriteLine("Maps");
             directory.Add("Carlos", -10);
             directory.Add("Stephen", 10);
             directory.Add("Jonathan", -10);

             Console.WriteLine(directory["Carlos"]);

            Console.WriteLine("Non-Generic collection");
            _nonGeneric.Add(10);
            _nonGeneric.Add(true);
            _nonGeneric.Add(1.20);

            strings[0].ToUpper();
        }
    }
}