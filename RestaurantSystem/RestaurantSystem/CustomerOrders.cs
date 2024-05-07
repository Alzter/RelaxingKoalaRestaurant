using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class CustomerOrders
    {
        private static CustomerOrders _instance;
        
        private CustomerOrders() {}

        public static CustomerOrders Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CustomerOrders();
                }
                return _instance;
            }
        }
    }
}
