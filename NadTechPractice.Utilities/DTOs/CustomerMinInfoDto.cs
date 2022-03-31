using NadTechPractice.Entities.Commons;

using System;

namespace NadTechPractice.Utilities.DTOs
{
    public class CustomerMinInfoDto
    {
        public long CustomerId { get; set; }
        public string Name { get; set; }
        public DateTime Age { get; set; }
        public Gender Gender { get; set; }
    }
}
