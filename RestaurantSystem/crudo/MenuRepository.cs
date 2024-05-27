using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RestaurantSystem;

namespace RestaurantSystem
{
    public class MenuRepository
    {
        public List<Menu> LoadMenus(string filePath)
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

                Menu menu;
                menu = new Menu(menuItems, menuData.Name);
                menus.Add(menu);
            }

            return menus;
        }

        public void SaveMenus(string filePath, List<Menu> menus)
        {
            var ingredientsSet = new HashSet<Ingredient>();
            var jsonIngredients = new List<JsonIngredient>();

            foreach (var menu in menus)
            {
                foreach (var menuItem in menu.Items)
                {
                    foreach (var ingredient in menuItem.Ingredients)
                    {
                        if (ingredientsSet.Add(ingredient))
                        {
                            jsonIngredients.Add(new JsonIngredient { Name = ingredient.Name, BasePrice = ingredient.Price });
                        }
                    }

                    foreach (var ingredient in menuItem.AddableIngredients)
                    {
                        if (ingredientsSet.Add(ingredient))
                        {
                            jsonIngredients.Add(new JsonIngredient { Name = ingredient.Name, BasePrice = ingredient.Price });
                        }
                    }
                }
            }

            var jsonMenus = new List<JsonMenu>();

            foreach (var menu in menus)
            {
                var jsonMenuItems = new List<JsonMenuItem>();

                foreach (var menuItem in menu.Items)
                {
                    var addableIngredients = new List<string>();
                    var removableIngredients = new List<string>();

                    foreach (var ingredient in menuItem.AddableIngredients)
                    {
                        addableIngredients.Add(ingredient.Name);
                    }

                    foreach (var ingredient in menuItem.Ingredients)
                    {
                        removableIngredients.Add(ingredient.Name);
                    }

                    jsonMenuItems.Add(new JsonMenuItem
                    {
                        Name = menuItem.Name,
                        BasePrice = menuItem.Price,
                        AddableIngredients = addableIngredients,
                        RemovableIngredients = removableIngredients
                    });
                }

                jsonMenus.Add(new JsonMenu
                {
                    Name = menu.Name,
                    Items = jsonMenuItems
                });
            }

            var data = new JsonMenuData
            {
                Ingredients = jsonIngredients,
                Menus = jsonMenus
            };

            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

    }
}

