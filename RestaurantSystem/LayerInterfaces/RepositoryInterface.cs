using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RestaurantSystem.CRUDO;

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


        // Reservation - Create and Add
        public static void AddReservation(DateTime dateTime, int durationMinutes, int tableNumber, string customerName, int numberOfGuests)
        {
            ReservationRepository.AddReservation(dateTime, durationMinutes, tableNumber, customerName, numberOfGuests);
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

        // Reservation - Remove from list
        public static void RemoveReservation(Reservation reservation)
        {
            ReservationRepository.RemoveReservation(reservation);
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

        // Order - Add
        public static void AddOrder(Order o)
        {
            OrderRepository.AddOrder(o);
        }

        public static void RemoveOrder(Order o)
        {
            OrderRepository.RemoveOrder(o);
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

        public static void AddIngredient(Order o, MenuItem m, Ingredient i)
        {
            //List<Order> orders = GetOrders();

            //int orderIndex = orders.FindIndex((Order order) => { return order.ID == o.ID; });

            m.AddIngredient(i);

            //orders[orderIndex] = o;

            //SaveOrders(orders);
        }

        public static void RemoveIngredient(Order o, MenuItem m, Ingredient i)
        {
            //List<Order> orders = GetOrders();

            //int orderIndex = orders.FindIndex((Order order) => { return order.ID == o.ID; });

            m.RemoveIngredient(i);

            //orders[orderIndex] = o;

            //SaveOrders(orders);
        }

        // Transaction - Add
        public static TransactionRecord AddTransaction(TransactionRecord transaction)
        {
            string filePath = "TransactionData.json";
            TransactionRepository.AddTransactionRecord(filePath, transaction);
            return transaction;
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
    }
}
