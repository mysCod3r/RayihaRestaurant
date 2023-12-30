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

        public Order GetOrder(int tableId)
        {
            var order = _context.Orders.FirstOrDefault(a => a.TableID == 4);

            return order;
        }

    }

}
