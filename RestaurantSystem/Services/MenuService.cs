using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class MenuService
    {
        private Menu _takeAwayMenu;
        private Menu _dineInMenu;

        public MenuService()
        {

        }

        public Menu TakeAwayMenu { get { return _takeAwayMenu; } set { _takeAwayMenu = value; } }
        public Menu DineInMenu { get { return _dineInMenu; } set { _dineInMenu = value; } }
    }
}
