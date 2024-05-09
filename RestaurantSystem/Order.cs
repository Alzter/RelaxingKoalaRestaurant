using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public abstract class Order
    {
        public enum OrderStatus
        {
            Waiting,
            InProgress,
            Ready,
            Served
        }

        private bool _isPaid;
        private List<MenuItem> _items;
        private DateTime _creationTime;
        private DateTime _completionTime;
        private DateTime _estimatedCompletionTime;
        private OrderStatus _status;

        public Order(List<MenuItem> items)
        {
            _items = items;
            _isPaid = false;
            _status = OrderStatus.Waiting;
            _creationTime = DateTime.Now;
        }

        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public List<MenuItem> Items
        {
            get { return _items; }
        }

        public float Price
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsPaid
        {
            get{ return _isPaid; }
        }

        public bool PayForOrder(Receipt receipt)
        {
            // TODO: Verify the legitimacy of the receipt, then set paid for status to true.
            throw new NotImplementedException();

            //if (receipt.isLegit())
            //{
            //    _isPaid = true;
            //    return true;
            //}
            //return false;
        }

        public Invoice GetInvoice()
        {
            throw new NotImplementedException();
        }
    }
}
