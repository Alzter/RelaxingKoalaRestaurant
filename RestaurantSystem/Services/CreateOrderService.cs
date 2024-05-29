using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public static class CreateOrderService
    {
        public static Order CreateTakeAwayOrder(List<MenuItem> items)
        {
            return RepositoryInterface.CreateOrder(items);
        }
        public static Order CreateDeliveryOrder(List<MenuItem> items, string address)
        {
            return RepositoryInterface.CreateOrder(items, address);
        }

        public static Order CreateDineInOrder(List<MenuItem> items, int tableNumber)
        {
            return RepositoryInterface.CreateOrder(items, tableNumber);
        }

        public static void AddItem(Order o, MenuItem m)
        {
            o.AddItem(m);
        }

        public static void AddOrderToQueue(Order o)
        {
            RepositoryInterface.AddOrder(o);
        }

    }
}
