using System.ComponentModel.DataAnnotations;

namespace NadTechPractice.Utilities.DTOs
{
    public class AddressToAddDto
    {
        [Required]
        public string Street { get; set; }
        [Required]
        public string PostCode { get; set; }
        [Required]
        public int HouseNumber { get; set; }
    }
}
