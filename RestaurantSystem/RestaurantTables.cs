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

        // Returns list of tables that have specified status
        public List<Table> GetStatusTables(TableStatus status)
        {
            List<Table> statusTables = new List<Table>();

            foreach (Table table in _tables)
            {
                if (table.GetStatus() == status)
                {
                    statusTables.Add(table);
                }
            }

            return statusTables;
        }
    }
}
