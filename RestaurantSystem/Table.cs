using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum TableStatus
{
    EMPTY,
    OCCUPIED,
    RESERVED,
    NEEDS_CLEANING
}

namespace RestaurantSystem
{
    public class Table
    {
        private int _tableNumber;
        private TableStatus _status = TableStatus.EMPTY;

        public Table(int tableNumber)
        {
            _tableNumber = tableNumber;
        }

        public TableStatus GetStatus()
        {
            return _status;
        }

        public void ChangeStatus(TableStatus status)
        {
            _status = status;
        }
    }
}
