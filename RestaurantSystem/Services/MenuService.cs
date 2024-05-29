using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public static class MenuService
    {

        public static Menu TakeAwayMenu
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static Menu DineInMenu
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public static List<Menu> Menus
        {
            get
            {
                return RepositoryInterface.GetMenus();
            }
        }
    }
}
