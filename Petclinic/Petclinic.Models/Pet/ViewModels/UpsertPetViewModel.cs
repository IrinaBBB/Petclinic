using System;
using System.ComponentModel.DataAnnotations;
using Petclinic.Models.PetType;

namespace Petclinic.Models.Pet.ViewModels
{
    public class UpsertPetViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int Kilos { get; set; }
        public int Grams { get; set; }
        public string AdditionalData { get; set; }
        public int PetTypeId { get; set; }
        public virtual PetTypeDto PetType { get; set; }
    }
}