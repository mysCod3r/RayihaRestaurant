using System.Configuration;
using Microsoft.EntityFrameworkCore;
using RayihaRestaurant.Core.Models;

namespace RayihaRestaurant.Data
{
    public class DatabaseContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DatabaseContext"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(e => e.Category)
                .WithMany()
                .HasForeignKey(e => e.CategoryID)
                .IsRequired();
            
            modelBuilder.Entity<Order>()
                .HasOne(e => e.User)
                .WithMany()
                .HasForeignKey(e => e.UserID)
                .IsRequired();

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderDetails)
                .WithOne()
                .HasForeignKey(e => e.OrderID)
                .IsRequired();

            modelBuilder.Entity<Order>()
                .HasOne(e => e.Table)
                .WithMany()
                .HasForeignKey(e => e.TableID)
                .IsRequired();

            //modelBuilder.Entity<OrderDetail>()
            //    .HasOne(e => e.Order)
            //    .WithMany()
            //    .HasForeignKey(e => e.OrderID)
            //    .IsRequired();

            modelBuilder.Entity<OrderDetail>()
                .HasOne(e => e.Product)
                .WithMany()
                .HasForeignKey(e => e.ProductID)
                .IsRequired();
        }

    }

}   
