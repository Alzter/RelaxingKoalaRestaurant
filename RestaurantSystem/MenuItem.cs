﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class MenuItem : MenuElement
    {
        private string _name;
        private List<Ingredient> _ingredients;
        private List<Ingredient> _removableIngredients;
        private List<Ingredient> _addableIngredients;
        private List<Ingredient> _extraIngredients;

        // Create menu item without addable or removable ingredients.
        public MenuItem(string name, double basePrice) : base(name, basePrice)
        {
            _removableIngredients = new List<Ingredient>();
            _ingredients = new List<Ingredient>();
            _extraIngredients = new List<Ingredient>();
            _addableIngredients = new List<Ingredient>();
        }

        // Create menu item with addable and removable ingredients.
        public MenuItem(string name, double basePrice, List<Ingredient> addableIngredients, List<Ingredient> removableIngredients) : base(name, basePrice)
        {
            _removableIngredients = removableIngredients;
            _ingredients = removableIngredients;
            _addableIngredients = addableIngredients;
            _extraIngredients = new List<Ingredient>();
        }

        private List<MenuElement> _items;

        public override double Price
        {
            get
            {
                double _extraPrice = 0;

                foreach (Ingredient i in _extraIngredients)
                {
                    _extraPrice += i.Price;
                }

                return BasePrice + _extraPrice;
            }
        }

        public void RemoveIngredient(Ingredient item)
        {
            if (_removableIngredients.Contains(item))
            {
                _ingredients.Remove(item);
            }
            else
            {
                throw new Exception($"Ingredient {item.Name} could not be removed because it is not in the list of removable ingredients.");
            }
        }

        public void AddIngredient(Ingredient item)
        {
            if (_addableIngredients.Contains(item))
            {
                _extraIngredients.Add(item);
            }
            else
            {
                throw new Exception($"Ingredient {item.Name} could not be added because it is not in the list of addable ingredients.");
            }
        }

        public List<Ingredient> Ingredients
        {
            get {

                // TODO: Have Ingredients return a list containing all base ingredients AND all extra ingredients of the menu item.
                throw new NotImplementedException();
                
            }
        }

        //public List<Ingredient> Ingredients { get { return _ingredients; } }

        //public void AddIngredient(Ingredient item) { _ingredients.Add(item); }

        //public void RemoveIngredient(Ingredient item) { _ingredients.Remove(item); }
        //public void RemoveIngredient(int index) { _ingredients.RemoveAt(index); }
    }
}
