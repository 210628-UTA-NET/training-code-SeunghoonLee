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

        /// <summary>
        /// The test will check if the validation works in Restaurant Model
        /// I will purposely put information that will be wrong and should throw an exception
        /// </summary>
        /// <param name = "input">This is the input that our test case will check in Act</param> 
        [Theory]
        [InlineData("Peninsula1234")]
        [InlineData("0123Peninsula")]
        public void CityShouldNotSetInvalidData(string input)
        {
            //Arrange
            Restaurant testRestaurant = new Restaurant();
            string city = input;
            //Act
            Assert.Throws<Exception>(() => testRestaurant.City = city);
  
        }
    }
}
