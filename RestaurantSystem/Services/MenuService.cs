using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Service
{
    public static class MenuService
    {

        public static Menu TakeAwayMenu
        {
            get
            {
                return Menus.Find((Menu m) => { return m.Name.ToLower().Replace("-", "").Replace(" ", "").Trim() == "takeaway"; });
            }
        }

        public static Menu DineInMenu
        {
            get
            {
                return Menus.Find((Menu m) => { return m.Name.ToLower().Replace("-", "").Replace(" ", "").Trim() == "dinein"; });
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
