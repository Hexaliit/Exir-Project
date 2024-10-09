using ExirProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ExirProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}
