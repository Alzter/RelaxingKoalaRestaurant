using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantSystem.Service;
using RestaurantSystem.Services;

namespace RestaurantSystem
{
    public static class WaitStaffServiceInterface
    {
        public static void AddReservation(DateTime startTime, int durationMinutes, int tableNumber, string customerName, int numberOfGuests)
        {
            ReservationService.AddReservation(startTime, durationMinutes, tableNumber, customerName, numberOfGuests);
        }

        public static void RemoveReservation(Reservation r)
        {
            ReservationService.RemoveReservation(r);
        }

        public static Order CreateDineInOrder(List<MenuItem> items, int tableNumber)
        {
            return CreateOrderService.CreateDineInOrder(items, tableNumber);
        }
        public static Order CreateTakeAwayOrder(List<MenuItem> items)
        {
            return CreateOrderService.CreateTakeAwayOrder(items);
        }
        public static Order CreateDeliveryOrder(List<MenuItem> items, string address)
        {
            return CreateOrderService.CreateDeliveryOrder(items, address);
        }

        public static void AddOrderToQueue(Order o)
        {
            CreateOrderService.AddOrderToQueue(o);
        }

        public static void AddItem(Order o, MenuItem m)
        {
            CreateOrderService.AddItem(o, m);
        }

        public static void RemoveItem(Order o, int index)
        {
            CreateOrderService.RemoveItem(o, index);
        }

        public static void AddIngredient(Order o, MenuItem m, Ingredient i)
        {
            IngredientService.AddIngredient(o, m, i);
        }

        public static void RemoveIngredient(Order o, MenuItem m, Ingredient i)
        {
            IngredientService.RemoveIngredient(o, m, i);
        }

        public static List<Order> GetOrdersByStatus(OrderStatus status)
        {
            return ManageOrdersService.GetOrdersByStatus(status);
        }

        public static void SetOrderStatus(Order o, OrderStatus status)
        {
            ManageOrdersService.SetOrderStatus(o, status);
        }

        public static TransactionRecord PayForOrder(Order o)
        {
            return PaymentService.PayForOrder(o);
        }

        public static void UpdateTableStatus(int tableNumber, TableStatus status)
        {
            ManageTablesService.UpdateTableStatus(tableNumber, status);
        }

        public static List<Table> GetTablesByStatus(TableStatus status)
        {
            return ManageTablesService.GetTablesByStatus(status);
        }

        public static List<Table> GetFreeTables(DateTime time)
        {
            return ManageTablesService.GetFreeTables(time);
        }

        public static Menu DineInMenu { get { return MenuService.DineInMenu; } }
        public static Menu TakeAwayMenu { get { return MenuService.TakeAwayMenu; } }
        public static List<Reservation> Reservations { get { return ReservationService.PresentReservations; } }
        public static List<Reservation> PastReservations { get { return ReservationService.PastReservations; } }

        public static List<Table> Tables { get { return ManageTablesService.Tables; } }

        public static List<Order> Orders { get { return ManageOrdersService.Orders; } }

    }
}
