using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using RestaurantSystem.crudo;

namespace RestaurantSystem
{
    public static class TransactionRepository
    {
        public static List<TransactionRecord> LoadItems(string filePath)
        {
            // Read the JSON file
            var json = File.ReadAllText(filePath);

            // Deserialize the JSON data
            var data = JsonSerializer.Deserialize<JsonTransactionData>(json);

            // Create TransactionRecord objects
            var transactions = new List<TransactionRecord>();
            foreach (var recordData in data.TransactionRecords)
            {
                var items = new List<MenuItem>();
                foreach (var menuItemData in recordData.Items)
                {
                    var baseIngredients = new List<Ingredient>();
                    foreach (var ingredientName in menuItemData.BaseIngredients)
                    {
                        baseIngredients.Add(new Ingredient(ingredientName));
                    }

                    var menuItem = new MenuItem(menuItemData.Name, menuItemData.BasePrice, baseIngredients);
                    items.Add(menuItem);
                }

                var transactionRecord = new TransactionRecord(recordData.IsPaid, recordData.OrderID, items, recordData.DateIssued);
                transactions.Add(transactionRecord);
            }

            return transactions;
        }

        public static void SaveItems(string filePath, List<TransactionRecord> transactions)
        {
            // Convert transactions to JSON transaction records
            var jsonRecords = new List<JsonTransactionRecord>();

            foreach (var transaction in transactions)
            {
                var jsonMenuItems = new List<JsonTransactionMenuItem>();

                foreach (var menuItem in transaction.Items)
                {
                    var baseIngredients = new List<string>();

                    foreach (var ingredient in menuItem.Ingredients)
                    {
                        baseIngredients.Add(ingredient.Name);
                    }

                    jsonMenuItems.Add(new JsonTransactionMenuItem
                    {
                        Name = menuItem.Name,
                        BasePrice = menuItem.Price,
                        BaseIngredients = baseIngredients
                    });
                }

                jsonRecords.Add(new JsonTransactionRecord
                {
                    OrderID = transaction.OrderID,
                    Price = transaction.Price,
                    DateIssued = transaction.DateIssued,
                    IsPaid = transaction.IsPaid,
                    Items = jsonMenuItems
                });
            }

            // Create JSON object
            var data = new JsonTransactionData
            {
                TransactionRecords = jsonRecords
            };

            // Serialize 
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            // Write to file
            File.WriteAllText(filePath, json);
        }

        // Add a transaction record
        public static void AddTransactionRecord(string filePath, TransactionRecord newRecord)
        {
            // Load the current transaction data
            var transactions = LoadItems(filePath);

            // Add the record
            transactions.Add(newRecord);

            // Save the new transaction list
            SaveItems(filePath, transactions);
        }
    }
}
