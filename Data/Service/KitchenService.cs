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

        //public void qwerty()
        //{
        //    var qwerty = _context.Products.ToList();
        //}

        public void qwerty()
        {
            var qwerty = _context.Products
                .Include(p => p.Category)
                .ToList();
        }

    }

}
