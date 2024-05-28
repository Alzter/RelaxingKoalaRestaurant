using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class ReservationService
    {
        private List<Reservation> _reservations;
        private List<Reservation> _pastReservations;

        public ReservationService() { }

        public List<Reservation> Reservations { get { return _reservations; } }
        public List<Reservation> PastReservations { get { return _pastReservations; } }

        public void AddReservation(DateTime startTime, int durationMinutes, int tableNum, string customerName, int numOfGuests) 
        {
            // Create Reservation object using CRUDO interface
            throw new NotImplementedException();
        }

        // QUESTION: Is this used to cancel a reservation? Or to move a completed reservation to the past reservations list?
        public void RemoveReservation(Reservation r)
        {
            // Find reservation in Reservations list?
            // Add to past reservations? Or delete it?
            throw new NotImplementedException();
        }
    }
}
