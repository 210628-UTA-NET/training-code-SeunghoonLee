using System.Collections.Generic;
using System.Linq;
using RRDL;
using RRModels;

namespace RRDL
{
    public class Repository : IRepository
    {
        // For JSON repository
        // private const string _filePath = "./../RRDL/Database/Restaurant.json";
        // private string _jsonString;

        // Dependency Injection
        // You don't have to worry about BL
        private Entities.LCGDBContext _context;
        public Repository(Entities.LCGDBContext p_context)
        {
            _context = p_context;
        }
        public Restaurant AddRestaurant(Restaurant p_rest)
        {
            // For JSON repository
            // List<Restaurant> listOfRestaurant = GetAllRestaurant();
            // listOfRestaurant.Add(p_rest);
            // _jsonString = JsonSerializer.Serialize(listOfRestaurant, new JsonSerializerOptions{WriteIndented = true});
            // File.WriteAllText(_filePath, _jsonString);
            // return p_rest;

            //Method Syntax Way

            throw new System.NotImplementedException();
        }

        public List<Restaurant> GetAllRestaurant()
        {
            // For JSON repository
            // try
            // {
            //     _jsonString = File.ReadAllText(_filePath);
            // }
            // catch (System.Exception)
            // {
            //     throw new Exception("File path was invalid!");
            // }
            // return JsonSerializer.Deserialize<List<Restaurant>>(_jsonString);

            //Method Syntax Way
            return _context.Restaurants.Select(
                rest => 
                    new Restaurant()
                    {
                        Id = rest.Id,
                        Name = rest.Name,
                        City = rest.City,
                        State = rest.State
                    }
            ).ToList();
        }

        public Restaurant GetRestaurant(Restaurant p_rest)
        {
            throw new System.NotImplementedException();
        }
    }
}