using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Levi_Inventarization_Backend.Migrations
{
    public partial class changedNamesOfEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UpdateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QRCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventory_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inventory_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inventory_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Setups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Setups_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Setups_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Defects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InventoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Defects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Defects_Inventory_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventory",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "InventoryId", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("11111111-9833-45ca-9017-1ded701ef149"), new DateTime(2022, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "description1", "image1", null, "name1", new Guid("11111111-9833-45ca-9017-1ded701ef149") },
                    { new Guid("22222222-9833-45ca-9017-1ded701ef149"), new DateTime(2022, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "description2", "image2", null, "name2", new Guid("22222222-9833-45ca-9017-1ded701ef149") }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdateBy" },
                values: new object[] { new Guid("4079c2e4-8579-4476-9a45-8dd424a23968"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "DepName", new Guid("068cf2ee-c07c-449d-b04a-7f78958f8605") });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "Id", "Category", "CreatedAt", "DepartmentId", "Name", "Price", "QRCode", "RoomId", "Status", "UpdateBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("051b9d7b-a622-4d5d-bb0d-468317e16743"), "Furniture", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "1", 750, "1", null, false, new Guid("96572b53-a770-4ba3-a61f-76fae194c3c3"), null },
                    { new Guid("0bd17248-41e1-4991-be41-ae060bfd2f34"), "Computers", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "13", 9750, "13", null, false, new Guid("34630812-71a5-44d7-a1b5-cd90174087b8"), null },
                    { new Guid("224cf715-93e8-4fd8-9298-764d9827bad8"), "Computers", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "7", 5250, "7", null, false, new Guid("75f37172-633f-4b21-a818-86b3d63f400d"), null },
                    { new Guid("22a4e63d-bd34-4277-8de5-d7b703485ff4"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "17", 4301, "17", null, false, new Guid("b0e90551-560c-48a9-a9b5-d5f77d999a79"), null },
                    { new Guid("3c8f2d60-fb38-48b6-910f-1e920e679fbb"), "Furniture", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "16", 10400, "16", null, false, new Guid("7b9c8bd4-be69-4d72-8214-d84bf7bff6ac"), null },
                    { new Guid("3d41ef90-be84-492d-b58f-99c097a74ded"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "14", 3542, "14", null, false, new Guid("89171dd0-a549-4aab-8cae-8404caebb5e4"), null },
                    { new Guid("47f147e3-3da9-49a0-897a-6c772b985d84"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "5", 160, "5", null, false, new Guid("9a395175-f4f7-403a-963a-85b335bfecc8"), null },
                    { new Guid("55fce935-f9df-4657-a8fc-725488b31457"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "18", 4554, "18", null, false, new Guid("e73f26c3-d619-4a21-8a67-a327751783c1"), null },
                    { new Guid("5d5e2288-a094-47d1-aaaf-aed90a6c0d9c"), "Computers", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "10", 320, "10", null, false, new Guid("ecfb7e96-ae8a-4cd4-ad05-532cd6e9414b"), null },
                    { new Guid("6e669e7e-3775-4dbb-9158-b69adff930c2"), "Furniture", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "11", 2783, "11", null, false, new Guid("3d81712e-cc87-4044-9ff9-913d8c3f3bb5"), null },
                    { new Guid("72d4e4b5-59b3-4f80-831e-709340cfdaa8"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "8", 5200, "8", null, false, new Guid("1e0c251c-6443-42da-811a-5873a9b1a589"), null },
                    { new Guid("7e3d87e3-efa6-451b-8c2a-13230e8c2807"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "9", 2277, "9", null, false, new Guid("0226f727-f79f-456c-b313-8bf35f54c663"), null },
                    { new Guid("7f6231da-8802-4977-842b-90e69394cb3f"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2", 506, "2", null, false, new Guid("c9703891-fd0f-4d58-b81b-c0afdf6fedd7"), null },
                    { new Guid("94039a14-6141-47ba-b64e-646891089dd8"), "Furniture", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "6", 1518, "6", null, false, new Guid("0cef76f3-0f0a-443a-a827-2254f17f4295"), null },
                    { new Guid("995b6d32-b0ef-4c35-bce0-db1109552b37"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "12", 7800, "12", null, false, new Guid("2f055992-528f-4298-ba6b-2d12aad6f68a"), null },
                    { new Guid("c6cfca97-797f-48e2-b0ce-f735e61f5ab3"), "Computers", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "4", 2600, "4", null, false, new Guid("6cf486b3-6320-484b-aaa0-dd7fb40258d7"), null },
                    { new Guid("c8da1328-8403-439e-9d46-5dcc13b521f0"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "0", 0, "0", null, false, new Guid("6420e4ab-958b-4fe5-82b6-3bb3861696ed"), null },
                    { new Guid("d829adec-c005-4d29-bd6a-168f249b013e"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "15", 480, "15", null, false, new Guid("32b34ad6-1804-4ebf-a3bd-3d144b493a85"), null },
                    { new Guid("f2db931f-7918-48b0-a491-0dc1e26a09bc"), "Computers", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "19", 14250, "19", null, false, new Guid("632f26e7-a2a6-48fd-99c4-2bf3bff32725"), null },
                    { new Guid("ffed5add-2e43-49ed-9171-138d100e036c"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "3", 759, "3", null, false, new Guid("0bf5dc0a-dfa3-46d2-91df-aa8992f5814f"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsAdmin", "LastName", "Name", "Password", "Phone", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("05510482-0605-443e-8271-806902ec15c0"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4409), "0", true, "0", "0", "0", "2", new Guid("15c04130-d682-4375-b34f-5f8e0f1116c4") },
                    { new Guid("22ae9b75-717b-4d99-985f-564c6e0078f5"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4480), "18", true, "18", "18", "18", "16", new Guid("68dca140-9735-4bad-adb3-11d9b79601e1") },
                    { new Guid("256aed38-39b1-4901-8a2a-4aa996257b4b"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4459), "11", false, "11", "11", "11", "9", new Guid("dbdef4ce-2396-4b97-ac64-3233ec5ea1b9") },
                    { new Guid("48a01d0d-9966-47b6-adee-3c134fe502fe"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4447), "7", false, "7", "7", "7", "5", new Guid("272b76ec-83b5-4b89-99cc-d23daacda6ea") },
                    { new Guid("52721195-193a-47e1-8e4e-8a7e87cb8d8b"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4478), "17", false, "17", "17", "17", "19", new Guid("d18b45db-06d3-419a-99d4-94cc27ada1be") },
                    { new Guid("5fb77a76-5eb0-4748-a48b-077a22e9b0da"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4465), "13", false, "13", "13", "13", "15", new Guid("bd056a3b-51dc-41d2-aea2-c6ae9c3c972f") },
                    { new Guid("60ac99ab-4e78-4402-8d33-ccbb5502e071"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4468), "14", true, "14", "14", "14", "12", new Guid("e62d7fb2-d153-4b35-b5f8-235ee9ae929c") },
                    { new Guid("67e778fe-9fa2-4d2b-91f7-98b1ca0c4367"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4429), "1", false, "1", "1", "1", "3", new Guid("dbe025ae-a8cc-4db8-8d48-eedea5e38512") },
                    { new Guid("69ee4e5f-a0ad-429b-a34d-dfb6ce9c8d8b"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4483), "19", false, "19", "19", "19", "17", new Guid("2755d440-35b2-4c5d-85d2-88eeaa0b58a3") },
                    { new Guid("750b8b30-f473-4afc-ac0e-68257e446898"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4436), "4", true, "4", "4", "4", "6", new Guid("a1bd02a3-9c52-49d9-b0f5-4a5b44be428c") },
                    { new Guid("77273e46-7390-4bd5-8b47-c7d8df14ab7b"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4456), "10", true, "10", "10", "10", "8", new Guid("5b6c2679-8330-45e3-9196-248a96175326") },
                    { new Guid("7fa216b4-9ff3-4433-8877-ecf03807eeab"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4461), "12", true, "12", "12", "12", "14", new Guid("39040d4e-a224-44b0-9d5c-5f34b50d50b8") },
                    { new Guid("aaab4f97-a60b-4572-b2cb-5b80ddea7da7"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4473), "16", true, "16", "16", "16", "18", new Guid("33e31e4c-79b0-442c-a546-e35773e79c27") },
                    { new Guid("b6da3c1a-9cb3-42cc-a91f-6b3c47203c68"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4449), "8", true, "8", "8", "8", "10", new Guid("9fd7289a-d492-439b-8200-87e5b73828ef") },
                    { new Guid("bd5c95d2-85d1-438a-ac39-d9ce8c8b96aa"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4431), "2", true, "2", "2", "2", "0", new Guid("60a46e4b-286e-4273-92be-60b3641beb45") },
                    { new Guid("c1901d6a-be0e-43d4-827d-2369c0bc7e81"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4454), "9", false, "9", "9", "9", "11", new Guid("3bd8fa0d-f52c-41fa-ad20-55141a76adc5") },
                    { new Guid("c5fdf333-9ecb-467f-8647-d24aea2d5c34"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4444), "6", true, "6", "6", "6", "4", new Guid("4598f6c4-6b86-4104-b3f4-ffdb99d123bf") },
                    { new Guid("dc086561-55f1-4be9-a075-4c67259a3821"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4434), "3", false, "3", "3", "3", "1", new Guid("0ce29313-c3f7-4f72-955b-53adc34bd060") },
                    { new Guid("decffedc-8213-439f-975b-4eea7f5d487b"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4470), "15", false, "15", "15", "15", "13", new Guid("c582797d-a8e9-478a-bbcb-92130c18c82c") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsAdmin", "LastName", "Name", "Password", "Phone", "UpdateBy" },
                values: new object[] { new Guid("fc2c4214-8696-4e28-a6d7-c83843e9d25c"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4442), "5", false, "5", "5", "5", "7", new Guid("5e19e15f-7fc4-4a2d-ba6e-67fc06c42212") });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Name" },
                values: new object[] { new Guid("ec13f037-ec1a-4507-8db5-88c30c23b52e"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), new Guid("4079c2e4-8579-4476-9a45-8dd424a23968"), "Name2" });

            migrationBuilder.CreateIndex(
                name: "IX_Defects_InventoryId",
                table: "Defects",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_DepartmentId",
                table: "Inventory",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_RoomId",
                table: "Inventory",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_UserId",
                table: "Inventory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_DepartmentId",
                table: "Rooms",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Setups_RoomId",
                table: "Setups",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Setups_UserId",
                table: "Setups",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Defects");

            migrationBuilder.DropTable(
                name: "Setups");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
