using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Reservation
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private int _tableNumber;
        private string _customerName;
        private int _numberOfGuests;

        public Reservation(DateTime startTime, int durationMinutes, int tableNumber, string customerName, int numberOfGuests)
        {
            _startTime = startTime;
            _endTime = startTime.AddMinutes(durationMinutes);
            _tableNumber = tableNumber;
            _customerName = customerName;
            _numberOfGuests = numberOfGuests;
        }

        public DateTime StartTime { get { return _startTime; } }
        public DateTime EndTime { get { return _endTime; } }
        public int DurationMinutes
        {
            get
            {
                TimeSpan diff = (_endTime - _startTime);
                double mins = diff.TotalMinutes;
                return (int)mins;
            }
        }
        public int TableNumber { get { return _tableNumber;  } }
        public int NumberOfGuests { get { return _numberOfGuests; } }
        public string CustomerName { get { return _customerName; } }
    }
}
