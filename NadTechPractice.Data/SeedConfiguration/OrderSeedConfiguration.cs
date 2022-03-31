using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using NadTechPractice.Entities.Models;

namespace NadTechPractice.Data.SeedConfiguration
{
    public class OrderSeedConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                new Order
                {
                    OrderId = new System.Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    Amount = 593.89m,
                    CustomerId = 1
                },
                new Order
                {
                    OrderId = new System.Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                    Amount = 983.90m,
                    CustomerId = 1
                });
        }
    }
}
