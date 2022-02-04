using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Levi_Inventarization_Backend.Migrations
{
    public partial class addedFluentModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("180b1fe7-3dbd-4b44-9703-a193d7f60147"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Name3" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("2f6827a3-45eb-4105-b072-a8044deb204b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Name2" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("8e7f532c-4ebb-4b5f-acc8-b0ebec0fdfa6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Name1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("180b1fe7-3dbd-4b44-9703-a193d7f60147"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("2f6827a3-45eb-4105-b072-a8044deb204b"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("8e7f532c-4ebb-4b5f-acc8-b0ebec0fdfa6"));
        }
    }
}
