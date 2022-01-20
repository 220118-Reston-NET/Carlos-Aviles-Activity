using DataFunction;
using System;

class Program
{

    private Data user = new Data();

    private bool repeat = true;

    void start()
    {
        user.init();

        while(repeat)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Mcdonald's");
            Console.WriteLine("Pick an option");
            Console.WriteLine("[1] Order a big mac");
            Console.WriteLine("[2] Order a beyond burger");
            Console.WriteLine("[3] Pay for order");
            Console.WriteLine("[4] Remove an order");
            Console.WriteLine("[5] Exit");

            int option = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (option == 1)
            {
                Console.WriteLine("How many would you like to order?");
                int amount = Convert.ToInt32(Console.ReadLine());
                if (amount != 0)
                {
                    Console.WriteLine("You have ordered "+ amount +" big mac(s) for $"+ Data.BIG_MAC_COST +" each!");
                    user._amountOrdered[0] = user._amountOrdered[0] + amount;
                    user._ordered = true;

                    user._balance = user._balance + (Data.BIG_MAC_COST * amount);
                } else
                {
                    Console.WriteLine("You can't order "+ amount +" big macs!");
                }
            } else if (option == 2)
            {
                Console.WriteLine("How many would you like to order?");
                int amount = Convert.ToInt32(Console.ReadLine());
                if (amount != 0)
                {
                    Console.WriteLine("You have ordered "+ amount +" beyond burger(s) for $"+ Data.BEYOND_COST +" each!");
                    user._amountOrdered[1] = user._amountOrdered[1] + amount;
                    user._ordered = true;

                    user._balance = user._balance + (Data.BIG_MAC_COST * amount);
                } else
                {
                    Console.WriteLine("You can't order "+ amount +" beyond burgers!");
                }
            } else if (option == 3)
            {
                if (user._ordered == false)
                {
                    Console.WriteLine("You haven't ordered anything!");
                }
                else if (user._cash <= user._balance)
                {
                    Console.WriteLine("You don't have the cash to make the purchase!");
                } else
                {
                    user._cash = user._cash - user._balance;
                    Console.WriteLine("You have spent $"+ user._balance +" for this order.");
                    Console.WriteLine("You now have $"+ user._cash +" left.");
                    user.reset();
                }
            }else if (option == 4)
            {
                if (user._ordered == false)
                {
                    Console.WriteLine("You haven't ordered anything!");
                } else
                {
                    Console.WriteLine("You have ordered "+ user._amountOrdered[0] +" Big Mac(s)");
                    Console.WriteLine("You have ordered "+ user._amountOrdered[1] +" Beyond Burger(s)");
                    Console.WriteLine();
                    Console.WriteLine("Which one would you like to remove?");
                    Console.WriteLine("[1] Remove a Big Mac");
                    Console.WriteLine("[2] Remove a Beyond Burger");

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
                    }
                }
            } else if (option == 5)
            {
                Console.WriteLine("Thanks for visiting!");
                repeat = false;
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