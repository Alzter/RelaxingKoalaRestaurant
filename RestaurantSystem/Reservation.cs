using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Reservation
    {
        private DateTime _bookingTime;
        private Table _tableReserved;
        // Customer?
        // Number of guests?

        public Reservation(DateTime bookingTime)
        {
            _bookingTime = bookingTime;
            _tableReserved = null; // Will work out how table is assigned later
        }

        public void ReserveTable(Table table)
        {
            _tableReserved = table;
        }
    }
}
