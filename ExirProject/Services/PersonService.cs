using ExirProject.Data;
using ExirProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ExirProject.Services
{
    public class PersonService : IPersonService
    {
        private readonly ApplicationDbContext dbContext;

        public PersonService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Person> AddAsync(Person person)
        {
            await dbContext.Persons.AddAsync(person);
            await dbContext.SaveChangesAsync();
            return person;
        }

        public async Task DeleteAsync(Person person)
        {
            dbContext.Persons.Remove(person);
            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> ExistsByNationalCode(string nationalCode)
        {
            return await dbContext.Persons.AnyAsync( p => p.NationalCode == nationalCode);
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await dbContext.Persons.ToListAsync();
        }

        public Task<Person?> GetByIdAsync(int id)
        {
            return dbContext.Persons.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Person>?> SearchPersonAsync(string searchTerm)
        {
            return await dbContext.Persons.Where(p => p.NationalCode.Contains(searchTerm)).ToListAsync();
        }

        public async Task UpdateAsync(Person person)
        {
            dbContext.Persons.Update(person);
            await dbContext.SaveChangesAsync();
        }
    }
}
