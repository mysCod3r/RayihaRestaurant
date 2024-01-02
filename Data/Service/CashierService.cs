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


        public void Checkout(List<Order> orders) 
        {
            
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

        public List<Table> GetTables()
        {
            var tables = _context.Tables.ToList();

            return tables;
        }

    }
}
