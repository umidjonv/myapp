using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using productsapi.Entities;
//using productsapi.Entities.Log;
using productsapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productsapi.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Product { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<EntityLog> Entity { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //   => options.UseNpgsql("Host=localhost;Port=5432;Database=api;Username=postgres;Password=isfan2006");

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var cat = modelBuilder.HasPostgresExtension("uuid-ossp").Entity<Category>();
            cat.Property(e => e.id).HasDefaultValueSql("uuid_generate_v4()");
            cat.Property(e => e.status).HasDefaultValue(true).ValueGeneratedOnAdd();

            var prod = modelBuilder.HasPostgresExtension("uuid-ossp").Entity<Product>();
            prod.Property(e => e.id).HasDefaultValueSql("uuid_generate_v4()");
            prod.Property(e => e.status).HasDefaultValue(true).ValueGeneratedOnAdd();


            modelBuilder.Entity<EntityLog>()
                .Property(b => b.createdAt)
                  .HasColumnType("timestamp without time zone")
                  .HasDefaultValueSql("CURRENT_TIMESTAMP")
                  .ValueGeneratedOnAdd(); 

            modelBuilder.Entity<EntityLog>()
                .Property(b => b.updatedAt)
                .HasColumnType("timestamp without time zone")
                  .HasDefaultValueSql("CURRENT_TIMESTAMP") 
                  .ValueGeneratedOnAddOrUpdate();

            modelBuilder.Entity<EntityLog>()
                .Property(b => b.status)
                .HasDefaultValue(true);
        }
    }
}
