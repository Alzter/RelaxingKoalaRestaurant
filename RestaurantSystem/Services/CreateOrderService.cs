using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public static class CreateOrderService
    {
        public static Order createTakeAwayOrder(List<MenuItem> items, int id)
        {
            return new Order(items, id);
        }
    }
}
