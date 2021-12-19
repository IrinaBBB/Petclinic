using AutoMapper;
using Petclinic.Common.Helpers;
using Petclinic.Models.Pet;
using Petclinic.Models.Pet.ViewModels;

namespace Petclinic.Business.Mapper.Resolvers
{
    public class WeightResolver : IValueResolver<UpsertPetViewModel, PetDto, double?>
    {
        public double? Resolve(UpsertPetViewModel source, PetDto destination, double? destMember, ResolutionContext context)
        {
            return Helper.GetDoubleFromIntegers(source.Kilos, source.Grams);
        }
    }
}