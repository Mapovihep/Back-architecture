using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Levi_Inventarization_Backend.Migrations
{
    public partial class withFluentDepartment5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("6e99923a-e4ce-487d-a981-a6ae2e6bb136"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "DepName", new Guid("20418444-0b78-4d73-9cfe-75b4aecdab93") });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("ff8f171f-3723-4896-a857-53a2b1273895"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), new Guid("6e99923a-e4ce-487d-a981-a6ae2e6bb136"), "Name2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ff8f171f-3723-4896-a857-53a2b1273895"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6e99923a-e4ce-487d-a981-a6ae2e6bb136"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdateBy" },
                values: new object[] { new Guid("802a9dda-a502-4880-bf64-cb92123a3ff5"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "DepName", new Guid("31b2af95-244a-4415-aceb-1798b44ec963") });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("55ef9d13-5700-451a-bac3-09a9413991de"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), new Guid("802a9dda-a502-4880-bf64-cb92123a3ff5"), "Name2" });
        }
    }
}
