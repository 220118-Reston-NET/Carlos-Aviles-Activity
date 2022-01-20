namespace ConversionFunction
{
    public class Conversions
    {
        public static int _number;
        public static void main()
        {
            Console.WriteLine("Conversion");
            int x = 10;
            double y = 85.29;
            string str = "Hello";

            //Implicit conversion
            double converted = x;
            Console.WriteLine(converted);
        }
    }
}