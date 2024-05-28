using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public static class RepositoryInterface
    {
        // Menus - Save / Load
        public static List<Menu> GetMenus()
        {
            var menus = MenuRepository.LoadMenus("MenuData.json");
            return menus;
        }

        public static void SaveMenus(List<Menu> menus) 
        {
            MenuRepository.SaveMenus("MenuData.json", menus);
        }

        // Reservations - Save / Load
        public static List<Reservation> GetReservations()
        {
            var reservations = ReservationRepository.LoadReservations("ReservationData.json");
            return reservations;
        }

        public static void SaveReservations(List<Reservation> reservations) 
        {
            ReservationRepository.SaveReservations("ReservationData.json", reservations);
        }

        // Orders - Save / Load
        public static List<Order> GetOrders() 
        {
            throw new NotImplementedException();
        }

        public static void SaveOrders(List<Order> orders) 
        {
            throw new NotImplementedException();
        }

        // Transactions - Save / Load
        public static List<TransactionRecord> GetTransactions() 
        {
            throw new NotImplementedException();
        }

        public static void SaveTransactions(List<TransactionRecord> transactions) 
        { 
            throw new NotImplementedException();
        }

        // Tables - Save / Load
        public static List<Table> GetTables() 
        { 
            throw new NotImplementedException();
        }

        public static void SaveTables(List<Table> tables) 
        { 
            throw new NotImplementedException();
        }

        // Reservation - Create 
        public static void CreateReservation(DateTime dateTime, int durationMinutes, int tableNumber, string customerName, int numberOfGuests)
        {
            ReservationRepository.CreateReservation(dateTime, durationMinutes, tableNumber, customerName, numberOfGuests);
        }

        // Order - Create
        // Delivery
        public static void CreateOrder(List<MenuItem> menuItems, string address, string customerName, int numberOfGuests) 
        {
            throw new NotImplementedException();
        }
        // Dine-In
        public static void CreateOrder(List<MenuItem> menuItems, int tableNumber)
        {
            throw new NotImplementedException();
        }
        // TakeAway
        public static void CreateOrder(List<MenuItem> menuItems, string name)
        {
            throw new NotImplementedException();
        }
    }
}
