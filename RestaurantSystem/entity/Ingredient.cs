using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Ingredient
    {
        private string _name;
        private double _extraPrice;
        private int _id;

        public Ingredient(string name, double extraPrice)
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get { return _name; }
        }

        public double Price
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
