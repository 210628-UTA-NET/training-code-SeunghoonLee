using System;
using System.Collections.Generic;
using RRBL;
using RRModels;

namespace RRUI
{
    public class ShowRestaurantMenu : IMenu
    {
        private IRestaurantBL _restBL;
        public ShowRestaurantMenu(IRestaurantBL p_rest)
        {
            _restBL = p_rest;
        }
        public void Menu()
        {
            Console.WriteLine("List of Restaurant");

            List<Restaurant> restaurants = _restBL.GetAllRestaurant();

            foreach (Restaurant rest in restaurants)
            {
                Console.WriteLine(rest);
            }

            Console.WriteLine("[0] Go Back");
        }

        public MenuType YourChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "0" :
                    return MenuType.RestaurantMenu;
                default :
                    Console.WriteLine("Input was not correct");
                    Console.WriteLine("Press Enter to continure");
                    Console.ReadLine();
                    return MenuType.ShowRestaurantMenu;
            }
        }
    }
}