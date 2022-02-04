using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Levi_Inventarization_Backend.Migrations
{
    public partial class withFluentDepartment6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryLots_Rooms_RoomEntityId",
                table: "InventoryLots");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryLots_Users_UserEntityId",
                table: "InventoryLots");

            migrationBuilder.DropForeignKey(
                name: "FK_Setups_Rooms_RoomEntityId",
                table: "Setups");

            migrationBuilder.DropForeignKey(
                name: "FK_Setups_Users_UserEntityId",
                table: "Setups");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ff8f171f-3723-4896-a857-53a2b1273895"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("6e99923a-e4ce-487d-a981-a6ae2e6bb136"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserEntityId",
                table: "Setups",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomEntityId",
                table: "Setups",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserEntityId",
                table: "InventoryLots",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomEntityId",
                table: "InventoryLots",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdateBy" },
                values: new object[] { new Guid("b234a8e5-e05b-4bcc-8947-a0490609b1c4"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "DepName", new Guid("1fdf7886-c9e9-43fe-b7ab-9327d9883076") });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("966e2f88-d8fc-44b0-ae01-59bf54e4193e"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), new Guid("b234a8e5-e05b-4bcc-8947-a0490609b1c4"), "Name2" });

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryLots_Rooms_RoomEntityId",
                table: "InventoryLots",
                column: "RoomEntityId",
                principalTable: "Rooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryLots_Users_UserEntityId",
                table: "InventoryLots",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Setups_Rooms_RoomEntityId",
                table: "Setups",
                column: "RoomEntityId",
                principalTable: "Rooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Setups_Users_UserEntityId",
                table: "Setups",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryLots_Rooms_RoomEntityId",
                table: "InventoryLots");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryLots_Users_UserEntityId",
                table: "InventoryLots");

            migrationBuilder.DropForeignKey(
                name: "FK_Setups_Rooms_RoomEntityId",
                table: "Setups");

            migrationBuilder.DropForeignKey(
                name: "FK_Setups_Users_UserEntityId",
                table: "Setups");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("966e2f88-d8fc-44b0-ae01-59bf54e4193e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("b234a8e5-e05b-4bcc-8947-a0490609b1c4"));

            migrationBuilder.AlterColumn<Guid>(
                name: "UserEntityId",
                table: "Setups",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomEntityId",
                table: "Setups",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "UserEntityId",
                table: "InventoryLots",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomEntityId",
                table: "InventoryLots",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdateBy" },
                values: new object[] { new Guid("6e99923a-e4ce-487d-a981-a6ae2e6bb136"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "DepName", new Guid("20418444-0b78-4d73-9cfe-75b4aecdab93") });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentEntityId", "Name" },
                values: new object[] { new Guid("ff8f171f-3723-4896-a857-53a2b1273895"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), new Guid("6e99923a-e4ce-487d-a981-a6ae2e6bb136"), "Name2" });

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryLots_Rooms_RoomEntityId",
                table: "InventoryLots",
                column: "RoomEntityId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryLots_Users_UserEntityId",
                table: "InventoryLots",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Setups_Rooms_RoomEntityId",
                table: "Setups",
                column: "RoomEntityId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Setups_Users_UserEntityId",
                table: "Setups",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
