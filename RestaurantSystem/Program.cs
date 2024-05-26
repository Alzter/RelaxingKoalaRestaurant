using System.Text.Json;
using System.Text.Json.Serialization;

namespace RestaurantSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Loading JSON data for menus, menu items, and ingredients
            var menus = MenuRepository.LoadMenus("MenuData.json");
            // Testing saved menus
            MenuRepository.SaveMenus("MenuData.json", menus);
            var menus2 = MenuRepository.LoadMenus("MenuData.json");

            // Testing if it worked
            foreach (var menu in menus2)
            {
                Console.WriteLine($"{menu.Name}:");
                foreach (var item in menu.Items)
                {
                    Console.WriteLine($"  {item.Name}: ${item.Price}");
                }
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new UserInterface().StateFactory.RestaurantService);
        }
    }
}