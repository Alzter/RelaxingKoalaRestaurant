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
            //List<Table> tables = RepositoryInterface.GetTables();

            int tableIndex = Tables.FindIndex((Table t) => t.Number == tableNumber);

            Table t = GetTable(tableNumber);

            t.Status = status;

            Tables[tableIndex] = t;

            Console.WriteLine($"{t.Number}: {t.Status}");

            RepositoryInterface.SaveTables(Tables);
        }

        public static Table GetTable(int tableNumber)
        {
            //List<Table> tableList = Tables;

            foreach (Table t in Tables)
            {
                if (t.Number == tableNumber) return t;
            }

            throw new NullReferenceException($"Table with number {tableNumber} was not found.");
        }

        public static List<Table> GetTablesByStatus(TableStatus status)
        {
            List<Table> tables = new List<Table>();
            //List<Table> tableList = Tables;

            foreach (Table t in Tables)
            {
                if (t.Status == status) tables.Add(t);
            }

            return tables;
        }

        // For a given date and time, get all tables which are not reserved.
        public static List<Table> GetFreeTables(DateTime time)
        {
            List<Reservation> reservations = ReservationService.PresentReservations;
            List<int> reservedTableNums = new List<int>();

            foreach (Reservation r in reservations)
            {
                if (time >= r.StartTime && time < r.EndTime)
                {
                    reservedTableNums.Add(r.TableNumber);
                }
            }

            List<Table> freeTables = Tables;
            List<Table> tablesToRemoveFromFree = new List<Table>();

            foreach (Table t in freeTables)
            {
                foreach (int num in reservedTableNums)
                {
                    if (t.Number == num)
                    {
                        tablesToRemoveFromFree.Add(t);
                    }
                }
            }

            foreach (Table r in tablesToRemoveFromFree)
            {
                freeTables.Remove(r);
            }

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
