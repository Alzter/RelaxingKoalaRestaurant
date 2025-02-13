﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace RestaurantSystem.CRUDO
{
    public static class OrderRepository
    {
        public static List<Order> LoadItems(string filePath)
        {
            try
            {

                File.SetAttributes(filePath, FileAttributes.Normal); // Make file writeable if it is read-only.

                // Read the JSON file
                var json = File.ReadAllText(filePath);

                // Deserialize the JSON data
                var data = JsonSerializer.Deserialize<JsonOrderData>(json);

                // Check for null data
                if (data == null || data.Orders == null)
                {
                    throw new NullReferenceException("Deserialized data is null.");
                }

                // Create Order objects
                var orders = new List<Order>();
                foreach (var orderData in data.Orders)
                {
                    if (orderData == null)
                    {
                        Console.WriteLine("Order data is null."); // debug
                        continue;
                    }

                    var items = new List<MenuItem>();
                    if (orderData.Items != null)
                    {
                        foreach (var menuItemData in orderData.Items)
                        {
                            if (menuItemData == null)
                            {
                                Console.WriteLine("Menu item data is null."); //debug
                                continue;
                            }

                            var baseIngredients = new List<Ingredient>();
                            foreach (var ingredientName in menuItemData.BaseIngredients)
                            {
                                baseIngredients.Add(new Ingredient(ingredientName));
                            }

                            var menuItem = new MenuItem(menuItemData.Name, menuItemData.BasePrice, baseIngredients);
                            items.Add(menuItem);
                        }
                    }

                    Order order;
                    // Handle potential null values
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
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading items: {ex.Message}"); // debug
                throw;
            }
        }

        public static void SaveItems(string filePath, List<Order> orders)
        {
            try
            {
                File.SetAttributes(filePath, FileAttributes.Normal); // Make file writeable if it is read-only.

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
                        TableNumber = order.TableNumber,
                        Items = jsonMenuItems
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
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving items: {ex.Message}"); // debug
                throw;
            }
        }

        // Create Order Methods
        // Delivery
        public static Order CreateOrder(List<MenuItem> menuItems, string address)
        {
            var filePath = "OrderData.json"; 
            var orders = LoadItems(filePath); // Load current orders

            int newId = orders.Count > 0 ? orders.Max(o => o.ID) + 1 : 1; // Create a new order ID that is unique (Max ID + 1)
            var newOrder = new Order(menuItems, newId, address); // Create a new order object with passed in data and ID

            return newOrder;
        }

        // Dine-In
        public static Order CreateOrder(List<MenuItem> menuItems, int tableNumber)
        {
            var filePath = "OrderData.json";
            var orders = LoadItems(filePath);

            int newId = orders.Count > 0 ? orders.Max(o => o.ID) + 1 : 1;
            var newOrder = new Order(menuItems, newId, tableNumber);

            return newOrder;
        }

        // TakeAway
        public static Order CreateOrder(List<MenuItem> menuItems)
        {
            var filePath = "OrderData.json";
            var orders = LoadItems(filePath);

            int newId = orders.Count > 0 ? orders.Max(o => o.ID) + 1 : 1;
            var newOrder = new Order(menuItems, newId);

            return newOrder;
        }

        public static void AddOrder(Order order)
        {
            var filePath = "OrderData.json";
            var orders = LoadItems(filePath);
            orders.Add(order);
            SaveItems(filePath, orders);
        }

        public static void RemoveOrder(Order o)
        {

            var filePath = "OrderData.json";
            var orders = LoadItems(filePath);

            int orderIndex = orders.FindIndex((Order order) => { return order.ID == o.ID; });

            if (orderIndex == -1 || orderIndex == null) { throw new NullReferenceException($"Order with ID: {o.ID} was not found in orders repository."); }

            orders.RemoveAt(orderIndex);

            SaveItems(filePath, orders);
        }
    }
}
