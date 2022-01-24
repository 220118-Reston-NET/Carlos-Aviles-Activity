using PokeModel;
using PokeUI;

bool repeat = true;
IMenu menu = new MainMenu();

while(repeat)
{
    Console.Clear();
    menu.Display();
    string answer = menu.UserChoice();
    switch (answer)
    {
        case "MainMenu":
        menu = new MainMenu();
            break;
        case "AddPokemon":
            menu = new AddPokeMenu();
            break;
        case "Exit":
            repeat = false;
            break;
        default:
            Console.WriteLine("Page does not exist!");
            break;
    }
}