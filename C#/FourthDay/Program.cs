using DataFunction;
using System;

class Program
{

    /*
     * Represents the Data class instance.
     */
    private Data user = new Data();

    /*
     * The while loop flag.
     */
    private bool repeat = true;

    /*
     * Print the main menu screen.
     */
    void printMainMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to Mcdonald's");
        Console.WriteLine("Pick an option");
        Console.WriteLine("[1] Order a big mac");
        Console.WriteLine("[2] Order a beyond burger");
        Console.WriteLine("[3] Pay for order");
        Console.WriteLine("[4] Remove an order");
        Console.WriteLine("[5] Display cart");
        Console.WriteLine("[6] Exit");
    }

    /*
     * Initialize the console app logic.
     */
    void start()
    {
        // Initialize the data.
        user.init();

        while(repeat)
        {
            printMainMenu();

            int option = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            //Option 1: Order a big mac
            if (option == 1)
            {
                Console.WriteLine("How many would you like to order?");
                int amount = Convert.ToInt32(Console.ReadLine());
                if (amount != 0)
                {
                    Console.WriteLine("You have ordered "+ amount +" big mac(s) for $"+ Data.BIG_MAC_COST +" each!");
                    user.addBigMac(amount);
                } else
                {
                    Console.WriteLine("You can't order "+ amount +" big macs!");
                }

            //option 2: order a beyond burger
            } else if (option == 2)
            {
                Console.WriteLine("How many would you like to order?");
                int amount = Convert.ToInt32(Console.ReadLine());
                if (amount != 0)
                {
                    Console.WriteLine("You have ordered "+ amount +" beyond burger(s) for $"+ Data.BEYOND_COST +" each!");
                    user.addBeyond(amount);
                } else
                {
                    Console.WriteLine("You can't order "+ amount +" beyond burgers!");
                }

            //option 3: pay for order
            } else if (option == 3)
            {
                if (user.hasOrdered(0) == false && user.hasOrdered(1) == false)
                {
                    Console.WriteLine("You haven't ordered anything!");
                }
                else if (user._cash < user._balance)
                {
                    Console.WriteLine("You don't have the cash to make the purchase!");
                } else
                {
                    user._cash = user._cash - user._balance;
                    Console.WriteLine("You have spent $"+ user._balance +" for this order.");
                    Console.WriteLine("You now have $"+ user._cash +" left.");
                    user.saveFile();
                }

            //option 3: Remove an item
            } else if (option == 4)
            {
                if (user.hasOrdered(0) == false && user.hasOrdered(1) == false)
                {
                    Console.WriteLine("You haven't ordered anything!");
                } else
                {
                    user.printCart();
                    Console.WriteLine("Which one would you like to remove?");
                    Console.WriteLine("[1] Remove a Big Mac");
                    Console.WriteLine("[2] Remove a Beyond Burger");
                    Console.WriteLine("[3] Go back to main menu");

                    int pick = Convert.ToInt32(Console.ReadLine());
                    if (pick == 1)
                    {
                        if (user._amountOrdered[0] == 0)
                        {
                            Console.WriteLine("You haven't ordered any Big Macs!");
                        }
                        else
                        {
                            user.removeBigMac();
                        }
                    } else if (pick == 2)
                    {
                        if (user._amountOrdered[1] == 0)
                        {
                            Console.WriteLine("You haven't ordered any Beyond Burgers!");
                        }
                        else
                        {
                            user.removeBeyond();
                        }
                    } else if (pick == 3)
                    {
                        printMainMenu();
                    }
                }
            
            //option 5: Display cart items
            } else if (option == 5)
            {
                user.printCart();
                Console.WriteLine("The total cost is $"+ user.getTotalCost() +"!");
                Console.WriteLine("You have $"+ user._cash +" cash in your wallet.");
            
            //option 6: exit out of program
            } else if (option == 6)
            {
                Console.WriteLine("Thanks for visiting!");
                repeat = false;
                user.saveFile();
                
            //Invalid input command
            } else
            {
                Console.WriteLine("Invalid input!");
                Console.ReadLine();
            }
        }
    }

    static void Main(string[] args)
    {
        new Program().start();   
    }
}