using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Service
{
    public static class ManageTablesService
    {
        public static void UpdateTableStatus(int tableNumber, TableStatus status)
        {

            List<Table> tables = RepositoryInterface.GetTables();

            int tableIndex = tables.FindIndex((Table t) => t.Number == tableNumber);

            Table t = GetTable(tableNumber);

            t.Status = status;

            tables[tableIndex] = t;

            // Console.WriteLine($"{t.Number}: {t.Status}");

            RepositoryInterface.SaveTables(tables);
        }

        public static Table GetTable(int tableNumber)
        {
            List<Table> tableList = Tables;

            foreach (Table t in tableList)
            {
                if (t.Number == tableNumber) return t;
            }

            throw new NullReferenceException($"Table with number {tableNumber} was not found.");
        }

        public static List<Table> GetTablesByStatus(TableStatus status)
        {
            List<Table> tables = new List<Table>();
            List<Table> tableList = Tables;

            foreach (Table t in tableList)
            {
                if (t.Status == status) tables.Add(t);
            }

            return tables;
        }

        public static List<Table> Tables
        {
            get
            {
                return RepositoryInterface.GetTables();
            }
        }
    }
}
