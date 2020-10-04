using Microsoft.EntityFrameworkCore;
using organisationsapi.Entites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace organisationsapi.Context
{
    public class OrganisationContext : DbContext
    {
        public DbSet<Organisation> Organisation { get; set; }

        public DbSet<Bank> Bank { get; set; }

        public OrganisationContext(DbContextOptions<OrganisationContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var org = modelBuilder.HasPostgresExtension("uuid-ossp").Entity<Organisation>();
            org.Property(e => e.Id).HasDefaultValueSql("uuid_generate_v4()");
            org.Property(e => e.Status).HasDefaultValue(true).ValueGeneratedOnAdd();

            var bank = modelBuilder.Entity<Bank>();
            bank.Property(e => e.Id).UseIdentityAlwaysColumn();
            bank.Property(e => e.Status).HasDefaultValue(true).ValueGeneratedOnAdd();
        }
    }
}
