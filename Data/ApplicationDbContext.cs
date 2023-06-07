using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Training_LeaveManagementWeb.Configurations.Entities;
using Training_LeaveManagementWeb.Models;

namespace Training_LeaveManagementWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }

        public DbSet<LeaveType> LeaveTypes { get; set; } //create collection of these types, in the database it means create a table called LeaveTypes, modeled after LeaveType
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; } 
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
    }
}