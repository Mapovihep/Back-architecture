using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Levi_Inventarization_Backend.Migrations
{
    public partial class nullableEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Defects_InventoryLots_InventoryEntityId",
                table: "Defects");

            migrationBuilder.AlterColumn<Guid>(
                name: "InventoryEntityId",
                table: "Defects",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "InventoryEntityId", "Name", "UpdateBy" },
                values: new object[] { new Guid("11111111-9833-45ca-9017-1ded701ef149"), new DateTime(2022, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "description1", "image1", null, "name1", new Guid("11111111-9833-45ca-9017-1ded701ef149") });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "InventoryEntityId", "Name", "UpdateBy" },
                values: new object[] { new Guid("22222222-9833-45ca-9017-1ded701ef149"), new DateTime(2022, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "description2", "image2", null, "name2", new Guid("22222222-9833-45ca-9017-1ded701ef149") });

            migrationBuilder.AddForeignKey(
                name: "FK_Defects_InventoryLots_InventoryEntityId",
                table: "Defects",
                column: "InventoryEntityId",
                principalTable: "InventoryLots",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Defects_InventoryLots_InventoryEntityId",
                table: "Defects");

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9833-45ca-9017-1ded701ef149"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("22222222-9833-45ca-9017-1ded701ef149"));

            migrationBuilder.AlterColumn<Guid>(
                name: "InventoryEntityId",
                table: "Defects",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Defects_InventoryLots_InventoryEntityId",
                table: "Defects",
                column: "InventoryEntityId",
                principalTable: "InventoryLots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
