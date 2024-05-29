using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class TransactionRecord
    {
        private int _orderID;
        private double _price;
        private DateTime _dateIssued;
        private List<MenuItem> _items;
        private bool _isPaid;

        public TransactionRecord(bool isPaid, int orderID, List<MenuItem> items, DateTime dateIssued)
        {
            _isPaid = isPaid;
            _orderID = orderID;
            _items = items;

            // Set the price to the total price of all menu items.
            _price = 0.0; foreach (MenuItem m in _items) { _price += m.Price; }

            _dateIssued = dateIssued;
        }

        public override string ToString()
        {
            return
                $"Relaxing Koala {(_isPaid ? "Receipt" : "Invoice")}:\n" +
                $"Order ID: {OrderID}\n" +
                $"Date: {DateString}, {TimeString}\n" +
                $"{(_isPaid ? "Paid" : "Owed")}: {PriceString}\n" +
                $"Items:\n{ItemStrings}";
        }

        public double Price { get { return _price; } }
        public int OrderID { get { return _orderID; } }
        public List <MenuItem> Items { get { return _items; } }
        public DateTime DateIssued { get { return _dateIssued; } }

        public string DateString { get { return _dateIssued.ToString("d/MM/yyyy"); } }
        public string TimeString { get { return _dateIssued.ToString("h:mm tt"); } }

        public string PriceString { get { return Price.ToString("C"); } }
        public bool IsPaid { get { return _isPaid; } }

        /// <summary>
        /// Returns each item as a String tuple with the format: name, price
        /// The 'price' string is formatted as a currency, e.g., "$1,234.56"
        /// </summary>
        public List<Tuple<String, String>> ItemStringList
        {
            get
            {
                List<Tuple<String, String>> itemStrings = new List<Tuple<String, String>>();
                foreach (MenuItem m in _items)
                {
                    // Generate a currency string for the price.
                    string stringPrice = m.Price.ToString("C");
                    itemStrings.Add(new Tuple<String, String>( m.Name, stringPrice ));
                }

                return itemStrings;
            }
        }

        public String ItemStrings
        {
            get
            {
                String itemString = "";
                List<Tuple<String, String>> itemStringList = ItemStringList;
                foreach (Tuple<String, String> itemStringTuple in itemStringList){

                    String name = itemStringTuple.Item1;
                    String price = itemStringTuple.Item2;
                    itemString += $"{name}: {price}\n";
                }

                itemString = itemString.TrimEnd('\n');
                return itemString;
            }
        }
    }
}
