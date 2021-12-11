using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Petclinic.DataAccess.Entities
{
    public class PetType
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public List<Pet> Pets { get; set; }
    }
}