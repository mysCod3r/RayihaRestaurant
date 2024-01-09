using RayihaRestaurant.Core.Enums;
using RayihaRestaurant.Core.Models;

namespace RayihaRestaurant.Data.Service
{
    internal class TablesService
    {
        private readonly DatabaseContext _context;
        public TablesService(DatabaseContext context)
        {
            _context = context;
        }


        public List<Table> GetTables(bool isAll)
        {
            _context.ChangeTracker.Clear();
            if (isAll) return _context.Tables.ToList();

            List<Table> tables = new List<Table>();
            var all = _context.Tables.Where(e => e.TableStatus == false).ToList();
            var orders = _context.Orders.ToList();
            foreach (var table in all)
            {
                foreach (var order in orders)
                {
                    if (order.OrderStatus == OrderStatus.Completed && !tables.Contains(table))
                    {
                        tables.Add(table);
                    }
                }
            }
            return tables;
        }
    }
}
