using Microsoft.EntityFrameworkCore;
using WebApiPersonPractice.Models;

namespace WebApiPersonPractice.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        

        public DbSet<Person> Persons { get; set; }
    }
}
