using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestaurantSystem.crudo
{
    public class JsonTableData
    {
        [JsonPropertyName("tables")]
        public List<JsonTable> Tables { get; set; }
    }

    public class JsonTable
    {
        [JsonPropertyName("tableNumber")]
        public int TableNumber { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
