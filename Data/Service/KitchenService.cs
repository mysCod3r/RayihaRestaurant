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

        public List<Order>? GetOrders(int tableId)
        {
            var order = _context.Orders.Where(a => a.TableID == tableId).ToList();

            return order;
        }

    }

}
