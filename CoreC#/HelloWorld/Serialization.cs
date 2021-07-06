using System;
using System.IO;
using System.Text.Json;
using HouseFunction;

namespace HelloWorld
{
    public class Serialization
    {
        private const string _filePath = "./StoreFile/House.json";
        public static void SerializtionMain()
        {
            Console.WriteLine("Serialization Demo");
            //Create House object to be serialized
            House house1 = new House()
            {
                Name = "Seunghoon",
                Price = 500
            };
            house1.setColor("Red");

            //Declare a string var and point it to the serialized version of house1
            string jsonString = JsonSerializer.Serialize(house1, new JsonSerializerOptions {WriteIndented = true});

            Console.WriteLine(jsonString);

            File.WriteAllText(_filePath, jsonString);

            //Deserialization 
            try
            {
                jsonString = File.ReadAllText(_filePath);
                House house2 = JsonSerializer.Deserialize<House>(jsonString);
                Console.WriteLine(house2);
            }
            catch (System.Exception)
            {
                
                Console.WriteLine("The file used to store your information is corrupt");
            }
        }
    }
}