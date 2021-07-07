using System.Collections.Generic;
using RRModels;

namespace RRBL
{
    /// <summary>
    /// Handles all the business logic for the restaurant model
    /// They are in charge of further processing/sanitizing/further validation of data
    /// Any logic that is used to access the data is for the DL, anything else will be in BL
    /// </summary>
    public interface IRestaurantBL
    {
        /// <summary>
        /// Gets all the restaurant from the database
        /// </summary>
        /// <returns>a list of restaurant</returns>
        List<Restaurant> GetAllRestaurant();
    }
}
