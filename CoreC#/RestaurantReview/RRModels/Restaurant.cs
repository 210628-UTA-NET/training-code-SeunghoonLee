using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RRModels
{
    public class Restaurant
    {
        private string _city;
        public Restaurant()
        {
        }

        public Restaurant(string p_name){
            Name = p_name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { 
            get
            {
                return _city;
            } 
            set
            {
                if (!Regex.IsMatch(value, @"^[A-Za-z .]+$"))
                {
                    throw new Exception("City can only hold letters");
                }
                else
                {
                    _city = value;
                }
            }
        }
        
        public string State { get; set; }

        public List<Review> Reviews { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, City: {City}, State: {State}";
        }
    }
}
