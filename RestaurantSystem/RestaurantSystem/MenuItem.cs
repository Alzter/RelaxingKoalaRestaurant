using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class MenuItem : MenuElement
    {
        private List<MenuElement> _items;
        public override float GetPrice()
        {
            throw new NotImplementedException();
        }
    }
}
