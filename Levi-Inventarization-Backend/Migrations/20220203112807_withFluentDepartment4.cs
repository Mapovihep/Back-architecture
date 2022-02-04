using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Levi_Inventarization_Backend.Migrations
{
    public partial class withFluentDepartment4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("802a9dda-a502-4880-bf64-cb92123a3ff5"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "DepName", new Guid("31b2af95-244a-4415-aceb-1798b44ec963") });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("55ef9d13-5700-451a-bac3-09a9413991de"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), new Guid("802a9dda-a502-4880-bf64-cb92123a3ff5"), "Name2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("55ef9d13-5700-451a-bac3-09a9413991de"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("802a9dda-a502-4880-bf64-cb92123a3ff5"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdateBy" },
                values: new object[] { new Guid("0d87a78f-e562-438e-8eac-f8cc7de72ef2"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "DepName", new Guid("6eafd64c-b672-4aef-81d7-2950f446db14") });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("fac34a7f-ebba-43eb-8153-333288b9375b"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), null, "Name2" });
        }
    }
}
