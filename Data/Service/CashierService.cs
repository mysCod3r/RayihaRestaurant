using RayihaRestaurant.Core.Models;

namespace RayihaRestaurant.Data.Service
{
    internal class CashierService
    {
        private readonly DatabaseContext _context;

        public CashierService(DatabaseContext context)
        {
            _context = context;
        }

        public List<Order>? GetOrders(int tableId)
        {
            var order = _context.Orders.Where(a => a.TableID == tableId).ToList();

            return order;
        }

        public List<Table> GetTables()
        {
            var tables = _context.Tables.ToList();

            return tables;
        }

    }
}
