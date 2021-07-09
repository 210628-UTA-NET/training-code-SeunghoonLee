using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RRBL;
using RRDL;
using RRDL.Entities;

namespace RRUI 
{
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {

            //Get the configuration from our AppSetting.json file
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("AppSetting.json")
                .Build();
            //Grabs our connectionString from our AppSetting.json
            string connectionString = configuration.GetConnectionString("LCGDB");

            DbContextOptions<LCGDBContext> options = new DbContextOptionsBuilder<LCGDBContext>()
                .UseSqlServer(connectionString)
                .Options;

            switch(p_menu)
                {
                    case MenuType.MainMenu :
                        return new MainMenu();
                    case MenuType.RestaurantMenu :
                        return new RestaurantMenu();
                    case MenuType.ShowRestaurantMenu :
                        return new ShowRestaurantMenu(new RestaurantBL(new Repository(new LCGDBContext(options))));
                    case MenuType.AddRestaurantMenu :
                        return new AddRestaurantMenu(new RestaurantBL(new Repository(new LCGDBContext(options))));
                    default :
                        return null;
                }

        }
    }
}