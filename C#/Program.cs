using CarFunction;

Car car1 = new Car();
Console.WriteLine(car1.Color);
car1.Color = "Red";
Console.WriteLine(car1.Color);
Console.WriteLine(car1.fuel);
car1.Start(10);

Car car2 = new Car()
{
    Color = "Red",
    fuel = 120
};
Console.WriteLine(car2.Color);
Console.WriteLine(car2.TotalDistance());

bool repeat = true;

while(repeat)
{
    Console.WriteLine("Welcome to C#");
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
    Console.WriteLine("Hello, "+ name +"!");
    Console.WriteLine("Select an option:");
    Console.WriteLine("1) Add two numbers");
    Console.WriteLine("2) Exit");
    string option = Console.ReadLine();

    if (option == "1")
    {
        Console.WriteLine("Please give me two numbers.");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The answer is {num1 + num2}!");
    } else if (option == "2")
    {
        repeat = false;
    }
}