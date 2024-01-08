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

        // update status
        public void UpdateOrderStatus(Order order)
        {

            OrderStatus status = order.OrderStatus ?? OrderStatus.Pending;

            order.OrderStatus = status == OrderStatus.Pending ? OrderStatus.InProgress : status == OrderStatus.InProgress ? OrderStatus.Completed : OrderStatus.Completed;
            _context.Update(order);
            _context.SaveChanges();
        }


        public List<Order> GetOrders()
        {
            var orders = _context.Orders
                .Where((e) => e.IsPaid == false)
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
