using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Order : MenuItemContainer
    {
        private OrderStatus _status;
        private DateTime _creationTime;
        private DateTime _estimatedCompletionTime;
        private DateTime _completionTime;
        private bool isPaid;
        private string? _address;
        private int? _tableNumber;
        private int _id;

        public Order(List<MenuItem> items, int tableNumber) : this(items)
        {
            throw new NotImplementedException();
        }

        public Order(List<MenuItem> items, string address) : this(items)
        {
            throw new NotImplementedException();
        }

        public Order(List<MenuItem> items) : base(items)
        {
            throw new NotImplementedException();
        }

        public void PayForOrder()
        {
            throw new NotImplementedException();
        }

        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public DateTime EstimatedCompletionTime
        {
            get { return _estimatedCompletionTime; }
            set { _estimatedCompletionTime = value; }
        }

        public double Price
        {
            get
            {
                throw new NotImplementedException;
            }
        }

        public string? Address
        {
            get { return _address; }
        }

        public int? TableNumber
        {
            get { return _tableNumber; }
        }

        public int ID { get { return _id; } }
    }
}
