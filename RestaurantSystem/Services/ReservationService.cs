using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public static class ReservationService
    {


        public static List<Reservation> PresentReservations
        {
            get
            {
                List<Reservation> reservations = Reservations;
                List<Reservation> reservationsList = new List<Reservation>();

                foreach (Reservation r in reservations)
                {
                    if (r.StartTime > DateTime.Now)
                    {
                        reservationsList.Add(r);
                    }
                }

                return reservationsList;
            }
        }

        public static List<Reservation> PastReservations
        {
            get
            {
                List<Reservation> reservations = Reservations;
                List<Reservation> reservationsList = new List<Reservation>();

                foreach (Reservation r in reservations)
                {
                    if (r.StartTime <= DateTime.Now)
                    {
                        reservationsList.Add(r);
                    }
                }

                return reservationsList;
            }
        }

        public static List<Reservation> Reservations
        {
            get
            {
                return RepositoryInterface.GetReservations();
            }
        }

        public static void AddReservation(DateTime startTime, int durationMinutes, int tableNum, string customerName, int numOfGuests) 
        {
            // Create Reservation object using CRUDO interface

            RepositoryInterface.AddReservation(startTime, durationMinutes, tableNum, customerName, numOfGuests);
        }

        // Remove a reservation from the list.
        public static void RemoveReservation(Reservation r)
        {
            RepositoryInterface.RemoveReservation(r);
        }
    }
}
