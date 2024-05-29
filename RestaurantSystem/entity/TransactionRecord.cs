using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public abstract class TransactionRecord
    {
        private int _orderID;
        private double _price;
        private DateTime _dateIssued;
        private List<MenuItem> _items;

        public TransactionRecord(int orderID, List<MenuItem> items, DateTime dateIssued)
        {
            _orderID = orderID;
            _items = items;

            // Set the price to the total price of all menu items.
            _price = 0.0; foreach (MenuItem m in _items) { _price += m.Price; }

            _dateIssued = dateIssued;
        }

        //public override string ToString()
        //{
        //    throw new NotImplementedException();
        //}

        public double Price { get { return _price; } }
        public double OrderID { get { return _orderID; } }
        public DateTime DateIssued { get { return _dateIssued; } }
    }
}
