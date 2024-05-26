using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.crudo
{
    public abstract class Repository<T>
    {
        private readonly List<T> _items = new List<T>();

        public T Get(int id)
        {
            if (id < 1 || id > _items.Count) { throw new IndexOutOfRangeException("Error getting object - index out of range"); }
            return _items[id];
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public void Remove(int id)
        {
            if (id < 1 || id > _items.Count) { throw new IndexOutOfRangeException("Error getting object - index out of range"); }
            _items.RemoveAt(id);
        }

        public List<T> Items { get { return _items; } }
    }
}
