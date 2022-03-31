using NadTechPractice.Entities.Commons;
using System.Collections.Generic;
using System;

namespace NadTechPractice.Utilities.DTOs
{
    public class CustomerWithOrdersDto
    {
        public long CustomerId { get; set; }
        public string Name { get; set; }
        public DateTime Age { get; set; }
        public Gender Gender { get; set; }
        public ICollection<AddressDto> Address { get; set; }
        public ICollection<OrderDto> Orders { get; set; }
    }
}
