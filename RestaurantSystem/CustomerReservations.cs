using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class CustomerReservations
    {
        private static CustomerReservations _instance;

        private CustomerReservations() { }

        public static CustomerReservations Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CustomerReservations();
                }
                return _instance;
            }
        }
    }
}
