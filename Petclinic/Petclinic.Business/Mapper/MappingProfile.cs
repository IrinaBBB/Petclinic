using AutoMapper;
using Petclinic.DataAccess.Entities;
using Petclinic.Models.Pet;

namespace Petclinic.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PetDto, Pet>().ReverseMap();
        }        
    }
}