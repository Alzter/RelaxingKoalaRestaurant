using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public abstract class Menu
    {
        private List<MenuItem> items;
        private string name;

        public Menu(List<MenuItem> items, string name)
        {
            this.items = items;
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public List<MenuItem> Items
        {
            get { return items; }
        }
    }
}
