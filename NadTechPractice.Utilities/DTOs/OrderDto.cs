using System;

namespace NadTechPractice.Utilities.DTOs
{
    public class OrderDto
    {
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Amount { get; set; }
    }
}
