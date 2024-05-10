using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class RestaurantTables
    {
        private static RestaurantTables _instance;
        private List<Table> _tables;

        public static RestaurantTables Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RestaurantTables();
                }
                return _instance;
            }
        }

        public RestaurantTables()
        {
            _tables = new List<Table>();
        }
    }
}
