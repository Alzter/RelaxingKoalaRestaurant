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
        public List<JsonMenuItem> Items { get; set; }
    }
}
