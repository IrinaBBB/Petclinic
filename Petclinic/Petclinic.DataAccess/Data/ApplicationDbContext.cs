using Microsoft.EntityFrameworkCore;
using Petclinic.DataAccess.Entities;

namespace Petclinic.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<PetType> PetTypes { get; set; }
        public DbSet<Pet> Pets { get; set; }
    }
}
