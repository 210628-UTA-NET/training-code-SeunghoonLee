using System;
using System.Threading;

namespace RRUI
{
    public class RestaurantMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("Welcome to Restaurant Menu");
            Console.WriteLine("What would you like to do");
            Console.WriteLine("[1] Give list of restaurants");
            Console.WriteLine("[0] Go Back");
        }

        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "0" :
                    return MenuType.MainMenu;
                case "1" :
                    return MenuType.RestaurantMenu;
                default :
                    Console.WriteLine("Input was not correct");
                    Console.WriteLine("Press Enter to continure");
                    Console.ReadLine();
                    return MenuType.RestaurantMenu;
            }
        }
    }
}