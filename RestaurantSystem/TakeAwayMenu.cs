using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class TakeAwayMenu : Menu
    {
        public TakeAwayMenu(List<MenuItem> items, string name)
            : base(items, name)
        {
        }
    }
}
