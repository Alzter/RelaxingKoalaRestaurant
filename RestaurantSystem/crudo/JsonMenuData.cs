using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace RestaurantSystem.crudo
{
    public class JsonMenuData
    {
        [JsonPropertyName("ingredients")]
        public List<JsonIngredient> Ingredients { get; set; }

        [JsonPropertyName("menus")]
        public List<JsonMenu> Menus { get; set; }
    }

    public class JsonIngredient
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("basePrice")]
        public double BasePrice { get; set; }
    }

    public class JsonMenu
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("items")]
        public List<JsonMenuItem> Items { get; set; }
    }

    public class JsonMenuItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("basePrice")]
        public double BasePrice { get; set; }

        [JsonPropertyName("addableIngredients")]
        public List<string> AddableIngredients { get; set; }

        [JsonPropertyName("removableIngredients")]
        public List<string> RemovableIngredients { get; set; }
    }
}
