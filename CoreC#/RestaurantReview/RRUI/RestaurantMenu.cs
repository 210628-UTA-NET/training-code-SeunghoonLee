using System;

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

        public string YourChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1" :
                    return "RestaurantMenu";
                case "0" :
                    return "MainMenu";
                default :
                    return "Unknown";
            }
        }
    }
}