using NadTechPractice.Entities.Commons;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NadTechPractice.Entities.Models
{
    public class Address : EntityBase
    {
        public long AddressId { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string PostCode { get; set; }
        [Required]
        public int HouseNumber { get; set; }
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
