using System;
using System.Collections.Generic;
using System.Data;
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

        // Add the menu item to the menu without cloning it.
        public override MenuItem AddItem(MenuItem m)
        {
            if (Items.Contains(m)) throw new DuplicateNameException($"Menu Item {m.Name} already exists in Menu.");
            Items.Add(m);
            return m;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
