using Microsoft.EntityFrameworkCore;
using Models;

namespace EmployeeDirectory.API
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext>options) :base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
