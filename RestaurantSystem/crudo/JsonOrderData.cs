using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestaurantSystem.crudo
{
    public class JsonOrderData
    {
        [JsonPropertyName("orders")]
        public List<JsonOrder> Orders { get; set; }
    }

    public class JsonOrder
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("creationTime")]
        public DateTime CreationTime { get; set; }

        [JsonPropertyName("estimatedCompletionTime")]
        public DateTime EstimatedCompletionTime { get; set; }

        [JsonPropertyName("completionTime")]
        public DateTime? CompletionTime { get; set; }

        [JsonPropertyName("isPaid")]
        public bool IsPaid { get; set; }

        [JsonPropertyName("address")]
        public string? Address { get; set; }

        [JsonPropertyName("tableNumber")]
        public int? TableNumber { get; set; }

        [JsonPropertyName("items")]
        public List<JsonOrderMenuItem> Items { get; set; }
    }

    public class JsonOrderMenuItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("basePrice")]
        public double BasePrice { get; set; }

        [JsonPropertyName("baseIngredients")]
        public List<string> BaseIngredients { get; set; }
    }
}
