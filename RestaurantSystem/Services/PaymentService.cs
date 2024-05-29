using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public static class PaymentService
    {
        public static TransactionRecord PayForOrder(Order o)
        {

            List<Order> orders = RepositoryInterface.GetOrders();
            Order orderObject;

            foreach (Order order in orders) { if (order.ID == o.ID)
                {
                    orderObject = order;

                    TransactionRecord receipt = o.PayForOrder();

                    // Replace the saved order object with the local one.
                    orders[orders.IndexOf(orderObject)] = o;

                    RepositoryInterface.AddTransaction(receipt);

                    RepositoryInterface.SaveOrders(orders);

                    return receipt;
                }
            }

            throw new NullReferenceException("Could not find Order in Order list. Was the order added to the queue?");

        }

        public static List<TransactionRecord> TransactionRecords
        {
            get
            {
                return RepositoryInterface.GetTransactions();
            }
        }
    }
}
