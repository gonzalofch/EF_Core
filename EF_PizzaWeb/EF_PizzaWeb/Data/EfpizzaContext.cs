using System;
using System.Collections.Generic;
using EF_PizzaWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_PizzaWeb.Data;

public partial class EfpizzaContext : DbContext
{
    public EfpizzaContext()
    {
    }

    public EfpizzaContext(DbContextOptions<EfpizzaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost,1434;Database=EFPizza;User=sa;Password=SqlServer_Docker2024;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
