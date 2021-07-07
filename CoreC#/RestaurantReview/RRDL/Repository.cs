using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using RRModels;

namespace RRDL
{
    public class Repository : IRepository
    {
        private const string _filePath = "./../RRDL/Database/Restaurant.json";
        private string _jsonString;

        public Restaurant AddRestaurant(Restaurant p_rest)
        {
            throw new System.NotImplementedException();
        }

        public List<Restaurant> GetAllRestaurant()
        {
            try
            {
                _jsonString = File.ReadAllText(_filePath);
            }
            catch (System.Exception)
            {
                throw new Exception("File path was invalid!");
            }
            
            return JsonSerializer.Deserialize<List<Restaurant>>(_jsonString);

        }

        public Restaurant GetRestaurant(Restaurant p_rest)
        {
            throw new System.NotImplementedException();
        }
    }
}