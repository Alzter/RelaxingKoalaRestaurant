using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Receipt : PaymentRecord
    {
        public override Order getOrder => throw new NotImplementedException();
    }
}
