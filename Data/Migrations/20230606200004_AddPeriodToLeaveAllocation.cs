using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Training_LeaveManagementWeb.Data.Migrations
{
    public partial class AddPeriodToLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4c21bfb - c0d2 - 478a - bf0c - 2a9e2be598e5",
                column: "ConcurrencyStamp",
                value: "6147b5c0-3839-4c84-b145-6467f82f2997");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5c21ffb - c0d2 - 478a - bf0c - 2c1e2be598e5",
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "326dd846-8c3a-44e7-8512-0512415791f3", "User" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69e41bfb - 0ed2 - 558a - bf0c - 2a9e2be747e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ce0d18f-14e3-4b51-bd5e-26917f1eae0c", "AQAAAAEAACcQAAAAEOy5XSUtoDDKqqNaEa8ERXR+XDOePUAPBPnE25G5+Pgow5nDC48xihVJw8ImWI+fcw==", "8b03f316-8437-4cb7-b313-8ca2cea8ad1d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85c41bfb - c0d2 - 478a - bf0c - 2a9e2be747e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b06a996-606a-4596-80d8-98f915911bde", "AQAAAAEAACcQAAAAENcfv4CDTPukbgmFxn/H03k2Zx71Jz5MzgvXIci/OP8u0Plztk08g12sxraFF6wl3w==", "8cb5a2b7-1c29-4a14-bc0b-90f22839a9b0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "a3c4f14b-2485-4356-b020-7721c4d59783", "user" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69e41bfb - 0ed2 - 558a - bf0c - 2a9e2be747e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f1869eb-cc65-409c-88b1-20dc81bde647", "AQAAAAEAACcQAAAAEPZtJQilYn36xXN61MMfmO6i14Z+YW0QI4nipAbs61wNWIr5iH3S1SDMhSmXM+DITg==", "ba439d10-d219-4b80-b91c-cc296a908fd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85c41bfb - c0d2 - 478a - bf0c - 2a9e2be747e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5570eb18-8b32-4d82-a9c0-0218a3a50e00", "AQAAAAEAACcQAAAAEC31R9y02lwda1LGBRnqKAivp1LR0szBNyJKiTFnWV0n32VnhoJrdAMg70ynBtsHYA==", "26de4eaa-5bfa-49fd-bce6-07d0a14b10a0" });
        }
    }
}
