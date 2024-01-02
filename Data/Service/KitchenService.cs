using Microsoft.EntityFrameworkCore;
using RayihaRestaurant.Core.Models;

namespace RayihaRestaurant.Data.Service
{
    public class KitchenService
    {
        private readonly DatabaseContext _context;

        public KitchenService(DatabaseContext context)
        {
            _context = context;
        }

        public List<Order> GetOrders(int tableId)
        {
            var orders = _context.Orders
                .Where((e) => e.TableID == tableId && e.IsPaid == false)
                .Include(p => p.OrderDetails)
                    .ThenInclude(b => b.Product)
                        .ThenInclude(a => a.Category)
                .Include(p => p.Table)
                .Include(p => p.User)
                .ToList();

            return orders;
        }

        

    }

}
