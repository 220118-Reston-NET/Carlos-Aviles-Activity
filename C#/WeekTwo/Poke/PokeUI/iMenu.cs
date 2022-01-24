namespace PokeUI
{
    public interface IMenu
    {
        /// <summary>
        /// Will display the menu and user choices in the terminal
        /// </summary>
        void Display();

        /// <summary>
        /// Will record the user choice.
        /// </summary>
        /// <returns>Return the menu that will change the screen</returns>
        string UserChoice();
    }
}