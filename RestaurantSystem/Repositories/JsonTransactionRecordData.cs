using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestaurantSystem.crudo
{
    public class JsonTransactionData
    {
        [JsonPropertyName("transactionRecords")]
        public List<JsonTransactionRecord> TransactionRecords { get; set; }
    }

    public class JsonTransactionRecord
    {
        [JsonPropertyName("orderID")]
        public int OrderID { get; set; }

        [JsonPropertyName("price")]
        public double Price { get; set; }

        [JsonPropertyName("dateIssued")]
        public DateTime DateIssued { get; set; }

        [JsonPropertyName("isPaid")]
        public bool IsPaid { get; set; }

        [JsonPropertyName("items")]
        public List<JsonTransactionMenuItem> Items { get; set; }
    }

    public class JsonTransactionMenuItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("basePrice")]
        public double BasePrice { get; set; }

        [JsonPropertyName("baseIngredients")]
        public List<string> BaseIngredients { get; set; }
    }
}
