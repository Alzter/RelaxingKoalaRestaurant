using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public static class ReservationService
    {


        public static List<Reservation> Reservations
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        public static List<Reservation> PastReservations
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static void AddReservation(DateTime startTime, int durationMinutes, int tableNum, string customerName, int numOfGuests) 
        {
            // Create Reservation object using CRUDO interface
            throw new NotImplementedException();
        }

        // QUESTION: Is this used to cancel a reservation? Or to move a completed reservation to the past reservations list?
        public static void RemoveReservation(Reservation r)
        {
            // Find reservation in Reservations list?
            // Add to past reservations? Or delete it?
            throw new NotImplementedException();
        }
    }
}
