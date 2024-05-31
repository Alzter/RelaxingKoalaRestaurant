using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace RestaurantSystem.CRUDO
{
    public static class TableRepository
    {
        public static List<Table> LoadItems(string filePath)
        {
            File.SetAttributes(filePath, FileAttributes.Normal); // Make file writeable if it is read-only.
            // Read the JSON file
            var json = File.ReadAllText(filePath);

            // Deserialize the JSON data
            var data = JsonSerializer.Deserialize<JsonTableData>(json);

            // Create Table objects
            var tables = new List<Table>();
            foreach (var tableData in data.Tables)
            {
                var status = Enum.Parse<TableStatus>(tableData.Status);
                var table = new Table(tableData.TableNumber, status);
                tables.Add(table);
            }

            return tables;
        }

        public static void SaveItems(string filePath, List<Table> tables)
        {

            File.SetAttributes(filePath, FileAttributes.Normal); // Make file writeable if it is read-only.

            // Convert tables to JSON
            var jsonTables = new List<JsonTable>();

            foreach (var table in tables)
            {
                jsonTables.Add(new JsonTable
                {
                    TableNumber = table.Number,
                    Status = table.Status.ToString()
                });
            }
            // Wrap in JSON object
            var data = new JsonTableData
            {
                Tables = jsonTables
            };

            // Serialize the table data
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            // Write to the file
            File.WriteAllText(filePath, json);
        }
    }
}
