using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RestaurantSystem;

namespace RestaurantSystem
{
    public static class MenuRepository
    {
        public static List<Menu> LoadMenus(string filePath)
        {
            // Read the JSON file
            var json = File.ReadAllText("MenuData.json");
            // Deserialise the JSON data
            var data = JsonSerializer.Deserialize<JsonMenuData>(json);

            // Create Ingredient objects
            var ingredients = new List<Ingredient>();
            foreach (var ingredientData in data.Ingredients)
            {
                ingredients.Add(new Ingredient(ingredientData.Name, ingredientData.BasePrice));
            }

            // Create TakeawayMenu and DineInMenu objects using the JSON data
            var menus = new List<Menu>();
            foreach (var menuData in data.Menus)
            {
                var menuItems = new List<MenuItem>();
                foreach (var menuItemData in menuData.Items)
                {
                    var addableIngredients = new List<Ingredient>();
                    foreach (var ingredientName in menuItemData.AddableIngredients)
                    {
                        addableIngredients.Add(ingredients.Find(i => i.Name == ingredientName));
                    }

                    var removableIngredients = new List<Ingredient>();
                    foreach (var ingredientName in menuItemData.RemovableIngredients)
                    {
                        removableIngredients.Add(ingredients.Find(i => i.Name == ingredientName));
                    }

                    menuItems.Add(new MenuItem(menuItemData.Name, menuItemData.BasePrice, addableIngredients, removableIngredients));
                }

                Menu menu = new Menu(menuItems, menuData.Name);
                menus.Add(menu);
            }

            return menus;
        }
    }
}
