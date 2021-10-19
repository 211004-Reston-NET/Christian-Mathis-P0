namespace userinterface
{
    public enum MenuType
    {
        MainMenu,
        AddCustomer,
        Exit
    }
    public interface IMenu
    {
        /// <summary>
        /// Display menu of current class, choices user is allowed to make
        /// 
        /// </summary>
        void Menu();
        /// <summary>
        /// Record what User Inputs, will change menu upon choice
        /// </summary>
        /// <returns>Returns a menu enum that user will go to next</returns> 
        MenuType UserChoice();
        
    }
}