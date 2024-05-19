using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class StateFactory
    {
        private RestaurantController _cRestaurant;
        private WaitStaffController _cWaitStaff;
        private KitchenController _cKitchen;
        private DeliveryController _cDelivery;
        private CustomerController _cCustomer;
        private CreateOrdersController _cCreateOrders;
        private ManageOrdersController _cManageOrders;
        private DeliverOrdersController _cDeliverOrders;
        private ManageTablesController _cManageTables;

        public StateFactory(UserInterface userInterface)
        {
            _cRestaurant = new RestaurantController(userInterface);
            _cWaitStaff = new WaitStaffController(userInterface);
            _cKitchen = new KitchenController(userInterface);
            _cDelivery = new DeliveryController(userInterface);
            _cCustomer = new CustomerController(userInterface);
            _cCreateOrders = new CreateOrdersController(userInterface);
            _cManageOrders = new ManageOrdersController(userInterface);
            _cDeliverOrders = new DeliverOrdersController(userInterface);
            _cManageTables = new ManageTablesController(userInterface);
        }

        public RestaurantController CRestaurant { get { return _cRestaurant; } }
        public WaitStaffController CWaitStaff { get { return _cWaitStaff; } }
        public KitchenController CKitchen { get { return _cKitchen; } }
        public DeliveryController CDelivery { get { return _cDelivery; } }
        public CustomerController CCustomer { get { return _cCustomer; } }
        public CreateOrdersController CCreateOrders { get { return _cCreateOrders; } }
        public ManageOrdersController CManageOrders { get { return _cManageOrders; } }
        public DeliverOrdersController CDeliverOrders { get { return _cDeliverOrders; } }
        public ManageTablesController CManageTables { get { return _cManageTables; } }
    }
}
