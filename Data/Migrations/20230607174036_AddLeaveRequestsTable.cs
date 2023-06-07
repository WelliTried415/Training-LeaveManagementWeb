using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Training_LeaveManagementWeb.Data.Migrations
{
    public partial class AddLeaveRequestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
                column: "ConcurrencyStamp",
                value: "326dd846-8c3a-44e7-8512-0512415791f3");

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
    }
}
