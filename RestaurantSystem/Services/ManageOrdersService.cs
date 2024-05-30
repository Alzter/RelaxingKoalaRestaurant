using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Service
{
    public static class ManageOrdersService
    {
        public static List<Order> GetOrdersByStatus(OrderStatus status)
        {
            List<Order> orders = new List<Order>();
            List<Order> orderList = Orders;

            foreach (Order o in orderList)
            {
                if (o.Status == status) { orders.Add(o); }
            }
            return orders;
        }

        public static void SetOrderStatus(Order o, OrderStatus status)
        {
            o.Status = status;
        }

        public static void SetOrderETA(Order o, int etaMinutes)
        {
            o.SetETA(etaMinutes);
        }

        public static List<Order> Orders
        {
            get
            {
                return RepositoryInterface.GetOrders();
            }
        }
    }
}
