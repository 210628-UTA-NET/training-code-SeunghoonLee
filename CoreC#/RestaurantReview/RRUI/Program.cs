﻿using System;
using System.Threading;
using RRBL;
using RRDL;

namespace RRUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu restMenu = new MainMenu();
            bool repeat = true;
            MenuType currentMenu = MenuType.MainMenu;
            IFactory menuFactory = new MenuFactory();

            while(repeat)
            {
                Console.Clear();
                restMenu.Menu();
                currentMenu = restMenu.YourChoice();

                switch(currentMenu)
                {
                    case MenuType.MainMenu :
                        restMenu = menuFactory.GetMenu(MenuType.MainMenu);
                        break;
                    case MenuType.RestaurantMenu :
                        restMenu = menuFactory.GetMenu(MenuType.RestaurantMenu);
                        break;
                    case MenuType.ShowRestaurantMenu :
                        restMenu = menuFactory.GetMenu(MenuType.ShowRestaurantMenu);
                        break;
                    case MenuType.Exit :
                        repeat = false;
                        break;
                    default :
                        Console.WriteLine("Cannot process what you want please try again");
                        Thread.Sleep(1000);
                        break;
                }

            }
        }
    }
}
