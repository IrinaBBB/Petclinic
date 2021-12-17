using AutoMapper;
using Petclinic.DataAccess.Entities;
using Petclinic.Models.Pet;
using Petclinic.Models.PetType;

namespace Petclinic.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PetDto, Pet>().ReverseMap();
            CreateMap<PetTypeDto, PetType>().ReverseMap();
        }        
    }
}