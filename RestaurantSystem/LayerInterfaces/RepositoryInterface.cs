using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public static class RepositoryInterface
    {
        // Menus - Save / Load
        public static List<Menu> GetMenus()
        {
            var menus = MenuRepository.LoadItems("MenuData.json");
            return menus;
        }

        public static void SaveMenus(List<Menu> menus) 
        {
            MenuRepository.SaveItems("MenuData.json", menus);
        }

        // Reservations - Save / Load
        public static List<Reservation> GetReservations()
        {
            var reservations = ReservationRepository.LoadItems("ReservationData.json");
            return reservations;
        }

        public static void SaveReservations(List<Reservation> reservations) 
        {
            ReservationRepository.SaveItems("ReservationData.json", reservations);
        }

        // Orders - Save / Load
        public static List<Order> GetOrders() 
        {
            var orders = OrderRepository.LoadItems("OrderData.json");
            return orders;
        }

        public static void SaveOrders(List<Order> orders) 
        {
            OrderRepository.SaveItems("OrderData.json", orders);
        }

        // Transactions - Save / Load
        public static List<TransactionRecord> GetTransactions() 
        {
            var transactions = TransactionRepository.LoadItems("TransactionData.json");
            return transactions;
        }

        public static void SaveTransactions(List<TransactionRecord> transactions) 
        { 
            TransactionRepository.SaveItems("TransactionData.json", transactions);
        }

        // Tables - Save / Load
        public static List<Table> GetTables() 
        {
            var tables = TableRepository.LoadItems("TableData.json");
            return tables;
        }

        public static void SaveTables(List<Table> tables) 
        {
            TableRepository.SaveItems("TableData.json", tables);
        }

        // Reservation - Create 
        public static void CreateReservation(DateTime dateTime, int durationMinutes, int tableNumber, string customerName, int numberOfGuests)
        {
            ReservationRepository.CreateReservation(dateTime, durationMinutes, tableNumber, customerName, numberOfGuests);
        }

        // Order - Create
        // Delivery
        public static Order CreateOrder(List<MenuItem> menuItems, string address) 
        {
            return OrderRepository.CreateOrder(menuItems, address);
        }
        // Dine-In
        public static Order CreateOrder(List<MenuItem> menuItems, int tableNumber)
        {
            return OrderRepository.CreateOrder(menuItems, tableNumber);
        }
        // TakeAway
        public static Order CreateOrder(List<MenuItem> menuItems)
        {
            return OrderRepository.CreateOrder(menuItems);
        }

        public static void AddOrder(Order o)
        {
            OrderRepository.AddOrder(o);
        }

        // Transaction - Add
        public static TransactionRecord AddTransaction(TransactionRecord transaction)
        {
            string filePath = "TransactionData.json";
            TransactionRepository.AddTransactionRecord(filePath, transaction);
            return transaction;
        }
    }
}
