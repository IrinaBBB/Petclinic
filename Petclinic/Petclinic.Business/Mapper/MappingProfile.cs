using AutoMapper;
using Petclinic.Business.Mapper.Resolvers;
using Petclinic.DataAccess.Entities;
using Petclinic.Models.Pet;
using Petclinic.Models.Pet.ViewModels;
using Petclinic.Models.PetType;
using Petclinic.Common.Extensions;


namespace Petclinic.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PetDto, Pet>().ReverseMap();
            CreateMap<PetTypeDto, PetType>().ReverseMap();

            CreateMap<PetDto, UpsertPetViewModel>()
                .ForMember(dest => dest.Kilos,
                    opt => 
                        opt.MapFrom(src => src.Weight.GetWholePart()))
                .ForMember(dest => dest.Grams,
                    opt =>
                        opt.MapFrom(src => src.Weight.GetDecimalPart()));

            CreateMap<UpsertPetViewModel, PetDto>()
                .ForMember(dest => dest.Weight, opt => 
                    opt.MapFrom<WeightResolver>());
        }        
    }
}