using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestaurantSystem.crudo
{
    public class JsonTransactionRecordData
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
    }
}
