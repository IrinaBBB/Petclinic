﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Petclinic.Models.Pet
{
    public class PetDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage="Pet Name is required")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Pet Sex is required")]
        [MaxLength(50)]
        public string Sex { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public double? Weight { get; set; }

        public string AdditionalData { get; set; }

        public int PetTypeId { get; set; }
    }
}