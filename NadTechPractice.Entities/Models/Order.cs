using NadTechPractice.Entities.Commons;
using NadTechPractice.Entities.Models;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NadTechPractice.Entities.Models
{
    public class Order : EntityBase
    {
        public Guid OrderId { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Order()
        {
            OrderId = Guid.NewGuid();
        }
    }
}
