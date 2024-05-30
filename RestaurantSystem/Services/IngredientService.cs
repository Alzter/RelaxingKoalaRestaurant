using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Services
{
    public class IngredientService
    {
        public static void AddIngredient(Order o, MenuItem m, Ingredient i)
        {
            RepositoryInterface.AddIngredient(o, m, i);
        }

        public static void RemoveIngredient(Order o, MenuItem m, Ingredient i)
        {
            RepositoryInterface.RemoveIngredient(o, m, i);
        }
    }
}
