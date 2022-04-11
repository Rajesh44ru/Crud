using Microsoft.EntityFrameworkCore;
using Startproject.Models;

namespace Startproject.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
      public DbSet<Category> Categories { get; set; }


    }
}
