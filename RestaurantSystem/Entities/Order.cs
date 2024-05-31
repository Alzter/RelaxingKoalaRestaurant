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
        private DateTime? _completionTime;
        private bool _isPaid;
        private string? _address;
        private int? _tableNumber;
        private int _id;

        public Order(List<MenuItem> items, int id, int tableNumber) : this(items, id)
        {
            _tableNumber = tableNumber;
        }

        public Order(List<MenuItem> items, int id, string address) : this(items, id)
        {
            _address = address;
        }

        public Order(List<MenuItem> items, int id) : base(items)
        {
            _isPaid = false;
            _id = id;
            _creationTime = DateTime.Now;
            _status = OrderStatus.Waiting;
        }

        public Order(List<MenuItem> items, int id, OrderStatus status, bool isPaid, DateTime creationTime, DateTime completionTime) : base(items)
        {
            _id = id;
            _status = status;
            _isPaid = isPaid;
            _creationTime = creationTime;
            _completionTime = completionTime;
        }

        public Order(List<MenuItem> items, int id, string address, OrderStatus status, bool isPaid, DateTime creationTime, DateTime completionTime) : this(items, id, status, isPaid, creationTime, completionTime)
        {
            _address = address;
        }

        public Order(List<MenuItem> items, int id, int tableNumber, OrderStatus status, bool isPaid, DateTime creationTime, DateTime completionTime) : this(items, id, status, isPaid, creationTime, completionTime)
        {
            _tableNumber = tableNumber;
        }

        // Add a shallow copy of the menu item to the Order and return the copy for future reference.
        public override MenuItem AddItem(MenuItem m)
        {
            MenuItem localItem = (MenuItem)m.Clone();
            Items.Add(localItem);

            return localItem;
        }

        public void SetETA(int etaMinutes)
        {
            DateTime eta = _creationTime.AddMinutes(etaMinutes);
            EstimatedCompletionTime = eta;

            // Console.WriteLine($"Setting Order ETA to: {EstimatedCompletionTimeInMinutes.ToString()}");
        }

        public TransactionRecord PayForOrder()
        {
            _isPaid = true;
            TransactionRecord r = new TransactionRecord(true, ID, Items, DateTime.Now);
            return r;
        }
        
        public OrderStatus Status
        {
            get { return _status; }
            set {
                if (value == OrderStatus.Waiting){
                    _estimatedCompletionTime = DateTime.MinValue;
                }

                // Set completion time to now once the order's status is set to 'ready' or 'served'
                if ((value == OrderStatus.Ready || value == OrderStatus.Served) && (_status == OrderStatus.InProgress || _status == OrderStatus.Waiting))
                {
                    _completionTime = DateTime.Now;
                } else if (_completionTime != null && (value == OrderStatus.InProgress || value == OrderStatus.Waiting))
                {
                    _completionTime = null;
                }

                _status = value;
            }
        }

        public DateTime CreationTime { get { return _creationTime; } }

        public DateTime EstimatedCompletionTime
        {
            get { return _estimatedCompletionTime; }
            set { _estimatedCompletionTime = value; }
        }

        public int EstimatedCompletionTimeInMinutes
        {
            get
            {
                if (_estimatedCompletionTime == DateTime.MinValue) return 0;
                return (EstimatedCompletionTime - CreationTime).Minutes;
            }
        }

        public DateTime? CompletionTime { get { return _completionTime == DateTime.MinValue ? null : _completionTime; } set { _completionTime = value; } }

        public String CreationTimeString { get { return _creationTime.ToString("h:mm tt, ddd dd/MM/yy"); } }
        public String EstimatedCompletionTimeString { get { return _estimatedCompletionTime.ToString("h:mm tt, ddd dd/MM/yy"); } }

        public String CompletionTimeString
        {
            get
            {
                if (CompletionTime == null)
                {
                    return "";
                } else
                {
                    return ((DateTime)CompletionTime).ToString("h:mm tt, ddd dd/MM/yy");
                }
            }
        }

        public double Price
        {
            get
            {
                double total = 0;
                foreach (MenuItem i in Items)
                {
                    total += i.Price;
                }
                return total;
            }
        }

        public string? Address
        {
            get {
                //if (_address == null) { throw new NullReferenceException("Order does not have an address."); }
                return _address;
            }
        }

        public int? TableNumber
        {
            get {

                //if (_tableNumber == null) { throw new NullReferenceException("Order does not have a table number."); }
                return _tableNumber;
            }
            set
            {
                _tableNumber = value;
            }
        }

        public int ID { get { return _id; } }

        public bool IsPaid { get { return _isPaid; } }
    }
}
