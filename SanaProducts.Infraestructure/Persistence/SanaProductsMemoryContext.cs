using Microsoft.EntityFrameworkCore;
using SanaProducts.Domain.EntitiesMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SanaProducts.Infraestructure.Persistence
{
    public class SanaProductsMemoryContext : DbContext
    {
        public SanaProductsMemoryContext(DbContextOptions<SanaProductsMemoryContext> context) : base(context)
        {

        }

        public DbSet<MSCategory> Categories { get; set; }
        public DbSet<MSProduct> Products { get; set; }
        public DbSet<MSProductCategory> ProductCategories { get; set; }
        public DbSet<MSProductDetail> ProductDetails { get; set; }
        public DbSet<MSCustomer> Customers { get; set; }
        public DbSet<MSCustomerDetail> CustomerDetails { get; set; }
        public DbSet<MSOrder> Orders { get; set; }
        public DbSet<MSOrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MSCategory>().ToTable("Categories");
            modelBuilder.Entity<MSProduct>().ToTable("Products");
            modelBuilder.Entity<MSProductCategory>().ToTable("ProductCategories");
            modelBuilder.Entity<MSProductDetail>().ToTable("ProductDetails");
            modelBuilder.Entity<MSCustomer>().ToTable("Customers");
            modelBuilder.Entity<MSCustomerDetail>().ToTable("CustomerDetails");
            modelBuilder.Entity<MSOrder>().ToTable("Orders");
            modelBuilder.Entity<MSOrderDetail>().ToTable("OrderDetails");
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
