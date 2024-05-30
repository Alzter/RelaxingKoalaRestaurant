using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            List<Order> orderList = RepositoryInterface.GetOrders();

            int orderIndex = orderList.FindIndex((Order order) => { return order.ID == o.ID; });

            o.Status = status;

            orderList[orderIndex] = o;

            RepositoryInterface.SaveOrders(orderList);
        }

        public static void SetOrderETA(Order o, int etaMinutes)
        {
            List<Order> orderList = RepositoryInterface.GetOrders();

            int orderIndex = orderList.FindIndex((Order order) => { return order.ID == o.ID; });

            o.SetETA(etaMinutes);

            orderList[orderIndex] = o;

            RepositoryInterface.SaveOrders(orderList);
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
