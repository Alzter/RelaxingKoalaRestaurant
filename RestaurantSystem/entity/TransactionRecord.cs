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

        public TransactionRecord(int orderID, double price, DateTime dateIssued)
        {
            _orderID = orderID;
            _price = price;
            _dateIssued = dateIssued;

        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public double Price { get { return _price; } }
        public double OrderID { get { return _orderID; } }
        public DateTime DateIssued { get { return _dateIssued; } }
    }
}
