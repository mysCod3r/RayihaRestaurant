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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DatabaseContext"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .HasMany(e => e.Orders)
                .WithOne(e => e.Table)
                .HasForeignKey(e => e.TableId)
                .IsRequired();

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Products)
                .WithOne(e => e.Category)
                .HasForeignKey(e => e.CategoryId)
                .IsRequired();

            modelBuilder.Entity<Order>()
                .HasMany(e => e.Products)
                .WithOne(e => e.Order)
                .HasForeignKey(e => e.OrderId)
                .IsRequired();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Orders)
                .WithOne(e => e.User)
                .HasForeignKey(e => e.UserId)
                .IsRequired();

            
        }

    }

}   
