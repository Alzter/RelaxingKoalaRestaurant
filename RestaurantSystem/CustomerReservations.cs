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
        private List<Reservation> _reservations;

        private CustomerReservations()
        {
            _reservations = new List<Reservation>();
        }

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

        // Used to check pending reservations for a specified date
        public List<Reservation> PendingReservations(DateOnly date)
        {
            List<Reservation> reservationsOnDate = new List<Reservation>();

            foreach (Reservation reservation in _reservations)
            {
                // Convert BookingTime to just DateOnly and check to see if it's a match
                if (DateOnly.FromDateTime(reservation.BookingTime) == date)
                {
                    reservationsOnDate.Add(reservation);
                }
            }

            return reservationsOnDate;
        }

        // TODO: Need to figure out how to get Table.
        // Is it passed into this function? Or is Table sourced from within this function?
        // Also name and phone number? Do we create a Customer obj here?
        public bool AddReservation(DateTime dateTime, Table table, int numOfGuests)
        {
            _reservations.Add(new Reservation(dateTime, table, numOfGuests));

            // TODO: Some checks here to ensure Reservation is added?

            return true;
        }

        // Indicate whether specified reservation was removed successfully
        public bool RemoveReservation(Reservation reservation)
        {
            // Is reservation in list?
            if (_reservations.Contains(reservation))
            {
                _reservations.Remove(reservation);
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
