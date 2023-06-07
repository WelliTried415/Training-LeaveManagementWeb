using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Training_LeaveManagementWeb.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4c21bfb - c0d2 - 478a - bf0c - 2a9e2be598e5",
                column: "ConcurrencyStamp",
                value: "6ee5a39d-4a9c-41a1-ba02-fe7979dacbb6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5c21ffb - c0d2 - 478a - bf0c - 2c1e2be598e5",
                column: "ConcurrencyStamp",
                value: "fd9ed4a4-13a7-40cd-af4f-dd7467764db2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69e41bfb - 0ed2 - 558a - bf0c - 2a9e2be747e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41b6234a-ace3-4ff1-b007-b21319ddc993", "AQAAAAEAACcQAAAAEAhtBUsE5aFXS6hkvGR2M8lFTuoe4bEB9K9kmblgTYwPZU6Kte39SN/VpbdnIKA+Wg==", "3a313d0a-78d1-4937-9626-33ac2dbd7e79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85c41bfb - c0d2 - 478a - bf0c - 2a9e2be747e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d18b5e2d-4723-4777-a9d7-bfebf6504d40", "AQAAAAEAACcQAAAAEDq81bfJNGmXGnjWfiD+ll2DaCXT2j/bEX+cFQopMvvW6UJP/a0MnbMm+j5gAlN8eA==", "b0f789a6-2a66-4d05-bbd7-547c129c9cb1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4c21bfb - c0d2 - 478a - bf0c - 2a9e2be598e5",
                column: "ConcurrencyStamp",
                value: "58146462-05de-4871-a6fe-6bc6fb1be156");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5c21ffb - c0d2 - 478a - bf0c - 2c1e2be598e5",
                column: "ConcurrencyStamp",
                value: "fa7626e6-4d7a-48f6-9c7e-d39d3909683b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69e41bfb - 0ed2 - 558a - bf0c - 2a9e2be747e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88b66edb-3b68-4bdc-adee-38e3c8c5dfa1", "AQAAAAEAACcQAAAAEJZBxbZbZgwIsVpzfv++WenS/5k9pEs+qGLM+OMaptZ/E4LkQO2Go+JLf02HBw5tBg==", "09c5777c-1118-44e9-8361-00a3e511c9d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85c41bfb - c0d2 - 478a - bf0c - 2a9e2be747e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bdb4ae2-b0ae-46ae-8dd7-b1d1a8c3ac57", "AQAAAAEAACcQAAAAEAW9tJVeazAuHMU+DaXfB2CHEF5k5fONGi/40EdSwrYjobhnBiNq07GoDMLDAkviRA==", "5deb8e5a-c355-45df-9116-bbf3eec30a4e" });
        }
    }
}
