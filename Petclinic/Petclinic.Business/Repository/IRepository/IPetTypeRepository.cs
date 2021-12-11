using System.Collections.Generic;
using Petclinic.Models.PetType;

namespace Petclinic.Business.Repository.IRepository
{
    public interface IPetTypeRepository
    {
        public IEnumerable<PetTypeDto> GetAllPetTypes();
    }
}