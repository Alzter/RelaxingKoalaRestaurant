using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public abstract class PaymentRecord
    {
        public abstract Order getOrder
        {
            get;
        }       
    }
}
