using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Levi_Inventarization_Backend.Migrations
{
    public partial class addedDataAnnotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Defects_InventoryLots_InventoryEntityId",
                table: "Defects");

            migrationBuilder.DropIndex(
                name: "IX_Defects_InventoryEntityId",
                table: "Defects");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("966e2f88-d8fc-44b0-ae01-59bf54e4193e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b234a8e5-e05b-4bcc-8947-a0490609b1c4"));

            migrationBuilder.AddColumn<Guid>(
                name: "Inventory",
                table: "Defects",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdateBy" },
                values: new object[] { new Guid("2ee3663d-2fbe-4f27-a9b9-c903dbbf6f8e"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "DepName", new Guid("24f95cec-161e-4762-a334-806d70d74d08") });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("e033acda-7f2c-42fe-969f-c9cf92f95714"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), new Guid("2ee3663d-2fbe-4f27-a9b9-c903dbbf6f8e"), "Name2" });

            migrationBuilder.CreateIndex(
                name: "IX_Defects_Inventory",
                table: "Defects",
                column: "Inventory");

            migrationBuilder.AddForeignKey(
                name: "FK_Defects_InventoryLots_Inventory",
                table: "Defects",
                column: "Inventory",
                principalTable: "InventoryLots",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Defects_InventoryLots_Inventory",
                table: "Defects");

            migrationBuilder.DropIndex(
                name: "IX_Defects_Inventory",
                table: "Defects");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e033acda-7f2c-42fe-969f-c9cf92f95714"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("2ee3663d-2fbe-4f27-a9b9-c903dbbf6f8e"));

            migrationBuilder.DropColumn(
                name: "Inventory",
                table: "Defects");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdateBy" },
                values: new object[] { new Guid("b234a8e5-e05b-4bcc-8947-a0490609b1c4"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "DepName", new Guid("1fdf7886-c9e9-43fe-b7ab-9327d9883076") });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("966e2f88-d8fc-44b0-ae01-59bf54e4193e"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), new Guid("b234a8e5-e05b-4bcc-8947-a0490609b1c4"), "Name2" });

            migrationBuilder.CreateIndex(
                name: "IX_Defects_InventoryEntityId",
                table: "Defects",
                column: "InventoryEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Defects_InventoryLots_InventoryEntityId",
                table: "Defects",
                column: "InventoryEntityId",
                principalTable: "InventoryLots",
                principalColumn: "Id");
        }
    }
}
