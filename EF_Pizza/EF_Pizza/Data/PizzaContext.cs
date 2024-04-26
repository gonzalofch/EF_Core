
using EF_Pizza.Models;

using Microsoft.EntityFrameworkCore;

namespace EF_Pizza.Data
{
    public class PizzaContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1434;Database=EFPizza;User=sa;Password=SqlServer_Docker2024;TrustServerCertificate=True");
        }
    }
}
