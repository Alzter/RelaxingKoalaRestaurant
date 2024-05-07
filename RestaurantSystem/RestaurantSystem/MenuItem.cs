using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class MenuItem : MenuElement
    {
<<<<<<< HEAD
        private float basePrice;

        public MenuItem(float basePrice)
=======
        private List<MenuElement> _items;
        public override float GetPrice()
>>>>>>> 92b23f9f5c946e171289856924db688c6386528f
        {
            this.basePrice = basePrice;
        }

        public override float Price
        {
            get { return basePrice; }
        }
    }
}
