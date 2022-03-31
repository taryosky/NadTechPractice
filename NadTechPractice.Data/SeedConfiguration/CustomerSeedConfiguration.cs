using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using NadTechPractice.Entities.Models;

using System.Collections.Generic;

namespace NadTechPractice.Data.SeedConfiguration
{
    public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Name = "Clement Azibataram",
                    CustomerId = 1,
                    Gender = Entities.Commons.Gender.Male,
                    Age = System.DateTime.Parse("1994/4/3")
                });
        }
    }
}
