using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Ingredient : MenuElement
    {
        public Ingredient(string name, double basePrice) : base(name, basePrice) { }

        public override double Price
        {
            get
            {
                return BasePrice;
            }
        }
    }
}
