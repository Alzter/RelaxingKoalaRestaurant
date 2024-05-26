using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class MenuItem
    {
        private List<Ingredient>? _baseIngredients;
        private List<Ingredient>? _addableIngredients;
        private List<Ingredient> _ingredients;
        private double _basePrice;
        private string _name;
        private int _id;

        public MenuItem(string name, double basePrice, List<Ingredient> baseIngredients, List<Ingredient> addableIngredients) : this(name, basePrice, baseIngredients)
        {
            _addableIngredients = addableIngredients;
        }

        public MenuItem(string name, double basePrice, List<Ingredient> baseIngredients) : this(name,basePrice)
        {
            _baseIngredients = baseIngredients;
        }

        public MenuItem(string name, double basePrice)
        {
            _name = name;
            _basePrice = basePrice;

            _ingredients = new List<Ingredient>();
            if (_baseIngredients != null) { _ingredients.AddRange(_baseIngredients); }
        }

        public void AddIngredient(Ingredient item)
        {
            _ingredients.Add(item);
        }

        public void RemoveIngredient(int id)
        {
            _ingredients.RemoveAt(id);
        }

        public void RemoveIngredient(Ingredient item)
        {
            _ingredients.Remove(item);
        }

        public Ingredient GetAddableIngredient(int id)
        {
            if (_addableIngredients == null) { throw new NullReferenceException("No addable ingredients list to reference"); }
            if (id < 1 || id > _addableIngredients.Count) { throw new IndexOutOfRangeException("Addable ingredient out of range"); }
            return _addableIngredients[id];
        }

        public Ingredient GetIngredient(int id)
        {
            if (id < 1 || id > _ingredients.Count) { throw new IndexOutOfRangeException("Ingredient out of range"); }
            return _ingredients[id];
        }

        public string Name { get { return _name; } }

        public double Price
        {
            get
            {
                double price = _basePrice;

                // Add the price of each extra ingredient to the base price.
                foreach (Ingredient i in _ingredients)
                {
                    if (!_baseIngredients.Contains(i))
                    {
                        price += i.Price;
                    }
                }

                return price;
            }
        }

        public List<Ingredient> Ingredients
        {
            get
            {
                return Ingredients;

            }
        }

        public List<Ingredient> AddableIngredients
        {
            get
            {
                return AddableIngredients;

            }
        }
    }
}
