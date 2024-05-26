using RestaurantSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class StateFactory
    {
        private RestaurantService _restaurantService;
        private WaitStaffService _waitStaffService;
        private KitchenStaffService _kitchenStaffService;
        private DeliveryStaffService _deliveryStaffService;
        private CustomerService _customerService;
        private CreateOrderService _createOrderService;
        private ManageOrdersService _manageOrdersService;
        private ManageTablesService _manageTablesService;
        private CreateReservationService _createReservationService;
        private OrderPaymentService _orderPaymentService;

        public StateFactory(UserInterface userInterface)
        {
            _restaurantService = new RestaurantService(userInterface);
            _waitStaffService = new WaitStaffService(userInterface);
            _kitchenStaffService = new KitchenStaffService(userInterface);
            _deliveryStaffService = new DeliveryStaffService(userInterface);
            _customerService = new CustomerService(userInterface);
            _createOrderService = new CreateOrderService(userInterface);
            _manageOrdersService = new ManageOrdersService(userInterface);
            _manageTablesService = new ManageTablesService(userInterface);
            _createReservationService = new CreateReservationService(userInterface);
            _orderPaymentService = new OrderPaymentService(userInterface);
        }
            
        public RestaurantService RestaurantService { get { return _restaurantService; } }
        public WaitStaffService WaitStaffService { get { return _waitStaffService; } }
        public KitchenStaffService KitchenStaffService { get { return _kitchenStaffService; } }
        public DeliveryStaffService DeliveryStaffService { get { return _deliveryStaffService; } }
        public CustomerService CustomerService { get { return _customerService; } }
        public CreateOrderService CreateOrderService { get { return _createOrderService; } }
        public ManageOrdersService ManageOrdersService { get { return _manageOrdersService; } }
        public ManageTablesService ManageTablesService { get { return _manageTablesService; } }
        public CreateReservationService CreateReservationService { get { return _createReservationService; } }
        public OrderPaymentService OrderPaymentService { get { return _orderPaymentService; } }
    }
}
