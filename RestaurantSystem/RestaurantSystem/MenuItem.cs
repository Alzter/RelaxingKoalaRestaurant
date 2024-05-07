using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class MenuItem : MenuElement
    {
        private float basePrice;
        private List<Ingredient> ingredients;

        public MenuItem(float basePrice, List<Ingredient> ingredients)
        {
            this.basePrice = basePrice;
            this.ingredients = ingredients;
        }

        private List<MenuElement> _items;

        public override float Price
        {
            get { return basePrice; }
        }

        public List<Ingredient> Ingredients { get { return ingredients; } }

        public void AddIngredient(Ingredient item) { ingredients.Add(item); }

        public void RemoveIngredient(Ingredient item) { ingredients.Remove(item); }
        public void RemoveIngredient(int index) { ingredients.RemoveAt(index); }
    }
}
