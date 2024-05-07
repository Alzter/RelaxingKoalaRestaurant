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

        public MenuItem(float basePrice)
        {
            this.basePrice = basePrice;
        }

        public override float Price
        {
            get { return basePrice; }
        }
    }
}
