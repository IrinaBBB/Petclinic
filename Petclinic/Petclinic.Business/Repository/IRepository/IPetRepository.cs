using System.Collections.Generic;
using System.Threading.Tasks;
using Petclinic.Models.Pet;

namespace Petclinic.Business.Repository.IRepository
{
    public interface IPetRepository
    {
        public Task<PetDto> CreatePet(PetDto petDto);
        public Task<PetDto> UpdatePet(int petId, PetDto petDto);
        public Task<PetDto> DeletePet(int petId);
        public Task<PetDto> GetPet(int petId);
        public IEnumerable<PetDto> GetAllPets();
    }
}