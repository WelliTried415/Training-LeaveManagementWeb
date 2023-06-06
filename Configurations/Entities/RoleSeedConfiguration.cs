using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Training_LeaveManagementWeb.Constants;

namespace Training_LeaveManagementWeb.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData( //creating roles for posible user roles, callled seeding
                new IdentityRole
                {
                    Id = "d4c21bfb - c0d2 - 478a - bf0c - 2a9e2be598e5",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "e5c21ffb - c0d2 - 478a - bf0c - 2c1e2be598e5",
                    Name = Roles.User,
                    NormalizedName = Roles.Administrator.ToUpper()
                }
            );
        }
    }
}


