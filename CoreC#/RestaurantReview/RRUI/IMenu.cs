namespace RRUI
{
    public enum MenuType
    {
        MainMenu,
        RestaurantMenu,
        ShowRestaurantMenu,
        AddRestaurantMenu,
        Exit
    }
    public interface IMenu
    {
        /// <summary>
        /// Will display the overall menu of the class and the choices you can take in that menu class
        /// </summary>
        void Menu();

        /// <summary>
        /// This method will record the user's choice and change your many based on their input
        /// </summary>
        /// <returns>a value that will dictate what menu to change to</returns>
        MenuType YourChoice();
    }
}