using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Training_LeaveManagementWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<LeaveType> LeaveTypes { get; set; } //create collection of these types, in the database it means create a table called LeaveTypes, modeled after LeaveType
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; } 
    }
}