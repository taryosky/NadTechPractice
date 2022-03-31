using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using NadTechPractice.Entities.Models;

namespace NadTechPractice.Data.SeedConfiguration
{
    public class AddressSeedConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasData(
                new Address
                {
                    HouseNumber = 5,
                    Street = "Ajasalane",
                    PostCode = "1100021",
                    AddressId = 1,
                    CustomerId = 1
                });
        }
    }
}
