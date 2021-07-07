using System;
using RRModels;
using Xunit;

namespace RRTest
{
    public class RestaurantModelTest
    {
        /// <summary>
        /// This test will check if validation works in Restaurant Model
        /// It will input the right data and see if it persists
        /// </summary>
        [Fact]
        public void CityShouldSetValidData()
        {
            //3 components of unit testing: Arrange, Act, Assert

            //Arrange
                Restaurant testRestaurant = new Restaurant();
                string city = "Peninsula";
            //Act
                testRestaurant.City = city;
            //Assert
                Assert.Equal(city, testRestaurant.City);
        }
    }
}
