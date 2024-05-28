using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Receipt : TransactionRecord
    {
        public Receipt(int orderID, double price, DateTime dateIssued) : base(orderID, price, dateIssued)
        {
            throw new NotImplementedException();
        }
    }
}
