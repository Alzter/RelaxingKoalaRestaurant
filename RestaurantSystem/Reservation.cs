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
        // Customer obj?
        private int _numOfGuests = 0;  // Is there a maximum number of guests allowed for a booking?

        // Readonly? Should we be able to change the booking time after it's been created?
        public DateTime BookingTime
        {
            get { return _bookingTime; }
        }

        // TODO: Needs Customer obj for name and number? 
        public Reservation(DateTime bookingTime, Table table, int numOfGuests)
        {
            _bookingTime = bookingTime;
            _tableReserved = table;
            _numOfGuests = numOfGuests;
        }
    }
}
