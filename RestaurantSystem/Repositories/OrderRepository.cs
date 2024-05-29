using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using RestaurantSystem.crudo;

namespace RestaurantSystem
{
    public static class OrderRepository
    {
        public static List<Order> LoadItems(string filePath)
        {
            // Read the JSON file
            var json = File.ReadAllText(filePath);

            // Deserialize the JSON data
            var data = JsonSerializer.Deserialize<JsonOrderData>(json);

            // Create Order objects
            var orders = new List<Order>();
            foreach (var orderData in data.Orders)
            {
                var items = new List<MenuItem>();
                foreach (var menuItemData in orderData.Items)
                {
                    var baseIngredients = new List<Ingredient>();
                    foreach (var ingredientName in menuItemData.BaseIngredients)
                    {
                        baseIngredients.Add(new Ingredient(ingredientName));
                    }

                    var menuItem = new MenuItem(menuItemData.Name, menuItemData.BasePrice, baseIngredients);
                    items.Add(menuItem);
                }

                Order order;
                // Have to handle potential null values
                if (orderData.Address != null)
                {
                    order = new Order(items, orderData.ID, orderData.Address, Enum.Parse<OrderStatus>(orderData.Status), orderData.IsPaid, orderData.CreationTime, orderData.CompletionTime ?? default(DateTime));
                }
                else
                {
                    order = new Order(items, orderData.ID, orderData.TableNumber ?? 0, Enum.Parse<OrderStatus>(orderData.Status), orderData.IsPaid, orderData.CreationTime, orderData.CompletionTime ?? default(DateTime));
                }

                order.EstimatedCompletionTime = orderData.EstimatedCompletionTime;

                orders.Add(order);
            }

            return orders;
        }

        public static void SaveItems(string filePath, List<Order> orders)
        {
            // Convert orders to JSON orders
            var jsonOrders = new List<JsonOrder>();

            foreach (var order in orders)
            {
                var jsonMenuItems = new List<JsonOrderMenuItem>();

                foreach (var menuItem in order.Items)
                {
                    var baseIngredients = new List<string>();

                    foreach (var ingredient in menuItem.Ingredients)
                    {
                        baseIngredients.Add(ingredient.Name);
                    }

                    jsonMenuItems.Add(new JsonOrderMenuItem
                    {
                        Name = menuItem.Name,
                        BasePrice = menuItem.Price,
                        BaseIngredients = baseIngredients
                    });
                }

                jsonOrders.Add(new JsonOrder
                {
                    ID = order.ID,
                    Status = order.Status.ToString(),
                    CreationTime = order.CreationTime,
                    EstimatedCompletionTime = order.EstimatedCompletionTime,
                    CompletionTime = order.CompletionTime != default(DateTime) ? (DateTime?)order.CompletionTime : null, // Handle null completion time
                    IsPaid = order.IsPaid,
                    Address = order.Address,
                    TableNumber = order.TableNumber
                });
            }

            // Create JSON object
            var data = new JsonOrderData
            {
                Orders = jsonOrders
            };

            // Serialize 
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            // Write to file
            File.WriteAllText(filePath, json);
        }

        // Create Order Methods
        // Delivery
        public static void CreateOrder(List<MenuItem> menuItems, string address, string customerName)
        {
            var filePath = "OrderData.json"; 
            var orders = LoadItems(filePath); // Load current orders

            int newId = orders.Count > 0 ? orders.Max(o => o.ID) + 1 : 1; // Create a new order ID that is unique (Max ID + 1)
            var newOrder = new Order(menuItems, newId, address, OrderStatus.Waiting, false, DateTime.Now, default); // Create a new order object with passed in data and ID

            // Add new order to the orders list then save the list to the JSON file
            orders.Add(newOrder);
            SaveItems(filePath, orders);
        }

        // Dine-In
        public static void CreateOrder(List<MenuItem> menuItems, int tableNumber)
        {
            var filePath = "OrderData.json";
            var orders = LoadItems(filePath);

            int newId = orders.Count > 0 ? orders.Max(o => o.ID) + 1 : 1;
            var newOrder = new Order(menuItems, newId, tableNumber, OrderStatus.Waiting, false, DateTime.Now, default);

            orders.Add(newOrder);
            SaveItems(filePath, orders);
        }

        // TakeAway
        public static void CreateOrder(List<MenuItem> menuItems, string name)
        {
            var filePath = "OrderData.json";
            var orders = LoadItems(filePath);

            int newId = orders.Count > 0 ? orders.Max(o => o.ID) + 1 : 1;
            var newOrder = new Order(menuItems, newId, OrderStatus.Waiting, false, DateTime.Now, default);

            orders.Add(newOrder);
            SaveItems(filePath, orders);
        }
    }
}
