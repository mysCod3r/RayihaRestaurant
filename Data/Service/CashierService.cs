using Microsoft.EntityFrameworkCore;
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

        public void Checkout(int tableId) 
        {
            List<Order> orders = GetOrders(tableId);
            _updateTableStatusToUnavailable(tableId);
            foreach (var order in orders)
            {
                order.IsPaid = true;
                _context.Update(order);
            }
            _context.SaveChanges();
        }

        public List<Order> GetOrders(int tableId)
        {
            var orders = _context.Orders
                .Where((e) => e.TableID == tableId && e.IsPaid == false)
                .Include(p => p.OrderDetails)
                    .ThenInclude(b => b.Product)
                        .ThenInclude(a => a.Category)
                .Include(p => p.Table)
                .ToList();

            return orders;
        }

        public void _updateTableStatusToUnavailable(int tableId)
        {
            var table = _context.Tables.Where(p => p.ID == tableId).FirstOrDefault();
            if (table == null) return;
            table.TableStatus = true;

            _context.Update(table);
        }
    }
}
