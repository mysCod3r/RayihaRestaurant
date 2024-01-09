using Microsoft.EntityFrameworkCore;
using RayihaRestaurant.Core.Enums;
using RayihaRestaurant.Core.Models;

namespace RayihaRestaurant.Data.Service
{
    public class WaiterService
    {
        private readonly DatabaseContext _context;

        public WaiterService(DatabaseContext context)
        {
            _context = context;
        }

        public void AddNewOrder(int tableId, List<OrderItem> item)
        {
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            item.ForEach((e) =>
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.Product = e.Product;
                orderDetail.Quantity = e.Quantity;
                orderDetails.Add(orderDetail);
            });

            double totalPrice = 0;
            foreach (OrderDetail orderDetail in orderDetails)
            {
                totalPrice += (orderDetail.Quantity ?? 0) * (orderDetail.Product?.Price ?? 0);
            }

            Order order = new Order
            {
                UserID = 1,
                TableID = tableId,
                OrderStatus = OrderStatus.Pending,
                IsPaid = false,
                OrderDetails = orderDetails,
                TotalPrice = totalPrice,
                
            };
            UpdateTableStatusToUnavailable(tableId);
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public List<Product> GetProducts()
        {
            var products = _context.Products
                .Include(p => p.Category)
                .ToList();

            return products;
        }

        public List<Category> GetCategories()
        {
            var categories = _context.Categories.ToList();

            return categories;
        }

        public void UpdateTableStatusToUnavailable(int tableId)
        {
            var table = _context.Tables.Where(p => p.ID == tableId).FirstOrDefault();
            if (table == null) return;
            table.TableStatus = false;

            _context.Update(table);
        }
    }
}
