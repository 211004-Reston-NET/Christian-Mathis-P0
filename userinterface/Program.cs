using System;

namespace userinterface
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            IMenu page = new MainMenu();
            while(running) 
            {
            Console.Clear();
            page.Menu();
         MenuType userInput = page.UserChoice();
         switch (userInput )
         {
             case MenuType.MainMenu:
             page = new MainMenu();
             break;
              case MenuType.AddCustomer:
             page = new AddCustomer();
             break;
             case MenuType.Exit:
             running = false;
             break;

             
             default:
              page = new MainMenu();
             break;
         }
            }
        }
    }
}
