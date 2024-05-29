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
    }
}
