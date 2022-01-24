using PokeModel;

namespace PokeUI
{
    public class AddPokeMenu : IMenu
    {

        private static Pokemon _newPok = new Pokemon();

        public void Display()
        {
            Console.WriteLine("Enter Pokemon Information");
            Console.WriteLine("[1] Name - "+ _newPok.Name);
            Console.WriteLine("[2] Level - "+ _newPok.Level);
            Console.WriteLine("[3] Save");
            Console.WriteLine("[4] Go Back");
        }

        public string UserChoice()
        {
            string input = Console.ReadLine();

            switch(input)
            {
                case "1":
                    Console.WriteLine("Please enter a new name!");
                    _newPok.Name = Console.ReadLine();
                    return "AddPokemon";
                case "2":
                    return "AddPokemon";
                case "3":
                    return "Save";
                case "4":
                    return "MainMenu";
                default:
                    return "AddPokemon";
            }
        }
    }
}