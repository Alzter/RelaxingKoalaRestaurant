using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Invoice : TransactionRecord
    {
        public Invoice(int orderID, List<MenuItem> items, DateTime dateIssued) : base(orderID, items, dateIssued)
        {

        }
        public override string ToString()
        {
            return
                $"Relaxing Koala Invoice:\n" +
                $"Order ID: {OrderID}\n" +
                $"Date: {DateString}, {TimeString}\n" +
                $"Owed: {PriceString}\n" +
                $"Items:\n{ItemStrings}";
        }
    }
}
