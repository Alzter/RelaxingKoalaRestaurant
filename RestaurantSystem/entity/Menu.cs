using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Menu : MenuItemContainer
    {
        private string _name;

        public Menu(List<MenuItem> items, string name) : base(items)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

    }
}
