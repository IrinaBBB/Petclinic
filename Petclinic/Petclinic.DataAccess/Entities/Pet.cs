using System;
using System.ComponentModel.DataAnnotations;

namespace Petclinic.DataAccess.Entities
{
    public class Pet
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Sex { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public double? Weight { get; set; }

        public string AdditionalData { get; set; }

        public int PetTypeId { get; set; }
    }
}