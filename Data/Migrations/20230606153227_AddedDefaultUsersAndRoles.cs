using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Training_LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d4c21bfb - c0d2 - 478a - bf0c - 2a9e2be598e5", "9a7752bc-8ac7-47c9-92be-d648566d0019", "Administrator", "ADMINISTRATOR" },
                    { "e5c21ffb - c0d2 - 478a - bf0c - 2c1e2be598e5", "bc70b7d5-852c-4ab1-9c11-264f74c59c1f", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "69e41bfb - 0ed2 - 558a - bf0c - 2a9e2be747e5", 0, "bc9566ec-b2f8-4eb0-b942-410451c839cd", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEKEwxFTXjfvdEs0vSRGY4IDQwLI0JZ4NKShItughrPH2etPoXbqm3n76fXGxXi/oew==", null, false, "6ffbe3b4-2b9f-42ce-aa9e-f9a0526720dc", null, false, null },
                    { "85c41bfb - c0d2 - 478a - bf0c - 2a9e2be747e5", 0, "d0ee524c-d76e-4247-8bab-10771a2ae418", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEAkgWJcSYnFPMDxZks2SDyfVSOytYuxXOFklo4tOJaI9qOi0d4IW6ozEd/Z72GxUeA==", null, false, "0ef57c24-81e6-4604-801a-587d92aeecb1", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e5c21ffb - c0d2 - 478a - bf0c - 2c1e2be598e5", "69e41bfb - 0ed2 - 558a - bf0c - 2a9e2be747e5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d4c21bfb - c0d2 - 478a - bf0c - 2a9e2be598e5", "85c41bfb - c0d2 - 478a - bf0c - 2a9e2be747e5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e5c21ffb - c0d2 - 478a - bf0c - 2c1e2be598e5", "69e41bfb - 0ed2 - 558a - bf0c - 2a9e2be747e5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d4c21bfb - c0d2 - 478a - bf0c - 2a9e2be598e5", "85c41bfb - c0d2 - 478a - bf0c - 2a9e2be747e5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4c21bfb - c0d2 - 478a - bf0c - 2a9e2be598e5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5c21ffb - c0d2 - 478a - bf0c - 2c1e2be598e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69e41bfb - 0ed2 - 558a - bf0c - 2a9e2be747e5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85c41bfb - c0d2 - 478a - bf0c - 2a9e2be747e5");
        }
    }
}
