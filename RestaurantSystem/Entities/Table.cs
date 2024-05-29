using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem
{
    public class Table
    {
        private int _tableNumber;
        private TableStatus _status;

        public Table(int tableNumber, TableStatus status)
        {
            _tableNumber = tableNumber; _status = status;
        }

        public int Number
        {
            get { return _tableNumber; }
        }

        public TableStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
    }
}
