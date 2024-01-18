using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CustomersData;

public partial class TechSupportContext : DbContext
{
    public TechSupportContext()
    {
    }

    public TechSupportContext(DbContextOptions<TechSupportContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Incidents> Incidents { get; set; }

    public virtual DbSet<Registration> Registrations { get; set; }

    public virtual DbSet<OrderOption> OrderOptions { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<State> States { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.
        UseSqlServer(ConfigurationManager.
            ConnectionStrings["TechSupportConnection"].ConnectionString).
        UseLazyLoadingProxies(); // enables lazy loading of related records

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.State).IsFixedLength();
            entity.Property(e => e.ZipCode).IsFixedLength();

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.Customers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Customers_States");
        });

        modelBuilder.Entity<Incident>(entity =>
        {
            entity.HasOne(d => d.Customer).WithMany(p => p.Incidents).HasConstraintName("FK_Incidents_Customers");
        });

        modelBuilder.Entity<Registration>(entity =>
        {
            entity.Property(e => e.ProductCode).IsFixedLength();

            entity.HasOne(d => d.Incident).WithMany(p => p.Registrations).HasConstraintName("FK_Registrations_Incidents");

            entity.HasOne(d => d.ProductCodeNavigation).WithMany(p => p.Registrations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Registrations_Products");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.ProductCode).IsFixedLength();
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.Property(e => e.StateCode).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
