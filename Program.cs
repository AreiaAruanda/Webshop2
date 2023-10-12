using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates object of MainMenu from other file
            MainMenu mainMenu = new MainMenu();
            // Calls on main menu
            mainMenu.mainMenu();
        }
    }
}
