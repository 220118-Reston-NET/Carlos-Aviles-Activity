bool repeat = true;

int macAmnts = 0;
int beyondAmnts = 0;
int bigmac = 5;
int beyondburger = 7;
int balance = 0;
int cash = 60;
bool ordered = false;

while(repeat)
{
    Console.WriteLine();
    Console.WriteLine("Welcome to Mcdonald's");
    Console.WriteLine("Pick an option");
    Console.WriteLine("1) Order a big mac");
    Console.WriteLine("2) Order a beyond burger");
    Console.WriteLine("3) Pay for order");
    Console.WriteLine("4) Exit");
    string option = Console.ReadLine();
    Console.Clear();

    if (option == "1")
    {
        Console.WriteLine("How many would you like to order?");
        int amount = Convert.ToInt32(Console.ReadLine());
        if (amount != 0)
        {
            Console.WriteLine("You have ordered "+ amount +" big mac(s) for $"+ bigmac +" each!");
            macAmnts = macAmnts + amount;
            
            ordered = true;
            balance = balance + (bigmac * amount);
        } else
        {
            Console.WriteLine("You can't order "+ amount +" big macs!");
        }
    } else if (option == "2")
    {
        Console.WriteLine("How many would you like to order?");
        int amount = Convert.ToInt32(Console.ReadLine());
        if (amount != 0)
        {
            Console.WriteLine("You have ordered "+ amount +" beyond burger(s) for $"+ beyondburger +" each!");
            beyondAmnts = beyondAmnts + amount;

            ordered = true;
            balance = balance + (beyondburger * amount);
        } else
        {
            Console.WriteLine("You can't order "+ amount +" beyond burgers!");
        }
    } else if (option == "3")
    {
        if (ordered == false)
        {
            Console.WriteLine("You haven't bought anything!");
        }
        else if (cash <= balance)
        {
            Console.WriteLine("You don't have the cash to make the purchase!");
        } else
        {
            cash = cash - balance;
            Console.WriteLine("You have spent $"+ balance +" for this order.");
            Console.WriteLine("You now have $"+ cash +" left.");
            balance = 0;
            macAmnts = 0;
            beyondAmnts = 0;
        }
    } else if (option == "4")
    {
        Console.WriteLine("Thanks for visiting!");
        repeat = false;
    } else
    {
        Console.WriteLine("Invalid input!");
        Console.ReadLine();
    }
}