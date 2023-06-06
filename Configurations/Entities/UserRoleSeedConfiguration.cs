using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Training_LeaveManagementWeb.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "d4c21bfb - c0d2 - 478a - bf0c - 2a9e2be598e5",
                    UserId = "85c41bfb - c0d2 - 478a - bf0c - 2a9e2be747e5"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "e5c21ffb - c0d2 - 478a - bf0c - 2c1e2be598e5",
                    UserId = "69e41bfb - 0ed2 - 558a - bf0c - 2a9e2be747e5"
                }

            );
        }
    }
}