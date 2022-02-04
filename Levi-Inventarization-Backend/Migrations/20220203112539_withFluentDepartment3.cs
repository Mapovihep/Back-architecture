using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Levi_Inventarization_Backend.Migrations
{
    public partial class withFluentDepartment3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("0d87a78f-e562-438e-8eac-f8cc7de72ef2"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "DepName", new Guid("6eafd64c-b672-4aef-81d7-2950f446db14") });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("fac34a7f-ebba-43eb-8153-333288b9375b"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), null, "Name2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("0d87a78f-e562-438e-8eac-f8cc7de72ef2"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fac34a7f-ebba-43eb-8153-333288b9375b"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdateBy" },
                values: new object[] { new Guid("269476c8-467b-4690-8a34-08559b1a1811"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "DepName", new Guid("09554fed-55ff-4c29-a372-41ed3d044a12") });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("cba49a84-33cc-433f-8186-c50b08f19913"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), null, "Name2" });
        }
    }
}
