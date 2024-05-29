using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class MenuItemContainer
    {
        private List<MenuItem> _items;

        public MenuItemContainer(List<MenuItem> items)
        {
            _items = items;
        }

        public MenuItem AddItem(MenuItem m)
        {
            _items.Add(m);

            return m;
        }

        public MenuItem GetItem(int id)
        {
            if (id < 0 || id >= _items.Count)
            {
                throw new IndexOutOfRangeException($"Cannot access MenuItem at index {id}.");
            }
            return _items[id];
        }

        public MenuItem GetItem(string name)
        {
            foreach (MenuItem m in _items)
            {
                if (m.Name == name) return m;
            }
            return null;
        }

        public void RemoveItem(int id)
        {
            MenuItem item = GetItem(id);
            RemoveItem(item);
        }

        public void RemoveItem(MenuItem m)
        {
            _items.Remove(m);
        }

        public List<MenuItem> Items
        {
            get { return _items; }
        }


    }
}
