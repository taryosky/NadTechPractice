using NadTechPractice.Entities.Commons;
using System.ComponentModel.DataAnnotations;
using System;

namespace NadTechPractice.Utilities.DTOs
{
    public class CustomerToUpdateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Age { get; set; }
        [Required]
        public Gender Gender { get; set; }
    }
}
