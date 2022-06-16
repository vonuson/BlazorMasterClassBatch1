using EmployeeManagementPortal.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementPortal.Server
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options)
            : base(options)
        {
        }

        public DbSet<Sample> Samples { get; set; } = null!;
    }
}
