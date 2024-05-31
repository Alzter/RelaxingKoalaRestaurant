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

            Console.WriteLine($"{t.Number}: {t.Status}");

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

        // For a given date and time, get all tables which are not reserved.
        public static List<Table> GetFreeTables(DateTime time)
        {
            List<Reservation> reservations = ReservationService.PresentReservations;
            List<Table> reservedTables = new List<Table>();

            foreach (Reservation r in reservations)
            {
                if (time >= r.StartTime && time < r.EndTime)
                {
                    Table table = GetTable(r.TableNumber);

                    reservedTables.Add(table);
                }
            }

            List<Table> freeTables = Tables;

            foreach (Table t in reservedTables) freeTables.Remove(t);

            return freeTables;
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
