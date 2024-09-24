using Microsoft.EntityFrameworkCore;
using EmployeePerformanceApp.Server.Models;
using System.Threading.Tasks;

namespace EmployeePerformanceApp.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define the models/entities to be represented in the database.
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTask> EmployeeTasks { get; set; }
    }
}
