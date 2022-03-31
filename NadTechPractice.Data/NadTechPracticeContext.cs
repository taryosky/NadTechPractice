using Microsoft.EntityFrameworkCore;

using NadTechPractice.Data.SeedConfiguration;
using NadTechPractice.Entities.Models;

namespace NadTechPractice.Data
{
    public class NadTechPracticeContext : DbContext
    {
        public NadTechPracticeContext(DbContextOptions<NadTechPracticeContext> options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerSeedConfiguration());
            modelBuilder.ApplyConfiguration(new AddressSeedConfiguration());
            modelBuilder.ApplyConfiguration(new OrderSeedConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
