using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Receipt : TransactionRecord
    {
        public Receipt(int orderID, List<MenuItem> items, DateTime dateIssued) : base(orderID, items, dateIssued)
        {
            
        }
        
        public override string ToString()
        {
            return
                $"Relaxing Koala Receipt:\n" +
                $"Order ID: {OrderID}\n" +
                $"Date: {DateString}, {TimeString}\n" +
                $"Paid: {PriceString}\n" +
                $"Items:\n{ItemStrings}";
        }
    }
}
