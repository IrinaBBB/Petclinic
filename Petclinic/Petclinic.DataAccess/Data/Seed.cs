using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Petclinic.DataAccess.Entities;

namespace Petclinic.DataAccess.Data
{
    public class Seed
    {
        public static async Task SeedData(ApplicationDbContext context)
        {
            if (await context.PetTypes.AnyAsync() && await context.PetTypes.AnyAsync()) return;

            var petTypesData = await System.IO.File.ReadAllTextAsync("SeedData.json");
            var petTypes = JsonSerializer.Deserialize<List<PetType>>(petTypesData);


            if (petTypes != null) await context.AddRangeAsync(petTypes);
            await context.SaveChangesAsync();
        }
    }
}