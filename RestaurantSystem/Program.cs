using System.Text.Json;
using System.Text.Json.Serialization;

namespace RestaurantSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // JSON data stuff

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
                if (menuData.Name.Contains("Takeaway"))
                {
                    menu = new TakeAwayMenu(menuItems, menuData.Name);
                }
                else
                {
                    menu = new TakeAwayMenu(menuItems, menuData.Name);
                }
                menus.Add(menu);
            }

            // Testing if it worked
            foreach (var menu in menus)
            {
                Console.WriteLine($"{menu.Name}:");
                foreach (var item in menu.Items)
                {
                    Console.WriteLine($"  {item.Name}: ${item.Price}");
                }
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TestInterface());
        }
    }
}