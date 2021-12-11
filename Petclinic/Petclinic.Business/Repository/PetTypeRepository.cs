using System.Collections.Generic;
using AutoMapper;
using Petclinic.Business.Repository.IRepository;
using Petclinic.DataAccess.Data;
using Petclinic.DataAccess.Entities;
using Petclinic.Models.PetType;

namespace Petclinic.Business.Repository
{
    public class PetTypeRepository : IPetTypeRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public PetTypeRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<PetTypeDto> GetAllPetTypes()
        {
            return _mapper.Map<IEnumerable<PetType>, IEnumerable<PetTypeDto>>(_context.PetTypes);
        }
    }
}