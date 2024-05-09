using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RestaurantSystem
{
    public abstract class MenuElement
    {
        private string _name;
        private double _basePrice;

        public MenuElement(string name, double basePrice)
        {
            _name = name;
            _basePrice = basePrice;
        }

        public abstract double Price
        {
            get;
        }

        public double BasePrice
        {
            get { return _basePrice; }
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
