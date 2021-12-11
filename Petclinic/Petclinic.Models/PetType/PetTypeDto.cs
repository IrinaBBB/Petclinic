using System.ComponentModel.DataAnnotations;

namespace Petclinic.Models.PetType
{
    public class PetTypeDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "PetType Name is required")]
        [MaxLength(100)]
        public string Name { get; set; }
    }
}