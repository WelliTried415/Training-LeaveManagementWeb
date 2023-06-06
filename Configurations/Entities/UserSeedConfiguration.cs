using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Training_LeaveManagementWeb.Data;

namespace Training_LeaveManagementWeb.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "85c41bfb - c0d2 - 478a - bf0c - 2a9e2be747e5",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    Firstname = "System",
                    Lastname = "Admin",
                    PasswordHash = hasher.HashPassword(null, "P@ssw0rd"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "69e41bfb - 0ed2 - 558a - bf0c - 2a9e2be747e5",
                    Email = "user@localhost.com",
                    NormalizedEmail = "USER@LOCALHOST.COM",
                    UserName = "user@localhost.com",
                    NormalizedUserName = "USER@LOCALHOST.COM",
                    Firstname = "System",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null, "P@ssw0rd"),
                    EmailConfirmed = true
                }
            );
        }
    }
}