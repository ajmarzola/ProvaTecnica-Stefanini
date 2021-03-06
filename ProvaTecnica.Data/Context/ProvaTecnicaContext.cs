﻿using ProvaTecnica.Entity;
using System.Data.Entity;

namespace ProvaTecnica.Data.Context
{
    class ProvaTecnicaContext : DbContext
    {
        public ProvaTecnicaContext() : base("name=ProvaTecnicaConnectionString")
        {
            //
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // configures one-to-many relationship
            modelBuilder.Entity<Product>()
                .HasRequired<Customer>(c => c.Customer)
                .WithMany(p => p.Products)
                .HasForeignKey<int>(p => p.CustomerId);
        }

        private void FixEfProviderServicesProblem()
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
