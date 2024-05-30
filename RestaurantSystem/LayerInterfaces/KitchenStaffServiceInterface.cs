using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantSystem.Service;

namespace RestaurantSystem
{
    public static class KitchenStaffServiceInterface
    {
        public static List<Order> GetWaitingOrders()
        {
            return ManageOrdersService.GetOrdersByStatus(OrderStatus.Waiting);
        }

        public static void SetOrderStatus(Order o, OrderStatus status)
        {
            ManageOrdersService.SetOrderStatus(o, status);
        }

        public static void StartOrder(Order o)
        {
            SetOrderStatus(o, OrderStatus.InProgress);
        }

        public static void StartOrder(Order o, int eta_minutes)
        {
            SetOrderStatus(o, OrderStatus.InProgress);
            ManageOrdersService.SetOrderETA(o, eta_minutes);

        }

        public static void FinishOrder(Order o)
        {
            SetOrderStatus(o, OrderStatus.Ready);
        }
    }
}
