using ExirProject.Models;

namespace ExirProject.Services
{
    public interface IPersonService
    {
        Task<List<Person>> GetAllAsync();
        Task<Person> AddAsync(Person person);
        Task<bool> ExistsByNationalCode(string nationalCode);
        Task<Person?> GetByIdAsync(int id);
        Task UpdateAsync(Person person);
        Task DeleteAsync(Person person);
        Task<List<Person>?> SearchPersonAsync(string searchTerm);
    }
}
