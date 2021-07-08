using System;

namespace RRUI
{
    public class AddRestaurantMenu : IMenu
    {
        public void Menu()
        {
            Console.WriteLine("[4] Name");
            Console.WriteLine("[3] City");
            Console.WriteLine("[2] State");
            Console.WriteLine("[1] Add Restaurant");
            Console.WriteLine("[0] Go back");
        }

        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "0":
                    return MenuType.RestaurantMenu;
                case "1":
                    return MenuType.AddRestaurantMenu;
                case "2":
                     return MenuType.AddRestaurantMenu;
                case "3":
                     return MenuType.AddRestaurantMenu;
                case "4":
                    return MenuType.AddRestaurantMenu;
                default:
                    Console.WriteLine("Input was not correct");
                    Console.WriteLine("Press Enter to continure");
                    Console.ReadLine();
                    return MenuType.AddRestaurantMenu;
            }

        }
    }
}