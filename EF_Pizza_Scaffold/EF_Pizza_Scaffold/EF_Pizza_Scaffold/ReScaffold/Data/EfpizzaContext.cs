﻿using System;
using System.Collections.Generic;
using EF_PizzaReScaffold.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_PizzaReScaffold.Data;

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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_Orders_CustomerId");

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders).HasForeignKey(d => d.CustomerId);
        });

        modelBuilder.Entity<OrderDetail>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_OrderDetails_CustomerId");

            entity.HasIndex(e => e.OrderDetailId, "IX_OrderDetails_OrderDetailId");

            entity.HasIndex(e => e.OrderId, "IX_OrderDetails_OrderId");

            entity.HasOne(d => d.Customer).WithMany(p => p.OrderDetails).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.OrderDetailNavigation).WithMany(p => p.InverseOrderDetailNavigation).HasForeignKey(d => d.OrderDetailId);

            entity.HasOne(d => d.Order).WithMany(p => p.OrderDetails).HasForeignKey(d => d.OrderId);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Category)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.Price).HasColumnType("decimal(6, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
