using System;
using FluentValidation;
using Petclinic.Models.Pet.ViewModels;

namespace Petclinic.Server.Validators
{
    public class UpsertPetValidator : AbstractValidator<UpsertPetViewModel>
    {
        public UpsertPetValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Pet Name is Required");
            RuleFor(p => p.Name).MaximumLength(100).WithMessage("Pet Name Should not Exceed 100 Characters");

            RuleFor(p => p.PetTypeId).NotEmpty().WithMessage("Pet Type is Required");

            RuleFor(p => p.Sex).NotEmpty().WithMessage("Sex is required");

            RuleFor(w => w.Kilos).LessThanOrEqualTo(100).WithMessage("Cannot Exceed 100");
            RuleFor(w => w.Kilos).GreaterThanOrEqualTo(0).WithMessage("Cannot be Negative");

            RuleFor(w => w.Grams).LessThanOrEqualTo(999).WithMessage("Cannot Exceed 999");
            RuleFor(w => w.Grams).GreaterThanOrEqualTo(0).WithMessage("Cannot be Negative");

            RuleFor(p => p.DateOfBirth)
                .GreaterThan(DateTime.Now.AddYears(-100))
                .WithMessage("Date of Birth should not be Less than 100 years ago");
            RuleFor(p => p.DateOfBirth).LessThan(DateTime.Now).WithMessage("Date of Birth should not be Greater than Today");
        }
    }
}