using System;

namespace userinterface
{
    public class MainMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Hi there");
            Console.WriteLine("[1]: Create New Account");
            Console.WriteLine("[2]:Exit");
        }


        public MenuType UserChoice()
        {
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    return MenuType. AddCustomer;
                case "2":
                    return MenuType.Exit;
                default:
                    Console.WriteLine("   Please select one of the options from the list provided. " +
                     "\n   Please press enter to Continue");
                    Console.ReadLine();
                    return MenuType.MainMenu;

            }
        }
    }
}