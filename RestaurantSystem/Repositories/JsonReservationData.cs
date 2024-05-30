using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestaurantSystem.CRUDO
{
    public class JsonReservationData
    {
        [JsonPropertyName("reservations")]
        public List<JsonReservation> Reservations { get; set; }
    }

    public class JsonReservation
    {
        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; set; }

        [JsonPropertyName("durationMinutes")]
        public int DurationMinutes { get; set; }

        [JsonPropertyName("tableNumber")]
        public int TableNumber { get; set; }

        [JsonPropertyName("customerName")]
        public string CustomerName { get; set; }

        [JsonPropertyName("numberOfGuests")]
        public int NumberOfGuests { get; set; }
    }
}
