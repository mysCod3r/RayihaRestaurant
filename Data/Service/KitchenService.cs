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

        

        public void qwerty()
        {
            var order = _context.Orders
                .Include(p => p.User)
                .Include(p => p.Table)
                .Include(p => p.OrderDetails)
                .ThenInclude(b => b.Product)
                .ThenInclude(b => b.Category)
                .ToList();
        }

    }

}
