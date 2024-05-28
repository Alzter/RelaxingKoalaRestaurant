using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class WaitStaffService
    {
        private MenuService _menuService;
        private ReservationService _reservationService;
        private CreateOrderService _createOrderService;
        private ManageOrdersService _manageOrdersService;
        private ManageTablesService _manageTablesService;

        public WaitStaffService()
        {
            // Where do sub-services get instantiated? Are they passed in as parameters here?
        }

        public MenuService MenuService { get { return _menuService; } }
        public ReservationService ReservationService { get { return _reservationService; } }
        public CreateOrderService CreateOrderService { get { return _createOrderService; } }
        public ManageOrdersService ManageOrdersService { get { return _manageOrdersService; } }
        public ManageTablesService ManageTablesService { get { return _manageTablesService; } }
    }
}
