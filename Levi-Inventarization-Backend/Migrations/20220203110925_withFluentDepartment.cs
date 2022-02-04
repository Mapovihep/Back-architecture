using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Levi_Inventarization_Backend.Migrations
{
    public partial class withFluentDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("becf5741-19a9-4713-a735-b60c35e81a1e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("d6ffaed9-2f80-40a7-9a46-63afe018b355"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e9c42692-bc7b-4133-a74d-d0c9f1b5267d"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdateBy" },
                values: new object[] { new Guid("47bd47b1-681f-4b92-afbb-8787c5e76cfc"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "DepName", new Guid("56c854d1-5fe0-4c2e-8d3e-1784995bef84") });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("ca66e9e3-410a-4028-adf4-d063b3fbefb9"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), null, "Name2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("becf5741-19a9-4713-a735-b60c35e81a1e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Name3" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("d6ffaed9-2f80-40a7-9a46-63afe018b355"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Name2" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("e9c42692-bc7b-4133-a74d-d0c9f1b5267d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Name1" });
        }
    }
}
