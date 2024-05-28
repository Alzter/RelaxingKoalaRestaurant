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
        private RestaurantView _restaurantView;
        private WaitStaffView _waitStaffView;
        private KitchenStaffView _kitchenStaffView;
        private DeliveryStaffView _deliveryStaffView;
        private CustomerView _customerView;
        private CreateOrderView _createOrderView;
        private ManageOrdersView _manageOrdersView;
        private ManageTablesView _manageTablesView;
        private CreateReservationView _createReservationView;
        private PaymentView _paymentView;

        public StateFactory(UserInterface userInterface)
        {
            _restaurantView = new RestaurantView(userInterface);
            _waitStaffView = new WaitStaffView(userInterface);
            _kitchenStaffView = new KitchenStaffView(userInterface);
            _deliveryStaffView = new DeliveryStaffView(userInterface);
            _customerView = new CustomerView(userInterface);
            _createOrderView = new CreateOrderView(userInterface);
            _manageOrdersView = new ManageOrdersView(userInterface);
            _manageTablesView = new ManageTablesView(userInterface);
            _createReservationView = new CreateReservationView(userInterface);
            _paymentView = new PaymentView(userInterface);
        }
            
        public RestaurantView RestaurantView { get { return _restaurantView; } }
        public WaitStaffView WaitStaffView { get { return _waitStaffView; } }
        public KitchenStaffView KitchenStaffView { get { return _kitchenStaffView; } }
        public DeliveryStaffView DeliveryStaffView { get { return _deliveryStaffView; } }
        public CustomerView CustomerView { get { return _customerView; } }
        public CreateOrderView CreateOrderView { get { return _createOrderView; } }
        public ManageOrdersView ManageOrdersView { get { return _manageOrdersView; } }
        public ManageTablesView ManageTablesView { get { return _manageTablesView; } }
        public CreateReservationView CreateReservationView { get { return _createReservationView; } }
        public PaymentView PaymentView { get { return _paymentView; } }
    }
}
