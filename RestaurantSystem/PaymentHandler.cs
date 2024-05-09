using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class PaymentHandler
    {
        private static PaymentHandler _instance;

        private PaymentHandler() { }

        public static PaymentHandler Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PaymentHandler();
                }
                return _instance;
            }
        }
    }
}
