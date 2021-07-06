using System;
using System.Collections.Generic;
using RRModels;

namespace RRDL
{
    /// <summary>
    /// It is responsible for accessing our database (in this case it will be a JSON file stored in our folder)
    /// </summary>
    public interface IReposityory
    {
        /// <summary>
        /// Gets a list of Restaurants stored in our database 
        /// </summary>
        /// <returns>a list of Restaurants</returns>
        List<Restaurant> GetAllRestaurant();
        
        /// <summary>
        /// It will be a specific Restaurant
        /// </summary>
        /// <param name="p_rest">This restaurant object will be used to check the properties that should match in the database</param>
        /// <returns>the restaurant object from the database</returns>
        Restaurant GetRestaurant(Restaurant p_rest);
        
        /// <summary>
        /// It will add a restaurant in our database
        /// </summary>
        /// <param name="p_rest">This is the restaurant object that will be added to the database</param>
        /// <returns>The restaurant object we just added</returns>
        Restaurant AddRestaurant(Restaurant p_rest);

    }
}
