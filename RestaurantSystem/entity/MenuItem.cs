using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class MenuItem
    {
        private List<Ingredient> _baseIngredients;
        private List<Ingredient>? _addableIngredients;
        private List<Ingredient> ingredients;
        private double _basePrice;
        private string _name;
        private int _id;

        public MenuItem(string name, double basePrice, List<Ingredient> baseIngredients, List<Ingredient> addableIngredients) : this(name, basePrice, baseIngredients)
        {
            throw new NotImplementedException();
        }

        public MenuItem(string name, double basePrice, List<Ingredient> baseIngredients)
        {
            throw new NotImplementedException();
        }

        public void AddIngredient(Ingredient item)
        {
            throw new NotImplementedException();
        }

        public void RemoveIngredient(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveIngredient(Ingredient item)
        {
            throw new NotImplementedException();
        }

        public Ingredient GetAddableIngredient(int id)
        {
            throw new NotImplementedException();
        }

        public Ingredient GetIngredient(int id)
        {
            throw new NotImplementedException();
        }

        public string Name { get { return _name; } }

        public double Price
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public List<Ingredient> Ingredients
        {
            get
            {
                throw new NotImplementedException();

            }
        }

        public List<Ingredient> AddableIngredients
        {
            get
            {
                throw new NotImplementedException();

            }
        }
    }
}
