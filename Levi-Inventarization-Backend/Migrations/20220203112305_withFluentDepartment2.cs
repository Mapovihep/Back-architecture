using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Levi_Inventarization_Backend.Migrations
{
    public partial class withFluentDepartment2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("47bd47b1-681f-4b92-afbb-8787c5e76cfc"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ca66e9e3-410a-4028-adf4-d063b3fbefb9"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdateBy" },
                values: new object[] { new Guid("269476c8-467b-4690-8a34-08559b1a1811"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "DepName", new Guid("09554fed-55ff-4c29-a372-41ed3d044a12") });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("cba49a84-33cc-433f-8186-c50b08f19913"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), null, "Name2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("269476c8-467b-4690-8a34-08559b1a1811"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("cba49a84-33cc-433f-8186-c50b08f19913"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdateBy" },
                values: new object[] { new Guid("47bd47b1-681f-4b92-afbb-8787c5e76cfc"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "DepName", new Guid("56c854d1-5fe0-4c2e-8d3e-1784995bef84") });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("ca66e9e3-410a-4028-adf4-d063b3fbefb9"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), null, "Name2" });
        }
    }
}
