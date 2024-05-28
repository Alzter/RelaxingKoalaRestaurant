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
            // ------------------------------------------------------------------------------------------
            // TESTING REPOSITORIES - WILL DELETE LATER

            // MENUS
            // Load
            var menus = RepositoryInterface.GetMenus();
            // Save
            RepositoryInterface.SaveMenus(menus);
            // Reload (check save worked)
            var menus2 = RepositoryInterface.GetMenus();

            // Test
            foreach (var menu in menus2)
            {
                Console.WriteLine($"{menu.Name}:");
                foreach (var item in menu.Items)
                {
                    Console.WriteLine($"  {item.Name}: ${item.Price}");
                }
            }

            // RESERVATIONS
            // Create
            DateTime dt = new DateTime(2024, 05, 30, 18, 30, 00);
            RepositoryInterface.CreateReservation(dt, 90, 12, "Steve MC", 3);
            // Load
            var reservations = RepositoryInterface.GetReservations();
 
            // Test
            foreach (var reservation in reservations)
            {
                Console.WriteLine($"Customer Name: {reservation.CustomerName}, " +
                                  $"Start Time: {reservation.StartTime}, " +
                                  $"End Time: {reservation.EndTime}, " +
                                  $"Table Number: {reservation.TableNumber}, " +
                                  $"Guests: {reservation.NumberOfGuests}");
            }
            // ------------------------------------------------------------------------------------------

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new UserInterface().StateFactory.RestaurantView);
        }
    }
}