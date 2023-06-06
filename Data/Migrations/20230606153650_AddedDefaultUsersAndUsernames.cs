using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Training_LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4c21bfb - c0d2 - 478a - bf0c - 2a9e2be598e5",
                column: "ConcurrencyStamp",
                value: "cf5f1157-bb55-4930-b33e-c90cb22d9410");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5c21ffb - c0d2 - 478a - bf0c - 2c1e2be598e5",
                column: "ConcurrencyStamp",
                value: "a3c4f14b-2485-4356-b020-7721c4d59783");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69e41bfb - 0ed2 - 558a - bf0c - 2a9e2be747e5",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2f1869eb-cc65-409c-88b1-20dc81bde647", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEPZtJQilYn36xXN61MMfmO6i14Z+YW0QI4nipAbs61wNWIr5iH3S1SDMhSmXM+DITg==", "ba439d10-d219-4b80-b91c-cc296a908fd1", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85c41bfb - c0d2 - 478a - bf0c - 2a9e2be747e5",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5570eb18-8b32-4d82-a9c0-0218a3a50e00", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEC31R9y02lwda1LGBRnqKAivp1LR0szBNyJKiTFnWV0n32VnhoJrdAMg70ynBtsHYA==", "26de4eaa-5bfa-49fd-bce6-07d0a14b10a0", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4c21bfb - c0d2 - 478a - bf0c - 2a9e2be598e5",
                column: "ConcurrencyStamp",
                value: "9a7752bc-8ac7-47c9-92be-d648566d0019");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5c21ffb - c0d2 - 478a - bf0c - 2c1e2be598e5",
                column: "ConcurrencyStamp",
                value: "bc70b7d5-852c-4ab1-9c11-264f74c59c1f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69e41bfb - 0ed2 - 558a - bf0c - 2a9e2be747e5",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "bc9566ec-b2f8-4eb0-b942-410451c839cd", false, null, "AQAAAAEAACcQAAAAEKEwxFTXjfvdEs0vSRGY4IDQwLI0JZ4NKShItughrPH2etPoXbqm3n76fXGxXi/oew==", "6ffbe3b4-2b9f-42ce-aa9e-f9a0526720dc", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85c41bfb - c0d2 - 478a - bf0c - 2a9e2be747e5",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d0ee524c-d76e-4247-8bab-10771a2ae418", false, null, "AQAAAAEAACcQAAAAEAkgWJcSYnFPMDxZks2SDyfVSOytYuxXOFklo4tOJaI9qOi0d4IW6ozEd/Z72GxUeA==", "0ef57c24-81e6-4604-801a-587d92aeecb1", null });
        }
    }
}
