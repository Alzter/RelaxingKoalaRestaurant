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
            RepositoryInterface.AddReservation(dt, 90, 12, "Steve MC", 3);
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

            // TABLES
            // Load
            var tables = RepositoryInterface.GetTables();

            // Test
            foreach (var table in tables)
            {
                Console.WriteLine($"Table Number: {table.Number}," +
                                  $"Table Status: {table.Status}");
            }

            // ORDERS
            // Load
            var orders = RepositoryInterface.GetOrders();

            // Test
            foreach (var order in orders)
            {
                Console.WriteLine($"Order ID: {order.ID}");
                Console.WriteLine($"Status: {order.Status}");
                Console.WriteLine($"Creation Time: {order.CreationTime}");
                Console.WriteLine($"Estimated Completion Time: {order.EstimatedCompletionTime}");
                Console.WriteLine($"Completion Time: {(order.CompletionTime != default ? order.CompletionTime.ToString() : "N/A")}");
                Console.WriteLine($"Is Paid: {order.IsPaid}");
                Console.WriteLine($"Address: {(order.Address == null ? "N/A" : order.Address)}");
                Console.WriteLine($"Table Number: {(order.TableNumber == null ? "N/A" : order.TableNumber)}");


                Console.WriteLine("Items:");
                foreach (var item in order.Items)
                {
                    Console.WriteLine($"  - Name: {item.Name}");
                    Console.WriteLine($"    Base Price: {item.Price}");
                    Console.WriteLine("    Base Ingredients:");
                    foreach (var ingredient in item.Ingredients)
                    {
                        Console.WriteLine($"      * {ingredient.Name}");
                    }
                }
                Console.WriteLine();
            
            }

            // Transaction
            // Load
            var transactions = RepositoryInterface.GetTransactions();

            //Test
            foreach (var transaction in transactions)
            {
                Console.WriteLine("Transaction Record:");
                Console.WriteLine($"Order ID: {transaction.OrderID}");
                Console.WriteLine($"Price: {transaction.PriceString}");
                Console.WriteLine($"Date Issued: {transaction.DateString} {transaction.TimeString}");
                Console.WriteLine($"Is Paid: {transaction.IsPaid}");
                Console.WriteLine("Items:");
                foreach (var item in transaction.ItemStringList)
                {
                    Console.WriteLine($"  - Name: {item.Item1}");
                    Console.WriteLine($"    Price: {item.Item2}");
                }
                Console.WriteLine();
            }
            // ------------------------------------------------------------------------------------------

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new UserInterface().StateFactory.RestaurantView);
        }
    }
}