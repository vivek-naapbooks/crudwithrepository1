using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CRUDWITHREPOSITORY.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

    }
}
