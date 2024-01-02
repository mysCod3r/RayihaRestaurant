using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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


        public void AddNewOrder(int tableId, List<OrderDetail> orderDetails)
        {
            var order = new Order
            {
                UserID = 1,
                TableID = tableId,
                OrderStatus = OrderStatus.Pending.ToString(),
                IsPaid = false,
                OrderDetails = orderDetails
            };

            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public List<Table> GetTables()
        {
            var tables = _context.Tables.ToList();

            return tables;
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
        
    }


}
