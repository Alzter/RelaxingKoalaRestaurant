using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class PaymentService
    {
        private List<Receipt> _receipts;

        public PaymentService() { }

        public Receipt PayForOrder(Order o)
        {
            // Call on CRUDO layer to retrieve order specified
            // Call on CRUDO layer to create Receipt using order
            throw new NotImplementedException();
        }
    }
}
