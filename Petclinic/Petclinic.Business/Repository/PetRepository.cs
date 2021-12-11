using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Petclinic.Business.Repository.IRepository;
using Petclinic.DataAccess.Data;
using Petclinic.DataAccess.Entities;
using Petclinic.Models.Pet;

namespace Petclinic.Business.Repository
{
    public class PetRepository : IPetRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PetRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PetDto> CreatePet(PetDto petDto)
        {
            var addedPet = await _context.Pets
                .AddAsync(_mapper.Map<PetDto, Pet>(petDto));
            await _context.SaveChangesAsync();
            return _mapper.Map<Pet, PetDto>(addedPet.Entity);
        }

        public async Task<PetDto> UpdatePet(int petId, PetDto petDto)
        {
            if (petId != petDto.Id) return null;

            var pet = await _context.Pets.FindAsync(petId);
            var petUpdated = _mapper.Map(petDto, pet);

            _context.Pets.Update(petUpdated);
            await _context.SaveChangesAsync();

            return _mapper.Map<Pet, PetDto>(petUpdated);
        }

        public async Task<PetDto> DeletePet(int petId)
        {
            var petToDelete = await _context.Pets.FirstOrDefaultAsync(p => p.Id == petId);

            if (petToDelete == null) return null;
            
            _context.Pets.Remove(petToDelete);
            await _context.SaveChangesAsync();
            return _mapper.Map<Pet, PetDto>(petToDelete);
        }

        public async Task<PetDto> GetPet(int petId)
        {
            return _mapper.Map<Pet, PetDto>(await _context.Pets.FirstOrDefaultAsync(p => p.Id == petId));
        }

        public IEnumerable<PetDto> GetAllPets()
        {
            return _mapper.Map<IEnumerable<Pet>, IEnumerable<PetDto>>(_context.Pets);
        }
    }
}