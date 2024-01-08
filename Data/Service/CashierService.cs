﻿using Microsoft.EntityFrameworkCore;
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

            foreach (var order in orders)
            {
                order.IsPaid = true;
                _context.Update(order);
                _context.SaveChanges();
            }
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

        public void UpdateTableStatusToAvailable(Table table)
        {
            table.TableStatus = true;

            _context.Update(table);
            _context.SaveChanges();
        }

    }
}
