using NadTechPractice.Entities.Commons;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NadTechPractice.Entities.Models
{
    public class Customer : EntityBase
    {
        public long CustomerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Age { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Customer()
        {
            Address = new List<Address>();
            Orders = new List<Order>();
        }
    }
}
