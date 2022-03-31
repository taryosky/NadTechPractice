using NadTechPractice.Entities.Commons;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace NadTechPractice.Utilities.DTOs
{
    public class CustomerToAddDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Age { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public ICollection<AddressToAddDto> Address { get; set; }
    }
}
