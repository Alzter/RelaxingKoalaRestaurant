﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class MenuItem : ICloneable
    {
        private List<Ingredient> _baseIngredients;
        private List<Ingredient> _addableIngredients;
        private List<Ingredient> _ingredients;
        private double _basePrice;
        private string _name;
        private int _id;

        public MenuItem(string name, double basePrice, List<Ingredient> baseIngredients, List<Ingredient> addableIngredients)
        {
            _addableIngredients = addableIngredients;
            _baseIngredients = baseIngredients;

            _name = name;
            _basePrice = basePrice;

            _ingredients = new List<Ingredient>();
            _ingredients.AddRange(_baseIngredients);
        }

        public MenuItem(string name, double basePrice, List<Ingredient> baseIngredients, List<Ingredient> addableIngredients, List<Ingredient> ingredients)
        {
            _addableIngredients = addableIngredients;
            _baseIngredients = baseIngredients;

            _name = name;
            _basePrice = basePrice;

            _ingredients = ingredients;
        }

        public MenuItem(string name, double basePrice, List<Ingredient> baseIngredients)
        {
            _addableIngredients = new List<Ingredient>();
            _baseIngredients = baseIngredients;

            _name = name;
            _basePrice = basePrice;

            _ingredients = new List<Ingredient>();
            _ingredients.AddRange(_baseIngredients);
        }

        public MenuItem(string name, double basePrice)
        {
            _addableIngredients = new List<Ingredient>();
            _baseIngredients = new List<Ingredient>();

            _name = name;
            _basePrice = basePrice;

            _ingredients = new List<Ingredient>();
            _ingredients.AddRange(_baseIngredients);
        }

        public void AddIngredient(Ingredient item)
        {
            if (!_addableIngredients.Contains(item) && !_baseIngredients.Contains(item)){
                throw new ArgumentException($"Ingredient {item.Name} isn't addable for menu item: {this.Name}.");
            }
            if (_ingredients.Contains(item))
            {
                throw new ArgumentException($"Ingredient {item.Name} is already present for menu item: {this.Name}.");
            }
            _ingredients.Add(item);
        }

        public void RemoveIngredient(int id)
        {
            Ingredient i = Ingredients[id];
            RemoveIngredient(i);
        }

        public void RemoveIngredient(Ingredient item)
        {
            if (!_ingredients.Contains(item))
            {
                throw new ArgumentException($"Ingredient {item.Name} isn't removable for menu item: {this.Name}.");
            }
            _ingredients.Remove(item);
        }

        public Ingredient GetAddableIngredient(int id)
        {
            if (id < 1 || id > AddableIngredients.Count) { throw new IndexOutOfRangeException("Addable ingredient out of range"); }
            return AddableIngredients[id];
        }

        public Ingredient GetIngredient(int id)
        {
            if (id < 1 || id > Ingredients.Count) { throw new IndexOutOfRangeException("Ingredient out of range"); }
            return Ingredients[id];
        }

        // Creates a shallow copy of the menu item.
        public object Clone()
        {
            // We must copy all the ingredients lists so they are unique.
            List<Ingredient> baseIngredients = new List<Ingredient>();
            baseIngredients.AddRange(_baseIngredients);

            List<Ingredient> addableIngredients = new List<Ingredient>();
            addableIngredients.AddRange(_addableIngredients);

            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.AddRange(_ingredients);

            MenuItem newItem = new MenuItem(_name, _basePrice, baseIngredients, addableIngredients, ingredients);
            return newItem;
        }

        public string Name { get { return _name; } }

        public override string ToString() { return Name; }

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
                return _ingredients;

            }
        }
        public List<Ingredient> BaseIngredients
        {
            get
            {
                return _baseIngredients;

            }
        }

        public List<Ingredient> AddableIngredients
        {
            get
            {
                List<Ingredient> extras = new List<Ingredient>();

                // Add all base ingredients which were removed from the item.
                extras.AddRange(_baseIngredients);

                // Add all extra ingredients which have not been added to the item.
                extras.AddRange(_addableIngredients);

                List<Ingredient> itemsToRemove = new List<Ingredient>();

                foreach (Ingredient i in extras)
                {
                    if (_ingredients.Contains(i))
                    {
                        itemsToRemove.Add(i);
                    }
                }

                foreach (Ingredient i in itemsToRemove) { extras.Remove(i); }

                return extras;

            }
        }
    }
}
