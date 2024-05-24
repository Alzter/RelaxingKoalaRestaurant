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

        public void AddItem(MenuItem m)
        {
            _items.Add(m);
        }

        public MenuItem GetItem(int id)
        {
            if (id < 0 || id >= _items.Count)
            {
                throw new IndexOutOfRangeException($"Cannot access MenuItem at index {id}.");
            }
            return _items[id];
        }

        public void RemoveItem(int id)
        {
            if (id < 0 || id >= _items.Count)
            {
                throw new IndexOutOfRangeException($"Cannot access MenuItem at index {id}.");
            }
            _items.RemoveAt(id);
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
