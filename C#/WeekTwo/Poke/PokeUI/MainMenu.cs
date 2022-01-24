namespace PokeUI
{
    public class MainMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Welcome to Pokemon!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[1] Add pokemon to your team");
            Console.WriteLine("[2] Exit");
            
        }

        public string UserChoice()
        {
            string input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    return "AddPokemon";
                case "2":
                    return "Exit";
                default:
                    Console.WriteLine("Please input a valid response!");
                    Console.ReadLine();
                    return "";
            }
        }
    }
}