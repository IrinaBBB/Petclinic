using System;
using FluentValidation;
using Petclinic.Models.Pet;

namespace Petclinic.Server.Validators
{
    public class PetValidator : AbstractValidator<PetDto>
    {
        public PetValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Pet Name is Required");
            RuleFor(p => p.Name).MaximumLength(100).WithMessage("Pet Name Should not Exceed 100 Characters");

            RuleFor(p => p.PetType).NotEmpty().WithMessage("Pet Type is Required");

            RuleFor(p => p.Sex).NotEmpty().WithMessage("Sex is required");

            RuleFor(p => p.Weight).LessThanOrEqualTo(100).WithMessage("Weight Should not Exceed 100 kilos");

            RuleFor(p => p.DateOfBirth)
                .GreaterThan(DateTime.Now.AddYears(-100))
                .WithMessage("Date of Birth should not be Less than 100 years ago");
            RuleFor(p => p.DateOfBirth).LessThan(DateTime.Now).WithMessage("Date of Birth should not be Greater than Today");
        }
    }
}