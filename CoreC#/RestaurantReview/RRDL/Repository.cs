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
            List<Restaurant> listOfRestaurant = GetAllRestaurant();
            listOfRestaurant.Add(p_rest);
            _jsonString = JsonSerializer.Serialize(listOfRestaurant, new JsonSerializerOptions{WriteIndented = true});
            File.WriteAllText(_filePath, _jsonString);

            return p_rest;
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