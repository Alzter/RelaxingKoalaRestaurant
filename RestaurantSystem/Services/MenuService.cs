using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RestaurantSystem.Service
{
    public static class MenuService
    {

        public static Menu TakeAwayMenu
        {
            get
            {
                Menu takeAwayMenu = Menus.Find((Menu m) => { return Regex.IsMatch(m.Name, "take(\\s||\\-)*away", RegexOptions.IgnoreCase); });
                if (takeAwayMenu == null) { throw new NullReferenceException("Could not find take-away menu."); }
                return takeAwayMenu;
            }
        }

        public static Menu DineInMenu
        {
            get
            {
                Menu dineInMenu = Menus.Find((Menu m) => { return Regex.IsMatch(m.Name, "dine(\\s||\\-)*in", RegexOptions.IgnoreCase); });
                if (dineInMenu == null) { throw new NullReferenceException("Could not find dine-in menu."); }
                return dineInMenu;
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
