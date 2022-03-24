using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Levi_Inventarization_Backend.Migrations
{
    public partial class AllMockRestored : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Defects_Inventory_InventoryId",
                table: "Defects");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Rooms_RoomId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Users_UserId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Setups_Rooms_RoomId",
                table: "Setups");

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("11111111-9833-45ca-9017-1ded701ef149"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("1c3f0894-eff9-4215-8742-aa7bd34b9753"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("03ee0159-4f58-4079-9569-f60cdc652799"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("06db4e81-8476-4cd5-a5e3-f0c096cebf71"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("2358f731-90fa-4a84-824a-0cb607948fbe"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("248e4cf2-7b40-4a04-8012-aa33aaa00bca"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("262cba63-b5a8-462d-8be6-b72e869edcb7"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("37ab16cc-9fd6-4bfc-babf-e55d78d7ed2a"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("3f91b518-f08a-440f-9a85-78a66f5ecaf3"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("4aae605f-333c-4f10-80f8-b3e10f8f3e63"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("4d1c78f5-0044-4929-8a9f-aaaea7b3e509"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("4fe9245f-46ae-4aa6-b9a3-b1dbbd72b577"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("614596ee-465a-4ec6-9cf9-09100e90b1a8"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("66eb5e88-078a-4d81-8ee4-5b1b373fcfe3"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("8400bb6f-0971-4133-b1b2-03793cea7045"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("971512a9-d549-44ad-8e79-d3ad86719c60"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("999b7d83-56de-4665-983b-8921d737d7e1"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("a50d6370-dff3-4893-a867-a682e9545b0d"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("b1005bdd-2531-462c-b4e6-cf50e29b29ad"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("b348199a-f684-4dee-97a8-2fe106c637ea"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("b60e07e1-2f88-4404-a635-081333310bb9"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("c7bae62a-4720-40bd-931c-dd091d8e3fe0"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("cf531c63-ecb8-4da7-b42a-f087ece8c678"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("cffd5201-763e-47c0-b5fd-065049f1b6df"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("d05d379e-0700-4d9c-9851-c062c0b9fddc"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("da142d7a-809d-4743-8aef-decb1b822021"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("dd0cb3df-6294-4953-9d82-41550ac42fda"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("f3fc66d6-e173-4163-b93d-7d255b493ab1"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("f4d9f222-f88d-4c99-be9f-67e767fcfe88"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("f7fffacb-7add-449a-b86b-a701d5cb52e4"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("fa1e3596-898d-424d-af06-b1a0271a0fbe"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("fd1651a0-8e3c-4e87-9b92-efc39dd571b6"));

            migrationBuilder.DeleteData(
                table: "Setups",
                keyColumn: "Id",
                keyValue: new Guid("2aadefab-7a22-422e-875c-bc0bfd63515a"));

            migrationBuilder.DeleteData(
                table: "Setups",
                keyColumn: "Id",
                keyValue: new Guid("a74f0a5c-e6bf-4a72-a15d-f4bdad14bed8"));

            migrationBuilder.DeleteData(
                table: "Setups",
                keyColumn: "Id",
                keyValue: new Guid("f37f31e2-d2e5-4d79-8585-e72b2d308661"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1437c9ec-84e1-42ec-bda5-58ce8d6c9e5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1a221a03-3bc5-4d60-a4de-94678877e797"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ccffad2-5f15-4cde-93a8-8428280ef6d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3ec7ce50-f5c2-4bc0-a87c-6e1a29811101"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4544df78-67d6-4884-ba72-211d32a25f54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4dab4c07-cda5-4724-8f7b-53f0ee2a04a3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6737c2f7-afc0-4004-91d7-196de556e80e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a15c417c-77a7-4230-9165-81166fde3ca8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c323a3c7-33b5-428b-bc02-d9d0820dc18c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d5179cdb-710b-4fb9-9769-cb294a9e731f"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdateBy" },
                values: new object[] { new Guid("8fa68195-80f6-45f4-a037-464e7d1aec30"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "Office Department", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") });

            migrationBuilder.InsertData(
                table: "Setups",
                columns: new[] { "Id", "Category", "CreatedAt", "Name", "QRCode", "RoomId", "RoomName", "Status", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), "WorkPlaces", new DateTime(2022, 3, 23, 18, 42, 8, 661, DateTimeKind.Local).AddTicks(4910), "Ruby Work Desk", "QRCodeRuby", null, "QdwGKbCOqw", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4"), null },
                    { new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), "WorkPlaces", new DateTime(2022, 3, 23, 18, 42, 8, 661, DateTimeKind.Local).AddTicks(4952), "Node Work Desk", "QRCodeNode", null, "wKzUkgIEKK", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4"), null },
                    { new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), "WorkPlaces", new DateTime(2022, 3, 23, 18, 42, 8, 661, DateTimeKind.Local).AddTicks(4959), ".Net Work Desk", "QRCode.Net", null, "kMNwdkPuSH", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsAdmin", "LastName", "Name", "Password", "Phone", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("17b0da6b-6409-4055-b7d7-51af0a0ba928"), new DateTime(2022, 3, 23, 18, 42, 8, 661, DateTimeKind.Local).AddTicks(4763), "2", false, "Ai", "yI", "2", "0", new Guid("24373cb6-694c-46be-9de4-4467e8d2ad94") },
                    { new Guid("5160f8ba-8747-468e-8875-0266aef4673a"), new DateTime(2022, 3, 23, 18, 42, 8, 661, DateTimeKind.Local).AddTicks(4809), "7", false, "hqDqyTZ", "GBwazJA", "7", "5", new Guid("b88aaed6-17d9-447f-82a7-e4dec5d52e50") },
                    { new Guid("750b202a-486a-45ff-8a97-d20fd285b59f"), new DateTime(2022, 3, 23, 18, 42, 8, 661, DateTimeKind.Local).AddTicks(4792), "5", false, "YTXRd", "zJMJw", "5", "7", new Guid("27f31a59-3527-4075-91f5-97e8b8c5047c") },
                    { new Guid("856462f3-5148-4dc5-8a62-376294a0784c"), new DateTime(2022, 3, 23, 18, 42, 8, 661, DateTimeKind.Local).AddTicks(4709), "1", false, "n", "N", "1", "3", new Guid("b67a49c3-2c1f-455b-bb81-f87a96098d4e") },
                    { new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853"), new DateTime(2022, 3, 23, 18, 42, 8, 661, DateTimeKind.Local).AddTicks(4653), "0", true, "", "", "0", "2", new Guid("f833d644-fb78-4b95-b703-dafd5803149a") },
                    { new Guid("ca646c40-ca29-4d6e-8a7d-6ee543b3c4ad"), new DateTime(2022, 3, 23, 18, 42, 8, 661, DateTimeKind.Local).AddTicks(4783), "4", false, "oyzm", "yrzj", "4", "6", new Guid("82583c71-b4d9-48cd-8ef5-62f94d64d00b") },
                    { new Guid("cb3fe331-0113-4a25-b6d8-a70f83ab1c30"), new DateTime(2022, 3, 23, 18, 42, 8, 661, DateTimeKind.Local).AddTicks(4817), "8", false, "CahBsvVw", "KuzDQbbn", "8", "10", new Guid("f9af417c-32c8-48af-9dd6-c6381fe8ff60") },
                    { new Guid("df84fff7-56a1-456b-a25e-3625ae48b223"), new DateTime(2022, 3, 23, 18, 42, 8, 661, DateTimeKind.Local).AddTicks(4799), "6", true, "rmnWVo", "CLXPMz", "6", "4", new Guid("c60ac25c-9aa6-4f71-8669-8cab42cd1046") },
                    { new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4"), new DateTime(2022, 3, 23, 18, 42, 8, 661, DateTimeKind.Local).AddTicks(4827), "10", true, "FOMdGlQWbA", "KXbqDcSeXZ", "10", "10", new Guid("c8ee419c-70e3-4ab9-a333-ae10e424b47b") },
                    { new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22"), new DateTime(2022, 3, 23, 18, 42, 8, 661, DateTimeKind.Local).AddTicks(4776), "3", true, "ATR", "vGV", "3", "1", new Guid("3422d49b-13f7-4832-ab36-0cfc2e4106d4") }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Name" },
                values: new object[] { new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new DateTime(2022, 3, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8fa68195-80f6-45f4-a037-464e7d1aec30"), "Node" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Name" },
                values: new object[] { new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8fa68195-80f6-45f4-a037-464e7d1aec30"), "Ruby" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Name" },
                values: new object[] { new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new DateTime(2022, 3, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8fa68195-80f6-45f4-a037-464e7d1aec30"), ".Net" });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "Id", "Category", "CreatedAt", "DepartmentId", "Name", "Price", "QRCode", "RoomId", "SetupId", "Status", "UpdateBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("020c384a-0253-405a-8380-85291093d718"), "Kitchen", new DateTime(2022, 3, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), null, "CeiuoeVj", 2880, "QR 90", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("14538d63-f1c1-4b9a-9f3c-4c91150da435"), new Guid("ca646c40-ca29-4d6e-8a7d-6ee543b3c4ad") },
                    { new Guid("0436d6e8-4c19-48bb-b431-a8892aa41325"), "Kitchen", new DateTime(2022, 3, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), null, "vAxqIihk", 3542, "QR 14", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("aa398eea-8559-46c3-a067-470bd7cf2c45"), new Guid("5160f8ba-8747-468e-8875-0266aef4673a") },
                    { new Guid("04b5ac9a-b9b4-47f7-ab51-6a4caf95fc22"), "Computers", new DateTime(2022, 2, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), null, "eavXqYSU", 72800, "QR 112", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("cba83452-ce14-47c6-9541-ff5f729a4dee"), new Guid("cb3fe331-0113-4a25-b6d8-a70f83ab1c30") },
                    { new Guid("0e88a26e-e8ed-4692-b4ce-c0c6aa8adf9f"), "Computers", new DateTime(2022, 2, 27, 14, 0, 0, 0, DateTimeKind.Unspecified), null, "nVAriTCn", 4160, "QR 130", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("b9e7af18-b9a6-41af-9d58-6fcf464027d7"), new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("0f5a2762-57eb-416d-96fa-e193da476a20"), "Computers", new DateTime(2022, 2, 25, 2, 0, 0, 0, DateTimeKind.Unspecified), null, "fFZKbEPJ", 6080, "QR 190", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("a0e0d363-a00f-4391-b250-8282ceeb6530"), new Guid("ca646c40-ca29-4d6e-8a7d-6ee543b3c4ad") },
                    { new Guid("0f932b91-1f8a-4667-bc3d-a77d664a5c01"), "Computers", new DateTime(2022, 3, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), null, "EIeNrRSL", 5250, "QR 7", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("db5b6d15-e5b1-406e-8e04-7f11b7eccde8"), new Guid("856462f3-5148-4dc5-8a62-376294a0784c") },
                    { new Guid("14ff9088-78f2-4599-8a17-40a81f4b4942"), "Furniture", new DateTime(2022, 3, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), null, "TXyIKkXu", 10373, "QR 41", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("cf7a9554-ffd1-480f-a6e8-d03baba6bd50"), new Guid("856462f3-5148-4dc5-8a62-376294a0784c") },
                    { new Guid("15042df4-be62-42b8-b283-5a22d2a42d2e"), "Kitchen", new DateTime(2022, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), null, "sIWPqkXs", 33902, "QR 134", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("1ce9b552-d2fa-4c1b-be1c-45d14cfd7af1"), new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("17e7898b-81a1-4966-8a5e-731abb2cb993"), "Kitchen", new DateTime(2022, 2, 28, 6, 0, 0, 0, DateTimeKind.Unspecified), null, "ygPjgCzn", 28842, "QR 114", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("dc56ac62-441e-4922-b21f-cebafb9cefb1"), new Guid("cb3fe331-0113-4a25-b6d8-a70f83ab1c30") },
                    { new Guid("180c633b-5b7f-4b67-8daa-564895633320"), "Kitchen", new DateTime(2022, 3, 4, 1, 0, 0, 0, DateTimeKind.Unspecified), null, "eRBvpWRS", 5819, "QR 23", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("d5221de0-888a-4eaf-90e6-05ace5bd0fe3"), new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("18a1762a-fd36-4b5e-95b0-a1c6679cf22f"), "Computers", new DateTime(2022, 2, 25, 23, 0, 0, 0, DateTimeKind.Unspecified), null, "ZFQKFeXV", 126750, "QR 169", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("3335ee29-1d21-42af-8727-769b0cd1e9b0"), new Guid("750b202a-486a-45ff-8a97-d20fd285b59f") },
                    { new Guid("19d4b69a-7438-419d-8d82-3228cd4a8470"), "Kitchen", new DateTime(2022, 2, 27, 22, 0, 0, 0, DateTimeKind.Unspecified), null, "bvdRGpdJ", 30866, "QR 122", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("ca474a23-27f5-4b9e-a294-58c55bf92fd9"), new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("19f5574c-5c03-40da-9a33-ee0ef65db40e"), "Furniture", new DateTime(2022, 2, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), null, "ZvLvtKHW", 90750, "QR 121", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("06eaa4cb-1a47-4bf7-98cc-c79eb0347503"), new Guid("5160f8ba-8747-468e-8875-0266aef4673a") },
                    { new Guid("1d7c1137-4593-4a83-b4a3-281663009c0a"), "Computers", new DateTime(2022, 2, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), null, "oABuOgVI", 96200, "QR 148", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("d597db31-ea89-431f-876c-c17a8e36047e"), new Guid("17b0da6b-6409-4055-b7d7-51af0a0ba928") },
                    { new Guid("205631a7-4a70-4640-94ad-91b267dced3f"), "Kitchen", new DateTime(2022, 2, 25, 7, 0, 0, 0, DateTimeKind.Unspecified), null, "njgFtCke", 5920, "QR 185", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("ababc561-6d82-418a-8f0c-ebcbcae2d743"), new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("20c0b013-3d09-4201-9399-9f816b79e531"), "Kitchen", new DateTime(2022, 2, 28, 21, 0, 0, 0, DateTimeKind.Unspecified), null, "JvbNakRX", 25047, "QR 99", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("570c0ff8-3d70-4add-b471-fd589527bccb"), new Guid("750b202a-486a-45ff-8a97-d20fd285b59f") },
                    { new Guid("23369bed-3191-45b5-9bd5-a1711e4ae893"), "Furniture", new DateTime(2022, 2, 26, 2, 0, 0, 0, DateTimeKind.Unspecified), null, "plLwhWHp", 41998, "QR 166", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("4c45ab4e-8e48-4114-8b48-f75c840cbc47"), new Guid("17b0da6b-6409-4055-b7d7-51af0a0ba928") },
                    { new Guid("26421551-7461-424b-84e3-371fbe64c04e"), "Kitchen", new DateTime(2022, 3, 1, 1, 0, 0, 0, DateTimeKind.Unspecified), null, "PzvSNAhs", 3040, "QR 95", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("f7fcd750-373b-4967-82ca-45555815c7ff"), new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("2790682e-2432-44a1-9359-a7c03fad0e71"), "Kitchen", new DateTime(2022, 3, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), null, "tdgocffF", 759, "QR 3", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("60e3496e-af09-42c4-8313-16d731145152"), new Guid("750b202a-486a-45ff-8a97-d20fd285b59f") },
                    { new Guid("2e19ba6a-4af9-408a-a1be-8d31d571189e"), "Computers", new DateTime(2022, 3, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), null, "KCzekLAF", 36750, "QR 49", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("80c37904-a06b-48cc-bc5f-e6707be422ed"), new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("2f9cb058-99d8-4df8-95f9-c2fb51107917"), "Computers", new DateTime(2022, 3, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), null, "KelSfHHK", 18200, "QR 28", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("696bb1d8-7266-4974-aae9-8b7862db3045"), new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("30992094-3923-4e33-9c9c-5da52ce88478"), "Computers", new DateTime(2022, 2, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), null, "HkgkRxup", 131250, "QR 175", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("05d17529-80a3-4bc1-8c18-b913681b0243"), new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("3d446d47-3834-462e-8cce-10bfa88e1fcb"), "Furniture", new DateTime(2022, 2, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), null, "eVvhNylH", 26818, "QR 106", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("a5f6b470-1a44-490f-b357-7a170aacda36"), new Guid("750b202a-486a-45ff-8a97-d20fd285b59f") },
                    { new Guid("3d6e1f33-fc93-4c49-9351-ed3c9d996cb3"), "Furniture", new DateTime(2022, 2, 26, 7, 0, 0, 0, DateTimeKind.Unspecified), null, "mSXytjNs", 40733, "QR 161", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("277fd499-ee36-4f36-9029-694db26e5672"), new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("4a76474b-85b6-4512-a69f-83dd63d9f4a5"), "Kitchen", new DateTime(2022, 3, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), null, "HmdWgPUT", 15939, "QR 63", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("6c0a8d2b-e0fc-4e5a-9f70-7f8bc1df2f4b"), new Guid("cb3fe331-0113-4a25-b6d8-a70f83ab1c30") },
                    { new Guid("4b0c35f0-a470-4f6c-8ec0-c7111abb872b"), "Kitchen", new DateTime(2022, 2, 26, 19, 0, 0, 0, DateTimeKind.Unspecified), null, "SsoINgdl", 37697, "QR 149", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("b53d7f80-8c13-468a-96c9-b0803a9ddca7"), new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("4fa8b41c-d8b4-4f38-bf51-0b996da80102"), "Kitchen", new DateTime(2022, 2, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), null, "oQlESZtJ", 98800, "QR 152", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("f987fb7d-19d6-4ce1-bec1-cc5be5f082ec"), new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("503f5044-de7d-48df-9814-4fc432aa0c93"), "Computers", new DateTime(2022, 2, 26, 5, 0, 0, 0, DateTimeKind.Unspecified), null, "sScXsOWR", 122250, "QR 163", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("4d005e5b-8aec-4a3b-aeea-fce5545462cf"), new Guid("856462f3-5148-4dc5-8a62-376294a0784c") },
                    { new Guid("51f05dc7-a9b8-45e7-87e2-70c15c0a939e"), "Furniture", new DateTime(2022, 3, 2, 1, 0, 0, 0, DateTimeKind.Unspecified), null, "GPOiijYr", 17963, "QR 71", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("cf4f1b09-6740-463e-8c69-9ef6a4016ec2"), new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("54c100a2-9206-4d67-9382-1dc67397fbf4"), "Furniture", new DateTime(2022, 3, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), null, "QtCSNXdW", 750, "QR 1", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("3c79ee4f-c4fc-430b-a7db-8481412c013c"), new Guid("750b202a-486a-45ff-8a97-d20fd285b59f") },
                    { new Guid("554d618c-39d2-4f13-899c-e968e9b839d5"), "Kitchen", new DateTime(2022, 2, 26, 19, 0, 0, 0, DateTimeKind.Unspecified), null, "sAKsewvp", 37697, "QR 149", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("fbe918d3-aed2-414c-82d7-7e4ccfac76f2"), new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("565e25c2-ef1a-463e-aa40-dd9ca829e3d8"), "Furniture", new DateTime(2022, 3, 2, 16, 0, 0, 0, DateTimeKind.Unspecified), null, "yCKLGunc", 36400, "QR 56", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("5fd41cce-c4e5-4176-a05c-862bac846a4d"), new Guid("5160f8ba-8747-468e-8875-0266aef4673a") },
                    { new Guid("5dc8196e-978c-4098-a87f-3484c4fd5fea"), "Computers", new DateTime(2022, 3, 4, 20, 0, 0, 0, DateTimeKind.Unspecified), null, "XMXlPQSr", 2600, "QR 4", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("5917685d-35eb-4ce0-8cd3-bf221ec15c85"), new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("5f1e8877-a312-4ab4-9146-b2d468fc053a"), "Computers", new DateTime(2022, 3, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), null, "DRumZeNC", 57200, "QR 88", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("7fee2af3-d1fe-47c0-acf3-28b951c5f1a3"), new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("630f2d8a-0b38-4399-ab8a-0a05873a0227"), "Kitchen", new DateTime(2022, 2, 24, 19, 0, 0, 0, DateTimeKind.Unspecified), null, "KfvsAAXu", 49841, "QR 197", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("f9e5e9a1-f070-4422-b8bb-9dd379f6c50e"), new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("65347691-5a23-4a47-ba0e-081e31005336"), "Furniture", new DateTime(2022, 3, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), null, "PWPeyZGw", 23250, "QR 31", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("29827017-f246-40e4-8940-b07470b27ab0"), new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("6afc5fab-07bc-4cdc-900b-c428c4d53656"), "Computers", new DateTime(2022, 2, 26, 5, 0, 0, 0, DateTimeKind.Unspecified), null, "KuSOzOuy", 122250, "QR 163", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("fab08739-f9bf-47a2-8a02-2cb8693760ab"), new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("6c202b92-4d2e-4ec1-99a9-c871d5455cf4"), "Kitchen", new DateTime(2022, 3, 2, 22, 0, 0, 0, DateTimeKind.Unspecified), null, "HoLJOquI", 1600, "QR 50", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("2b25c515-1973-4f80-b4fd-b2334ee7ddb9"), new Guid("ca646c40-ca29-4d6e-8a7d-6ee543b3c4ad") },
                    { new Guid("6c32f183-8bae-41c4-ad95-c814e7b57aff"), "Kitchen", new DateTime(2022, 2, 25, 22, 0, 0, 0, DateTimeKind.Unspecified), null, "pDcNPCWK", 5440, "QR 170", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("0fb9c67b-54c2-4eb0-8de7-489643bb1123"), new Guid("856462f3-5148-4dc5-8a62-376294a0784c") },
                    { new Guid("6e04789e-8438-4976-9d8e-8075cb91c823"), "Kitchen", new DateTime(2022, 3, 1, 4, 0, 0, 0, DateTimeKind.Unspecified), null, "oRXYQWRz", 59800, "QR 92", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("14332022-4f9f-4827-bc27-6f2cdd24077c"), new Guid("ca646c40-ca29-4d6e-8a7d-6ee543b3c4ad") },
                    { new Guid("6e6844b4-4676-48bd-b599-b069c2e5f892"), "Furniture", new DateTime(2022, 3, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), null, "leCIkwJu", 10373, "QR 41", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("65586a70-8335-4504-a184-81dd79a20293"), new Guid("ca646c40-ca29-4d6e-8a7d-6ee543b3c4ad") },
                    { new Guid("6ee62753-8d38-4c25-b6cc-725c0e67db37"), "Kitchen", new DateTime(2022, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "lOiYsQWV", 46800, "QR 72", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("7f62e4e1-44cc-4a08-b02d-7fa4fcca79f3"), new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") }
                });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "Id", "Category", "CreatedAt", "DepartmentId", "Name", "Price", "QRCode", "RoomId", "SetupId", "Status", "UpdateBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("707cc78a-d3f8-49e9-9968-f68ea004fb91"), "Kitchen", new DateTime(2022, 3, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), null, "SgkAWrRa", 15686, "QR 62", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("55c20cc0-78d9-464b-a11f-e5b5bf99e3a4"), new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("72725c2e-b7b8-4c6f-9950-98b594a5d6af"), "Furniture", new DateTime(2022, 2, 25, 1, 0, 0, 0, DateTimeKind.Unspecified), null, "UbaqtqWp", 48323, "QR 191", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("3d1e87fe-08d5-4279-9b3e-aa58d75201b6"), new Guid("5160f8ba-8747-468e-8875-0266aef4673a") },
                    { new Guid("73f4e4c6-28d4-4de1-8d0b-f1f53c769e48"), "Kitchen", new DateTime(2022, 3, 3, 21, 0, 0, 0, DateTimeKind.Unspecified), null, "riTtxQLE", 6831, "QR 27", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("ddd3c058-803e-4e14-9700-2138ad9743c7"), new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("786e83d4-1a2a-4947-880a-30c1c3e1c330"), "Kitchen", new DateTime(2022, 3, 3, 3, 0, 0, 0, DateTimeKind.Unspecified), null, "UDHponAe", 1440, "QR 45", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("04739ba6-8bcb-40cc-9cbf-ff2342ae499d"), new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("7bf10606-9811-4f2a-adf5-8d58c167b52d"), "Furniture", new DateTime(2022, 2, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), null, "WwHjwUEM", 26818, "QR 106", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("fd0adcb4-8c2d-44f2-be7c-2759651bacbf"), new Guid("5160f8ba-8747-468e-8875-0266aef4673a") },
                    { new Guid("7d113009-18e1-4300-9364-952ed389532c"), "Furniture", new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "VYqWKCWf", 62400, "QR 96", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("efcb1048-737d-475a-acdb-42dd1abdcada"), new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("827864c1-546e-4313-a1f6-486dada2b600"), "Computers", new DateTime(2022, 2, 28, 8, 0, 0, 0, DateTimeKind.Unspecified), null, "pyWKDBPt", 72800, "QR 112", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("32ddf481-2cf5-4a06-8507-add97e67e81a"), new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("85b9b016-ed3f-4cf3-a0c8-7cd3f0ede8ac"), "Kitchen", new DateTime(2022, 3, 4, 6, 0, 0, 0, DateTimeKind.Unspecified), null, "GLKqzLQS", 4554, "QR 18", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("64b8e2a9-2c18-444b-ac9d-4f3f8db8faf6"), new Guid("5160f8ba-8747-468e-8875-0266aef4673a") },
                    { new Guid("85c4b109-efe5-4e55-acea-4f8279712ed5"), "Computers", new DateTime(2022, 2, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), null, "cGUpiqrL", 144750, "QR 193", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("9a6a6d16-4512-45af-b1bf-900bd07cbde5"), new Guid("17b0da6b-6409-4055-b7d7-51af0a0ba928") },
                    { new Guid("88efe266-692a-4442-a9e8-000d753effe7"), "Computers", new DateTime(2022, 2, 25, 5, 0, 0, 0, DateTimeKind.Unspecified), null, "abokYgRa", 140250, "QR 187", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("65f76a99-4f69-463f-aab2-d525f74a60fe"), new Guid("5160f8ba-8747-468e-8875-0266aef4673a") },
                    { new Guid("8fcd38a4-9c93-472e-86db-0d92c44fa086"), "Computers", new DateTime(2022, 3, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), null, "aaLUNKFc", 320, "QR 10", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("a65d5517-1e60-4371-958c-aff8317adf39"), new Guid("ca646c40-ca29-4d6e-8a7d-6ee543b3c4ad") },
                    { new Guid("9139059b-68cf-42a8-a509-c92c5f542d62"), "Furniture", new DateTime(2022, 3, 4, 3, 0, 0, 0, DateTimeKind.Unspecified), null, "VTSnNgtc", 5313, "QR 21", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("c4fdf842-15a1-4dac-ae57-7495acccb7af"), new Guid("856462f3-5148-4dc5-8a62-376294a0784c") },
                    { new Guid("91dcae42-55e1-4cb8-9de8-32dd81689567"), "Kitchen", new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ZsPdRcoF", 109200, "QR 168", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("7b8ea4fa-0d74-41b7-b77c-e988f42bf37f"), new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("9dea60cf-ced5-489b-814a-bf8621c0197a"), "Computers", new DateTime(2022, 3, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), null, "EWnpJnvM", 26000, "QR 40", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("2f6a96f8-588d-4895-9ad7-594da1c75391"), new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("9f91d270-4995-4d83-a8ca-2542c2413bd5"), "Furniture", new DateTime(2022, 3, 2, 6, 0, 0, 0, DateTimeKind.Unspecified), null, "jyQQutpj", 16698, "QR 66", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("e98547a0-79fc-4a16-a42a-ec39416892a9"), new Guid("cb3fe331-0113-4a25-b6d8-a70f83ab1c30") },
                    { new Guid("a8222db1-0c0e-4623-9575-649c9423b1f2"), "Kitchen", new DateTime(2022, 2, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), null, "mlORWVLJ", 98800, "QR 152", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("1179ac49-5946-47e0-a02c-cc97a349c3d5"), new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("ab54faf4-2bab-42c2-a2ef-71ad2cd5d28e"), "Furniture", new DateTime(2022, 2, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), null, "aBgsZGlk", 113250, "QR 151", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("9b9f9f4d-f55a-4ad6-97ee-9e6cd828ca70"), new Guid("750b202a-486a-45ff-8a97-d20fd285b59f") },
                    { new Guid("aecb39e6-cab4-4827-a2d9-5ab701ee6f75"), "Furniture", new DateTime(2022, 3, 2, 1, 0, 0, 0, DateTimeKind.Unspecified), null, "qkJJZnnX", 17963, "QR 71", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("d04025c3-b576-47a4-9217-7f76c11907f7"), new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("af4ca65f-e856-4e63-b2dd-0960ac7eb2da"), "Furniture", new DateTime(2022, 2, 28, 19, 0, 0, 0, DateTimeKind.Unspecified), null, "tLSDDvoS", 25553, "QR 101", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("b365149c-4e15-4f0a-b31a-40a9812db711"), new Guid("856462f3-5148-4dc5-8a62-376294a0784c") },
                    { new Guid("b0475e05-cfe6-44cb-b1a3-1931e56d91fd"), "Kitchen", new DateTime(2022, 3, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), null, "CqcIWNIs", 759, "QR 3", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("112b52c3-aac1-4013-84bd-ee64cec6f337"), new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("b2be8704-f49a-4c05-87f6-5a2920db08cc"), "Kitchen", new DateTime(2022, 3, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "yMnTLDjw", 7800, "QR 12", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("54404454-b581-4ffb-8415-89576092f457"), new Guid("cb3fe331-0113-4a25-b6d8-a70f83ab1c30") },
                    { new Guid("b617e231-4636-43fd-a5d3-47759f304294"), "Computers", new DateTime(2022, 3, 4, 5, 0, 0, 0, DateTimeKind.Unspecified), null, "JHkHHBuP", 14250, "QR 19", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("8c838f6e-77d0-4397-8dda-57c3439ac318"), new Guid("cb3fe331-0113-4a25-b6d8-a70f83ab1c30") },
                    { new Guid("b7cbf2e9-f981-44dc-8608-d5d3c8594332"), "Kitchen", new DateTime(2022, 3, 2, 9, 0, 0, 0, DateTimeKind.Unspecified), null, "RvwFZbtr", 15939, "QR 63", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("82a43c37-13d1-49f9-b83f-379830ef4423"), new Guid("17b0da6b-6409-4055-b7d7-51af0a0ba928") },
                    { new Guid("ba562878-7a9a-4776-90dd-12afc6eee017"), "Kitchen", new DateTime(2022, 3, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), null, "KSMltVYz", 52000, "QR 80", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("841a8be3-527b-419d-97ed-511df8521aef"), new Guid("5160f8ba-8747-468e-8875-0266aef4673a") },
                    { new Guid("bd749ec4-92b0-467b-9104-8f821094b285"), "Kitchen", new DateTime(2022, 3, 3, 16, 0, 0, 0, DateTimeKind.Unspecified), null, "DBARuYfC", 20800, "QR 32", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("1c5cf2c3-44ad-4339-bd2b-87945310aa58"), new Guid("856462f3-5148-4dc5-8a62-376294a0784c") },
                    { new Guid("c18d4369-e80d-4cdd-8113-a2f7bff49619"), "Kitchen", new DateTime(2022, 3, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), null, "tpRPoUMt", 14421, "QR 57", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("dfb32173-bc43-427b-9e3d-401a64e68ef1"), new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("c3b38ebd-3c0c-44e9-8ff9-ec6b68d12b19"), "Computers", new DateTime(2022, 3, 2, 8, 0, 0, 0, DateTimeKind.Unspecified), null, "TbXbDVLL", 41600, "QR 64", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("48cde170-ac13-479e-8aba-4285cb5dd30a"), new Guid("856462f3-5148-4dc5-8a62-376294a0784c") },
                    { new Guid("c58ac7cd-e6f7-4e37-bca3-2d065d309ef9"), "Kitchen", new DateTime(2022, 2, 27, 7, 0, 0, 0, DateTimeKind.Unspecified), null, "PHNKzQOD", 34661, "QR 137", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("76231c42-0566-4fb0-8431-74adc4a9f4a7"), new Guid("750b202a-486a-45ff-8a97-d20fd285b59f") },
                    { new Guid("c8fad4a7-eb55-43f3-ab1d-fe90ed78dbce"), "Kitchen", new DateTime(2022, 2, 25, 15, 0, 0, 0, DateTimeKind.Unspecified), null, "QdnDZhse", 44781, "QR 177", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("98236d05-2a09-4455-a5a4-1091e2bbb6c3"), new Guid("17b0da6b-6409-4055-b7d7-51af0a0ba928") },
                    { new Guid("d0be61bf-b9c7-4752-99c1-e801ac67ed99"), "Computers", new DateTime(2022, 2, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), null, "UyVxZdTx", 117750, "QR 157", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("ce712090-dd52-47ed-b3ce-83fb44777990"), new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("d2684c37-1b37-4903-9e22-d766b7f0dcbf"), "Kitchen", new DateTime(2022, 2, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), null, "TsNNPskB", 24794, "QR 98", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("dc23f03e-69d7-4783-8cb8-969307a9f8b0"), new Guid("17b0da6b-6409-4055-b7d7-51af0a0ba928") },
                    { new Guid("d6d03af4-0bcb-4a79-9168-a059e949574d"), "Kitchen", new DateTime(2022, 2, 27, 15, 0, 0, 0, DateTimeKind.Unspecified), null, "pCjryalP", 32637, "QR 129", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("c4d7831f-6e93-4f44-9ec4-913612d4c65c"), new Guid("17b0da6b-6409-4055-b7d7-51af0a0ba928") },
                    { new Guid("d8d9e346-4743-4a65-a77e-7727efd79c7a"), "Kitchen", new DateTime(2022, 2, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), null, "eoiypmPC", 83200, "QR 128", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("95673c30-e576-4386-a62f-8129449aa8d3"), new Guid("17b0da6b-6409-4055-b7d7-51af0a0ba928") },
                    { new Guid("db9f0685-b1ec-4a5c-b414-eb3ca825a1f0"), "Computers", new DateTime(2022, 2, 26, 23, 0, 0, 0, DateTimeKind.Unspecified), null, "TRawemCX", 108750, "QR 145", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("73b0b336-59e9-4fbc-808f-d367a21b0be0"), new Guid("cb3fe331-0113-4a25-b6d8-a70f83ab1c30") },
                    { new Guid("dbd071eb-bc7b-486c-a5ec-3e23ec8ce26c"), "Furniture", new DateTime(2022, 2, 25, 11, 0, 0, 0, DateTimeKind.Unspecified), null, "PPRnxfXg", 135750, "QR 181", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("65020c86-d214-43f1-a695-687cbdcabf12"), new Guid("750b202a-486a-45ff-8a97-d20fd285b59f") },
                    { new Guid("e58a9fa5-aaff-406b-bd9e-24093a44f1e6"), "Computers", new DateTime(2022, 2, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), null, "uAycvdPB", 111800, "QR 172", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("ddaf6388-b21c-49ba-8010-df2c3a88ead0"), new Guid("ca646c40-ca29-4d6e-8a7d-6ee543b3c4ad") },
                    { new Guid("ec54d878-c14e-4e11-bc95-93473d7eaa60"), "Kitchen", new DateTime(2022, 3, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), null, "gHOiCJUf", 2400, "QR 75", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("d7cf2ae1-3deb-497c-81c9-f5bbdfca685f"), new Guid("750b202a-486a-45ff-8a97-d20fd285b59f") },
                    { new Guid("f10d00c8-925f-4eb9-ad91-b4f142d36d95"), "Computers", new DateTime(2022, 3, 4, 17, 0, 0, 0, DateTimeKind.Unspecified), null, "iwcrcNzW", 5250, "QR 7", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("e83ce52f-1b98-4ffa-8b61-2e3358d0ec36"), new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("f15625c5-013b-4efc-b969-a254470ed0c9"), "Furniture", new DateTime(2022, 3, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), null, "bqfKuBlx", 10373, "QR 41", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("db1e06e2-b953-47b7-a2dd-b74f61550ecf"), new Guid("ca646c40-ca29-4d6e-8a7d-6ee543b3c4ad") },
                    { new Guid("f45c316c-fc86-464c-bc80-c3606dffe4b2"), "Kitchen", new DateTime(2022, 3, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "DJGjPIPt", 7800, "QR 12", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("d2b34e72-0fcf-4442-8746-0be80f9e06f3"), new Guid("856462f3-5148-4dc5-8a62-376294a0784c") },
                    { new Guid("f59b3d89-dcad-4c74-ac14-ef10238bc6e9"), "Computers", new DateTime(2022, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), null, "KLQjUGlE", 104000, "QR 160", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("fb56b5a6-9a98-47fa-96f5-26e691320fc2"), new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("f9254f90-bdcb-4367-acc0-86d272fba14d"), "Furniture", new DateTime(2022, 3, 2, 21, 0, 0, 0, DateTimeKind.Unspecified), null, "qqPMvNvb", 12903, "QR 51", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"), false, new Guid("99db9716-c6e1-4dc9-8824-b119e9dd5a1b"), new Guid("5160f8ba-8747-468e-8875-0266aef4673a") }
                });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "Id", "Category", "CreatedAt", "DepartmentId", "Name", "Price", "QRCode", "RoomId", "SetupId", "Status", "UpdateBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("f9d0df7b-46c2-41c2-bbd5-636af898857a"), "Computers", new DateTime(2022, 2, 26, 11, 0, 0, 0, DateTimeKind.Unspecified), null, "SVJUKhzE", 117750, "QR 157", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("6f0b2774-813f-4d8c-bc04-ba8b151edb62"), new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("fa052b59-d834-4a7e-bc18-0fd9a9b2ba27"), "Kitchen", new DateTime(2022, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "CQGDHvJY", 15600, "QR 24", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"), false, new Guid("5d797ae7-369a-478b-ad9e-aec846f69924"), new Guid("ca646c40-ca29-4d6e-8a7d-6ee543b3c4ad") },
                    { new Guid("fc203436-743b-4e52-9724-04fc44265f6b"), "Furniture", new DateTime(2022, 2, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), null, "ZPHjeddX", 127400, "QR 196", new Guid("84781be4-945a-4d64-891b-3a972bb350e6"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("e1cc038c-41f8-4148-87d5-b68ca3e72ec5"), new Guid("cb3fe331-0113-4a25-b6d8-a70f83ab1c30") },
                    { new Guid("fcbfab03-154e-4107-93ef-343b46ebf8d2"), "Kitchen", new DateTime(2022, 2, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), null, "SwlNfDHt", 67600, "QR 104", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("ad546679-7c8f-4120-a892-f3a240973f0b"), new Guid("cb3fe331-0113-4a25-b6d8-a70f83ab1c30") },
                    { new Guid("fe3cce01-d893-4890-ae24-664c7a543c38"), "Furniture", new DateTime(2022, 3, 4, 13, 0, 0, 0, DateTimeKind.Unspecified), null, "EBCxNjsW", 2783, "QR 11", new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("387c79e5-50e6-4f59-a04b-9a1202343d9d"), new Guid("17b0da6b-6409-4055-b7d7-51af0a0ba928") },
                    { new Guid("fea6d5d2-3f7e-4b30-ad14-87678ce5a3c3"), "Kitchen", new DateTime(2022, 3, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), null, "mWYYGoaO", 2080, "QR 65", new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"), new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"), false, new Guid("752b6896-6857-4e13-b54b-35db6ba6ff23"), new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "InventoryId", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("00e8984d-a83c-418c-af7f-3663e8c508c8"), new DateTime(2022, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "description64", "image64", new Guid("503f5044-de7d-48df-9814-4fc432aa0c93"), "eMhname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0216b6cb-4ec1-4fbc-82cf-ae62824411fc"), new DateTime(2022, 3, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "description16", "image16", new Guid("20c0b013-3d09-4201-9399-9f816b79e531"), "tNMname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("025bf2e3-6000-4851-a62f-2f191d8d8bf1"), new DateTime(2022, 3, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "description12", "image12", new Guid("fa052b59-d834-4a7e-bc18-0fd9a9b2ba27"), "mxfname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("02e0bd0a-85f5-43e9-b08a-acf88dff7695"), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "description24", "image24", new Guid("b617e231-4636-43fd-a5d3-47759f304294"), "XWGname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0374419f-e80b-4ff8-9e99-df46a9575519"), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "description0", "image0", new Guid("2e19ba6a-4af9-408a-a1be-8d31d571189e"), "KAWname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("03aa1f25-b86f-4729-8d66-f5472e767766"), new DateTime(2022, 3, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), "description8", "image8", new Guid("fe3cce01-d893-4890-ae24-664c7a543c38"), "KxIname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("054c963b-0816-4bff-aff4-2028f366aa0d"), new DateTime(2022, 2, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "description36", "image36", new Guid("d6d03af4-0bcb-4a79-9168-a059e949574d"), "aIgname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("063464dd-2ce9-4ffd-9a6a-c1439df01917"), new DateTime(2022, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), "description56", "image56", new Guid("fc203436-743b-4e52-9724-04fc44265f6b"), "wxnname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("07265c93-422f-494d-b7f0-622c34cbb4fd"), new DateTime(2022, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "description40", "image40", new Guid("d0be61bf-b9c7-4752-99c1-e801ac67ed99"), "OzIname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0734db10-467b-4bf5-b3e4-9f590252ec20"), new DateTime(2022, 3, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "description12", "image12", new Guid("fa052b59-d834-4a7e-bc18-0fd9a9b2ba27"), "OAzname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("08d6bd1e-a939-4ea8-aaa1-5f0c0bef51f7"), new DateTime(2022, 3, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), "description8", "image8", new Guid("fe3cce01-d893-4890-ae24-664c7a543c38"), "vSMname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("0900de9d-b265-4287-af6f-1f4636f9cd5f"), new DateTime(2022, 2, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), "description68", "image68", new Guid("b7cbf2e9-f981-44dc-8608-d5d3c8594332"), "JiQname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("09f9beeb-57f9-4044-8257-eb54cc2f9195"), new DateTime(2022, 2, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "description60", "image60", new Guid("786e83d4-1a2a-4947-880a-30c1c3e1c330"), "DGaname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("0a95ca77-429d-4a86-8836-00dcf97baa75"), new DateTime(2022, 3, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), "description8", "image8", new Guid("fe3cce01-d893-4890-ae24-664c7a543c38"), "ltename", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0b6842c7-ec22-4013-9d8a-6c3e40ac860e"), new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "description72", "image72", new Guid("e58a9fa5-aaff-406b-bd9e-24093a44f1e6"), "ATiname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("0c4ae9d2-9940-440b-9fe8-12616cb1b54c"), new DateTime(2022, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "description40", "image40", new Guid("d0be61bf-b9c7-4752-99c1-e801ac67ed99"), "KFKname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0d461f46-2f11-436b-ba69-85cae3e59885"), new DateTime(2022, 2, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), "description44", "image44", new Guid("8fcd38a4-9c93-472e-86db-0d92c44fa086"), "tFoname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0e849276-e1f0-4db6-9093-283b9b9a6a37"), new DateTime(2022, 3, 4, 4, 0, 0, 0, DateTimeKind.Unspecified), "description4", "image4", new Guid("af4ca65f-e856-4e63-b2dd-0960ac7eb2da"), "Ppuname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("0e8a9b67-8267-4c6c-a9b1-e973facd5182"), new DateTime(2022, 3, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), "description8", "image8", new Guid("fe3cce01-d893-4890-ae24-664c7a543c38"), "vxcname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0f64a08e-7996-43e7-aec6-f712da6f5c82"), new DateTime(2022, 2, 27, 4, 0, 0, 0, DateTimeKind.Unspecified), "description28", "image28", new Guid("180c633b-5b7f-4b67-8daa-564895633320"), "iPKname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("10498ab1-3a0e-47c7-adb3-998b7852f6cc"), new DateTime(2022, 3, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "description16", "image16", new Guid("20c0b013-3d09-4201-9399-9f816b79e531"), "Xxpname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("105ec755-2ebd-40d8-8eff-7c156d14071c"), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "description0", "image0", new Guid("2e19ba6a-4af9-408a-a1be-8d31d571189e"), "HpTname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("11c1df94-bad9-40a6-8226-faa72c5d886f"), new DateTime(2022, 3, 4, 4, 0, 0, 0, DateTimeKind.Unspecified), "description4", "image4", new Guid("af4ca65f-e856-4e63-b2dd-0960ac7eb2da"), "TJVname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("13075733-3f81-4267-af39-3e246a56d2ff"), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "description48", "image48", new Guid("0e88a26e-e8ed-4692-b4ce-c0c6aa8adf9f"), "Vnwname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("15beb348-b7c6-4e17-9d87-f68b0f48d479"), new DateTime(2022, 2, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "description84", "image84", new Guid("db9f0685-b1ec-4a5c-b414-eb3ca825a1f0"), "xHmname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("1928737b-453d-430f-9039-7753fd719fd1"), new DateTime(2022, 2, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "description36", "image36", new Guid("d6d03af4-0bcb-4a79-9168-a059e949574d"), "dNename", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("19f79b42-6ef7-436a-b92e-4278c193b33d"), new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "description72", "image72", new Guid("e58a9fa5-aaff-406b-bd9e-24093a44f1e6"), "eAtname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1cd89331-6c03-40d8-894d-5a09e15e8e13"), new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "description72", "image72", new Guid("e58a9fa5-aaff-406b-bd9e-24093a44f1e6"), "YNTname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1de561fa-12f1-4659-b9be-76883fb9ebf3"), new DateTime(2022, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "description88", "image88", new Guid("4fa8b41c-d8b4-4f38-bf51-0b996da80102"), "Mmuname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1eff9bef-c925-4b89-a1bd-517ef86bbbb9"), new DateTime(2022, 2, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "description36", "image36", new Guid("d6d03af4-0bcb-4a79-9168-a059e949574d"), "nqfname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1f2de717-2753-48a5-985a-50c695294375"), new DateTime(2022, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), "description56", "image56", new Guid("fc203436-743b-4e52-9724-04fc44265f6b"), "SUWname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("20632247-776e-41e3-9143-468523e32f63"), new DateTime(2022, 3, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), "description8", "image8", new Guid("fe3cce01-d893-4890-ae24-664c7a543c38"), "Cbjname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2078d8cb-1dfc-4744-8438-59754701e013"), new DateTime(2022, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "description64", "image64", new Guid("503f5044-de7d-48df-9814-4fc432aa0c93"), "pWYname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("215f2ee9-d3df-4f32-b3c3-3678c5a89cfa"), new DateTime(2022, 3, 4, 4, 0, 0, 0, DateTimeKind.Unspecified), "description4", "image4", new Guid("af4ca65f-e856-4e63-b2dd-0960ac7eb2da"), "eNYname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("28c74d31-c5f8-434b-9c32-b554a49a9813"), new DateTime(2022, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), "description56", "image56", new Guid("fc203436-743b-4e52-9724-04fc44265f6b"), "BZkname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("29921340-eb06-4909-baa8-12a45da2f782"), new DateTime(2022, 2, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "description36", "image36", new Guid("d6d03af4-0bcb-4a79-9168-a059e949574d"), "Jnename", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("29dc3bfc-a0ff-415f-b010-a127ea056e20"), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "description0", "image0", new Guid("2e19ba6a-4af9-408a-a1be-8d31d571189e"), "VGJname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("2ae6a154-7f8e-4f44-821c-de2d754b8872"), new DateTime(2022, 2, 22, 4, 0, 0, 0, DateTimeKind.Unspecified), "description52", "image52", new Guid("ba562878-7a9a-4776-90dd-12afc6eee017"), "MXQname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("2bacbbc1-ee86-41bc-ae5a-813758b54030"), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "description24", "image24", new Guid("b617e231-4636-43fd-a5d3-47759f304294"), "gRuname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("2bb65f7e-ec24-4e93-9ae7-c06ea73ba8d4"), new DateTime(2022, 3, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "description16", "image16", new Guid("20c0b013-3d09-4201-9399-9f816b79e531"), "oWSname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("2c28a33c-37af-4320-ada6-0a82ba36eb93"), new DateTime(2022, 2, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), "description44", "image44", new Guid("8fcd38a4-9c93-472e-86db-0d92c44fa086"), "pzVname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("2d6da3c8-9779-41c8-a7f2-6ef1072147b6"), new DateTime(2022, 2, 27, 4, 0, 0, 0, DateTimeKind.Unspecified), "description28", "image28", new Guid("180c633b-5b7f-4b67-8daa-564895633320"), "jNZname", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "InventoryId", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("30383fef-5aec-4316-a021-33d7ed66a862"), new DateTime(2022, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "description88", "image88", new Guid("4fa8b41c-d8b4-4f38-bf51-0b996da80102"), "Ktnname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("309734af-85f2-4f35-b912-57366e45684d"), new DateTime(2022, 2, 22, 4, 0, 0, 0, DateTimeKind.Unspecified), "description52", "image52", new Guid("ba562878-7a9a-4776-90dd-12afc6eee017"), "XLyname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("31b91b01-f4d1-4817-9f02-f631b0d8eeec"), new DateTime(2022, 3, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), "description8", "image8", new Guid("fe3cce01-d893-4890-ae24-664c7a543c38"), "MCmname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("340419c5-f623-40bf-b697-381ddd2a2a13"), new DateTime(2022, 2, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), "description80", "image80", new Guid("c18d4369-e80d-4cdd-8113-a2f7bff49619"), "vtrname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3493ca8b-7e6e-45cc-a4d8-f348b7e0eb5c"), new DateTime(2022, 2, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), "description68", "image68", new Guid("b7cbf2e9-f981-44dc-8608-d5d3c8594332"), "zLlname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("35f101a2-5558-449a-9999-a467ae65b508"), new DateTime(2022, 2, 22, 4, 0, 0, 0, DateTimeKind.Unspecified), "description52", "image52", new Guid("ba562878-7a9a-4776-90dd-12afc6eee017"), "MKcname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("38073bb5-d66e-4529-ad3d-3ccfed273f8a"), new DateTime(2022, 2, 17, 4, 0, 0, 0, DateTimeKind.Unspecified), "description76", "image76", new Guid("ab54faf4-2bab-42c2-a2ef-71ad2cd5d28e"), "mIqname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("38afb9b1-b853-4042-a3bf-08fd9821363a"), new DateTime(2022, 2, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), "description20", "image20", new Guid("30992094-3923-4e33-9c9c-5da52ce88478"), "DSRname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("398800ab-d96f-42c9-8c4b-3b46dbab92b2"), new DateTime(2022, 3, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "description12", "image12", new Guid("fa052b59-d834-4a7e-bc18-0fd9a9b2ba27"), "Yktname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("3c855c14-5384-4785-9a03-85b4b4e9bd72"), new DateTime(2022, 2, 22, 4, 0, 0, 0, DateTimeKind.Unspecified), "description52", "image52", new Guid("ba562878-7a9a-4776-90dd-12afc6eee017"), "XeMname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3cd35b22-3615-4d41-95cb-45928fc54d30"), new DateTime(2022, 2, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "description60", "image60", new Guid("786e83d4-1a2a-4947-880a-30c1c3e1c330"), "WDoname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("3cd6a784-a563-48c6-9609-b91afaf53452"), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "description24", "image24", new Guid("b617e231-4636-43fd-a5d3-47759f304294"), "VIXname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("3fbec66b-c674-4ee2-a978-ee3fbb6ecbc7"), new DateTime(2022, 2, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), "description20", "image20", new Guid("30992094-3923-4e33-9c9c-5da52ce88478"), "omYname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("40a783f7-b40c-45ab-90ff-85c871b81575"), new DateTime(2022, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "description88", "image88", new Guid("4fa8b41c-d8b4-4f38-bf51-0b996da80102"), "ODSname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("42dfb4cc-18c8-4998-a8d3-150610eb3363"), new DateTime(2022, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "description40", "image40", new Guid("d0be61bf-b9c7-4752-99c1-e801ac67ed99"), "WCNname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("4310eb83-0c09-41dc-bc9c-365fe07cc319"), new DateTime(2022, 2, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "description36", "image36", new Guid("d6d03af4-0bcb-4a79-9168-a059e949574d"), "mqpname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4345976d-1fd8-426e-97ce-9fad4dc61222"), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "description48", "image48", new Guid("0e88a26e-e8ed-4692-b4ce-c0c6aa8adf9f"), "egWname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("438bbda2-64c0-446c-b2f3-533ad7d08979"), new DateTime(2022, 3, 4, 4, 0, 0, 0, DateTimeKind.Unspecified), "description4", "image4", new Guid("af4ca65f-e856-4e63-b2dd-0960ac7eb2da"), "cBUname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("48932955-86f2-457e-843b-3d6d95064ebf"), new DateTime(2022, 2, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), "description44", "image44", new Guid("8fcd38a4-9c93-472e-86db-0d92c44fa086"), "SrDname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("48b7f6e6-c0ef-4d02-a361-86159a247004"), new DateTime(2022, 3, 4, 4, 0, 0, 0, DateTimeKind.Unspecified), "description4", "image4", new Guid("af4ca65f-e856-4e63-b2dd-0960ac7eb2da"), "gCOname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("49fe0f10-c460-4700-b90e-1eb91bcc610d"), new DateTime(2022, 2, 17, 4, 0, 0, 0, DateTimeKind.Unspecified), "description76", "image76", new Guid("ab54faf4-2bab-42c2-a2ef-71ad2cd5d28e"), "rCename", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4baa1c20-231c-45a9-b22d-5e60e74e0894"), new DateTime(2022, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), "description56", "image56", new Guid("fc203436-743b-4e52-9724-04fc44265f6b"), "zoCname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4c49b3d5-e2c1-4e0c-a750-3bf60c1904b6"), new DateTime(2022, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "description88", "image88", new Guid("4fa8b41c-d8b4-4f38-bf51-0b996da80102"), "Ahtname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("4c69f606-80c0-4ce1-a356-bf6e40b3e6cf"), new DateTime(2022, 3, 4, 4, 0, 0, 0, DateTimeKind.Unspecified), "description4", "image4", new Guid("af4ca65f-e856-4e63-b2dd-0960ac7eb2da"), "iEfname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("4ce3e9e6-986c-47ae-9ac8-1a3739c64729"), new DateTime(2022, 2, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), "description80", "image80", new Guid("c18d4369-e80d-4cdd-8113-a2f7bff49619"), "bTRname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4cedef50-f468-4e90-9ec2-eb7d3f856bf4"), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "description24", "image24", new Guid("b617e231-4636-43fd-a5d3-47759f304294"), "Ewjname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4e209b37-80a7-4f0f-9a2a-bb4ec85d7500"), new DateTime(2022, 3, 4, 4, 0, 0, 0, DateTimeKind.Unspecified), "description4", "image4", new Guid("af4ca65f-e856-4e63-b2dd-0960ac7eb2da"), "WEjname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4e773106-19f3-4f90-a2b6-65472a25e98f"), new DateTime(2022, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "description64", "image64", new Guid("503f5044-de7d-48df-9814-4fc432aa0c93"), "Hkrname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("4e7fd957-db1b-4372-9bd0-cca8e1343425"), new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "description72", "image72", new Guid("e58a9fa5-aaff-406b-bd9e-24093a44f1e6"), "qDQname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("4ec8e11e-fdfd-43ce-bbd2-e88cdd319483"), new DateTime(2022, 2, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "description84", "image84", new Guid("db9f0685-b1ec-4a5c-b414-eb3ca825a1f0"), "SEmname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("4f32e401-58e2-4b46-9f31-64887529c3cd"), new DateTime(2022, 3, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "description16", "image16", new Guid("20c0b013-3d09-4201-9399-9f816b79e531"), "ByMname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4f6b6b40-0ad7-4829-b919-61d13fc4e745"), new DateTime(2022, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), "description56", "image56", new Guid("fc203436-743b-4e52-9724-04fc44265f6b"), "gyrname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4f9131d7-05da-4fc6-80fa-913c708b03ab"), new DateTime(2022, 3, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), "description8", "image8", new Guid("fe3cce01-d893-4890-ae24-664c7a543c38"), "YwYname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("4fc4b676-95a6-4d4a-b3d5-a646cb6bdffd"), new DateTime(2022, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), "description32", "image32", new Guid("19d4b69a-7438-419d-8d82-3228cd4a8470"), "EiSname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4fff67bf-dfc3-4d30-8e5a-6709a5555785"), new DateTime(2022, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), "description32", "image32", new Guid("19d4b69a-7438-419d-8d82-3228cd4a8470"), "dXXname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("505a0ef4-bfe3-4db5-b38d-fcaa0465bad5"), new DateTime(2022, 2, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), "description68", "image68", new Guid("b7cbf2e9-f981-44dc-8608-d5d3c8594332"), "Dlmname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("505b2abf-dfce-4833-9aa6-76e27a0ade0e"), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "description48", "image48", new Guid("0e88a26e-e8ed-4692-b4ce-c0c6aa8adf9f"), "tYmname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("50d56b5e-6c9d-4705-a149-73692879ea3c"), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "description48", "image48", new Guid("0e88a26e-e8ed-4692-b4ce-c0c6aa8adf9f"), "llxname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("51f3ba48-0ce3-4a57-bc29-3a8247d09729"), new DateTime(2022, 3, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "description12", "image12", new Guid("fa052b59-d834-4a7e-bc18-0fd9a9b2ba27"), "JWdname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("52f6fb68-91cf-4bc8-826c-ec6871216ddc"), new DateTime(2022, 2, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), "description44", "image44", new Guid("8fcd38a4-9c93-472e-86db-0d92c44fa086"), "IJmname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("534df5b7-a23e-4a80-9f7a-57b2031e695a"), new DateTime(2022, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "description40", "image40", new Guid("d0be61bf-b9c7-4752-99c1-e801ac67ed99"), "CCqname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("540d0c64-65e6-42dc-9ff0-e1b186dc5645"), new DateTime(2022, 2, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "description84", "image84", new Guid("db9f0685-b1ec-4a5c-b414-eb3ca825a1f0"), "aOxname", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "InventoryId", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("5543f978-6afb-4c96-bef6-7d5daa2407a0"), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "description48", "image48", new Guid("0e88a26e-e8ed-4692-b4ce-c0c6aa8adf9f"), "HOPname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("55bbe939-84b8-4506-8663-5805ea35e639"), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "description0", "image0", new Guid("2e19ba6a-4af9-408a-a1be-8d31d571189e"), "JuYname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("55e395d4-4ad5-4ba1-a47a-426190e5d34a"), new DateTime(2022, 2, 22, 4, 0, 0, 0, DateTimeKind.Unspecified), "description52", "image52", new Guid("ba562878-7a9a-4776-90dd-12afc6eee017"), "WRKname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("594ee8be-ae59-49d1-9f5c-5df34450d63b"), new DateTime(2022, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "description40", "image40", new Guid("d0be61bf-b9c7-4752-99c1-e801ac67ed99"), "lrCname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5a152202-d244-4683-85fa-b165bebbba17"), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "description48", "image48", new Guid("0e88a26e-e8ed-4692-b4ce-c0c6aa8adf9f"), "OlOname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5a49cb55-fc90-4c22-ae5a-8e6d0be81101"), new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "description72", "image72", new Guid("e58a9fa5-aaff-406b-bd9e-24093a44f1e6"), "chvname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5b52f1e3-9ba6-41c4-a951-3fed0ed198e2"), new DateTime(2022, 2, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "description84", "image84", new Guid("db9f0685-b1ec-4a5c-b414-eb3ca825a1f0"), "xPDname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6012f12f-0026-44ef-891b-e52886f89271"), new DateTime(2022, 2, 22, 4, 0, 0, 0, DateTimeKind.Unspecified), "description52", "image52", new Guid("ba562878-7a9a-4776-90dd-12afc6eee017"), "IPCname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("62106c69-e147-4da4-a061-63d5b1bb2620"), new DateTime(2022, 2, 22, 4, 0, 0, 0, DateTimeKind.Unspecified), "description52", "image52", new Guid("ba562878-7a9a-4776-90dd-12afc6eee017"), "tCKname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("624b6f7c-8e6b-45dc-8961-787fbcadf1ab"), new DateTime(2022, 2, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), "description68", "image68", new Guid("b7cbf2e9-f981-44dc-8608-d5d3c8594332"), "wEQname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("640c0038-2045-4b41-b582-0431d2818a57"), new DateTime(2022, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), "description56", "image56", new Guid("fc203436-743b-4e52-9724-04fc44265f6b"), "tasname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("65891c74-7518-46d8-94fa-cdcdcb289f64"), new DateTime(2022, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "description40", "image40", new Guid("d0be61bf-b9c7-4752-99c1-e801ac67ed99"), "hiMname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("65fde388-dc33-41d1-924b-cbdaec0a3a78"), new DateTime(2022, 2, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), "description68", "image68", new Guid("b7cbf2e9-f981-44dc-8608-d5d3c8594332"), "fulname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("683758bf-0ab9-4d03-9115-ba43a063736a"), new DateTime(2022, 2, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), "description68", "image68", new Guid("b7cbf2e9-f981-44dc-8608-d5d3c8594332"), "fAtname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6a23770f-19f0-4b4b-a05d-1ff47a557bc7"), new DateTime(2022, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "description40", "image40", new Guid("d0be61bf-b9c7-4752-99c1-e801ac67ed99"), "cJaname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("6af057fd-a8bc-4506-931a-291d81fc7fa8"), new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "description72", "image72", new Guid("e58a9fa5-aaff-406b-bd9e-24093a44f1e6"), "Gcuname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("6f6a5ed3-2247-4687-a800-9695b49aea6b"), new DateTime(2022, 2, 17, 4, 0, 0, 0, DateTimeKind.Unspecified), "description76", "image76", new Guid("ab54faf4-2bab-42c2-a2ef-71ad2cd5d28e"), "EALname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("6f772df3-5e19-42cd-a078-6e1aa3ba3924"), new DateTime(2022, 2, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "description60", "image60", new Guid("786e83d4-1a2a-4947-880a-30c1c3e1c330"), "PLmname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7031ec55-c64a-432c-a161-a3d7bafeb773"), new DateTime(2022, 2, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), "description20", "image20", new Guid("30992094-3923-4e33-9c9c-5da52ce88478"), "CVmname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("70d93b26-08e0-425f-93b1-2a4feaad76be"), new DateTime(2022, 2, 27, 4, 0, 0, 0, DateTimeKind.Unspecified), "description28", "image28", new Guid("180c633b-5b7f-4b67-8daa-564895633320"), "Gqqname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("71034104-e0f5-4a66-97f6-6b015e490b70"), new DateTime(2022, 2, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "description84", "image84", new Guid("db9f0685-b1ec-4a5c-b414-eb3ca825a1f0"), "IYiname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("71b4754e-72ef-4980-bc99-255c44c11cce"), new DateTime(2022, 3, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "description16", "image16", new Guid("20c0b013-3d09-4201-9399-9f816b79e531"), "rMwname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("76d8fbdd-45a7-487f-b866-ad31dba4b0a3"), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "description48", "image48", new Guid("0e88a26e-e8ed-4692-b4ce-c0c6aa8adf9f"), "gKKname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("7880efd4-5b7a-4dd0-9d01-9fc2f688d5e8"), new DateTime(2022, 2, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "description60", "image60", new Guid("786e83d4-1a2a-4947-880a-30c1c3e1c330"), "RsKname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7d1f43ca-9017-4473-a178-1fbb8927bd5a"), new DateTime(2022, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "description88", "image88", new Guid("4fa8b41c-d8b4-4f38-bf51-0b996da80102"), "LjCname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("7d62cb02-5ebe-430c-b294-3d00a2f3d362"), new DateTime(2022, 2, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "description36", "image36", new Guid("d6d03af4-0bcb-4a79-9168-a059e949574d"), "LlXname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7dd054d4-75a6-4e99-a07e-bcb3d738ced2"), new DateTime(2022, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), "description32", "image32", new Guid("19d4b69a-7438-419d-8d82-3228cd4a8470"), "rXDname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("7ef9ce85-d41f-4df6-a6bb-2e0d4d49fe68"), new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "description72", "image72", new Guid("e58a9fa5-aaff-406b-bd9e-24093a44f1e6"), "VxTname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("7f6612e0-b554-46c5-8823-05400f22d13e"), new DateTime(2022, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), "description32", "image32", new Guid("19d4b69a-7438-419d-8d82-3228cd4a8470"), "uOGname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("8009ed0c-faa3-4d55-a77d-d93e1ec617c9"), new DateTime(2022, 2, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "description60", "image60", new Guid("786e83d4-1a2a-4947-880a-30c1c3e1c330"), "mgtname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8144bd17-c0e7-4631-b5ca-28a353704117"), new DateTime(2022, 3, 4, 4, 0, 0, 0, DateTimeKind.Unspecified), "description4", "image4", new Guid("af4ca65f-e856-4e63-b2dd-0960ac7eb2da"), "MVDname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("82002a7d-da1b-46bd-a00c-6199995ae942"), new DateTime(2022, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "description88", "image88", new Guid("4fa8b41c-d8b4-4f38-bf51-0b996da80102"), "emOname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("82fa1cbb-3f26-4493-ad13-f3d5018c248e"), new DateTime(2022, 2, 27, 4, 0, 0, 0, DateTimeKind.Unspecified), "description28", "image28", new Guid("180c633b-5b7f-4b67-8daa-564895633320"), "bslname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("831547d7-1977-4373-b5da-4e14108a3bf4"), new DateTime(2022, 2, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), "description68", "image68", new Guid("b7cbf2e9-f981-44dc-8608-d5d3c8594332"), "cEPname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("85d4e079-731c-4150-bf0f-85e8f103a368"), new DateTime(2022, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), "description32", "image32", new Guid("19d4b69a-7438-419d-8d82-3228cd4a8470"), "TXRname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("86200565-507b-4ef4-b0d9-0bb9acb6052a"), new DateTime(2022, 2, 17, 4, 0, 0, 0, DateTimeKind.Unspecified), "description76", "image76", new Guid("ab54faf4-2bab-42c2-a2ef-71ad2cd5d28e"), "yxUname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("87520706-23ee-41e6-a9a9-8c05c09a6a0d"), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "description48", "image48", new Guid("0e88a26e-e8ed-4692-b4ce-c0c6aa8adf9f"), "nJQname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("87d31df9-9e15-4a93-9ea1-d72a93466488"), new DateTime(2022, 2, 27, 4, 0, 0, 0, DateTimeKind.Unspecified), "description28", "image28", new Guid("180c633b-5b7f-4b67-8daa-564895633320"), "Winname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("88bbd204-bd73-436e-9ba9-bc710d8caab4"), new DateTime(2022, 2, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), "description80", "image80", new Guid("c18d4369-e80d-4cdd-8113-a2f7bff49619"), "fzjname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8906fd70-b019-4c91-b9de-42b6a740b72d"), new DateTime(2022, 2, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), "description44", "image44", new Guid("8fcd38a4-9c93-472e-86db-0d92c44fa086"), "IYfname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("8a063ba4-b998-49af-a41e-6e3ddbcf681e"), new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "description72", "image72", new Guid("e58a9fa5-aaff-406b-bd9e-24093a44f1e6"), "Vpyname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8a827498-29bf-488b-927d-a742555174ef"), new DateTime(2022, 2, 17, 4, 0, 0, 0, DateTimeKind.Unspecified), "description76", "image76", new Guid("ab54faf4-2bab-42c2-a2ef-71ad2cd5d28e"), "SAoname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "InventoryId", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("8b452621-feb3-400f-91c4-a3296287db82"), new DateTime(2022, 3, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), "description8", "image8", new Guid("fe3cce01-d893-4890-ae24-664c7a543c38"), "HYOname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("8b7ce3a5-c3e3-447c-807e-fc2467d33d12"), new DateTime(2022, 2, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), "description80", "image80", new Guid("c18d4369-e80d-4cdd-8113-a2f7bff49619"), "lcAname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("8c6ea7cc-eb05-45d2-9743-baa0d582d9a3"), new DateTime(2022, 3, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), "description8", "image8", new Guid("fe3cce01-d893-4890-ae24-664c7a543c38"), "aJdname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("912eaab3-42bb-4ee0-a606-373809e31705"), new DateTime(2022, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), "description32", "image32", new Guid("19d4b69a-7438-419d-8d82-3228cd4a8470"), "ehPname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("915d76c9-5121-49d5-ba4c-bc689fe89bf0"), new DateTime(2022, 2, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), "description20", "image20", new Guid("30992094-3923-4e33-9c9c-5da52ce88478"), "mMename", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("940b0c60-cdfe-46e0-a92a-4599c6c826d6"), new DateTime(2022, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "description64", "image64", new Guid("503f5044-de7d-48df-9814-4fc432aa0c93"), "vjnname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9454716d-6d94-42ed-b8f7-48846691efc6"), new DateTime(2022, 2, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "description60", "image60", new Guid("786e83d4-1a2a-4947-880a-30c1c3e1c330"), "gzSname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9521e584-a2ad-40d7-889c-fbef76a62841"), new DateTime(2022, 2, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "description84", "image84", new Guid("db9f0685-b1ec-4a5c-b414-eb3ca825a1f0"), "MCaname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("95af5cda-62a4-47bb-8c12-b198d8e65d63"), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "description24", "image24", new Guid("b617e231-4636-43fd-a5d3-47759f304294"), "btlname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("99ab9a5e-401c-48ef-b054-b3b7a54d5672"), new DateTime(2022, 2, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), "description68", "image68", new Guid("b7cbf2e9-f981-44dc-8608-d5d3c8594332"), "UASname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9a4c04c3-d7d5-4db6-83e8-8a79abba4344"), new DateTime(2022, 2, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), "description20", "image20", new Guid("30992094-3923-4e33-9c9c-5da52ce88478"), "Owoname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9b3c374e-508f-4042-9914-d2e2798d6d45"), new DateTime(2022, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "description40", "image40", new Guid("d0be61bf-b9c7-4752-99c1-e801ac67ed99"), "LVaname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9d1fe59b-2c6c-42c0-b8cb-011409d417a6"), new DateTime(2022, 3, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "description16", "image16", new Guid("20c0b013-3d09-4201-9399-9f816b79e531"), "nxWname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("9dc48a31-cec9-4b7f-b614-6e3e5af491eb"), new DateTime(2022, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "description64", "image64", new Guid("503f5044-de7d-48df-9814-4fc432aa0c93"), "Bkhname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9e1699cf-049f-4a61-b25c-effdb2fd63da"), new DateTime(2022, 2, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "description84", "image84", new Guid("db9f0685-b1ec-4a5c-b414-eb3ca825a1f0"), "pHnname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("9e1acc37-4d32-4069-894e-e68d2f14b0cd"), new DateTime(2022, 3, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "description12", "image12", new Guid("fa052b59-d834-4a7e-bc18-0fd9a9b2ba27"), "qbjname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("9eeba69f-28a3-4f84-b5a9-975cdadef483"), new DateTime(2022, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "description64", "image64", new Guid("503f5044-de7d-48df-9814-4fc432aa0c93"), "lYHname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("a0a8076d-bfa0-476d-84c6-661286ea4f32"), new DateTime(2022, 2, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "description36", "image36", new Guid("d6d03af4-0bcb-4a79-9168-a059e949574d"), "irgname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("a0f7f710-8055-4f8c-8ba6-be0fbd611efe"), new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "description72", "image72", new Guid("e58a9fa5-aaff-406b-bd9e-24093a44f1e6"), "Noxname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a1a0c12a-ba60-420c-8179-54b68fb74131"), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "description0", "image0", new Guid("2e19ba6a-4af9-408a-a1be-8d31d571189e"), "ePKname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a429a537-7392-4bc8-b8ae-4c39b3e5ea33"), new DateTime(2022, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "description40", "image40", new Guid("d0be61bf-b9c7-4752-99c1-e801ac67ed99"), "oelname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("a4c84827-9a21-47c4-a45b-37f991301237"), new DateTime(2022, 2, 27, 4, 0, 0, 0, DateTimeKind.Unspecified), "description28", "image28", new Guid("180c633b-5b7f-4b67-8daa-564895633320"), "RjFname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a4eb601f-82bb-4ca9-8a00-b972505a3aab"), new DateTime(2022, 2, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), "description20", "image20", new Guid("30992094-3923-4e33-9c9c-5da52ce88478"), "mLTname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a8a30e0e-bae4-4b69-acec-f2126230532b"), new DateTime(2022, 2, 27, 4, 0, 0, 0, DateTimeKind.Unspecified), "description28", "image28", new Guid("180c633b-5b7f-4b67-8daa-564895633320"), "BWtname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("a9812776-b15e-4ae9-ba5c-c3411026a753"), new DateTime(2022, 2, 17, 4, 0, 0, 0, DateTimeKind.Unspecified), "description76", "image76", new Guid("ab54faf4-2bab-42c2-a2ef-71ad2cd5d28e"), "MCkname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("a9d6fcd7-f599-4bac-9344-1f93f8b6c4d7"), new DateTime(2022, 2, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "description60", "image60", new Guid("786e83d4-1a2a-4947-880a-30c1c3e1c330"), "PqQname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("ab32034c-d5d1-4d05-9866-9c4f97ad50d5"), new DateTime(2022, 2, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), "description44", "image44", new Guid("8fcd38a4-9c93-472e-86db-0d92c44fa086"), "RDnname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("abe150bb-bab2-462e-aec0-1df9053fd650"), new DateTime(2022, 2, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), "description80", "image80", new Guid("c18d4369-e80d-4cdd-8113-a2f7bff49619"), "QPaname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("acc0f4a7-6584-41ff-bc0f-2ebebbde3b99"), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "description24", "image24", new Guid("b617e231-4636-43fd-a5d3-47759f304294"), "eXFname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("af635851-faeb-45bd-af1f-84c9f8948a59"), new DateTime(2022, 2, 27, 4, 0, 0, 0, DateTimeKind.Unspecified), "description28", "image28", new Guid("180c633b-5b7f-4b67-8daa-564895633320"), "vMqname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("b0336bca-d2d5-4a23-a826-a364f334e54d"), new DateTime(2022, 3, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "description16", "image16", new Guid("20c0b013-3d09-4201-9399-9f816b79e531"), "DAdname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("b2e521bc-28e5-4299-b48e-44aec31d0d43"), new DateTime(2022, 2, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), "description80", "image80", new Guid("c18d4369-e80d-4cdd-8113-a2f7bff49619"), "EMGname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("b34fab26-feaf-4d9d-866e-0ffc15203876"), new DateTime(2022, 2, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), "description20", "image20", new Guid("30992094-3923-4e33-9c9c-5da52ce88478"), "REBname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("b3869d9d-34b3-4a6c-81fc-5f5490a27c57"), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "description0", "image0", new Guid("2e19ba6a-4af9-408a-a1be-8d31d571189e"), "gqdname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b4247d0b-e5f9-4647-81f4-d42840b4cb69"), new DateTime(2022, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), "description56", "image56", new Guid("fc203436-743b-4e52-9724-04fc44265f6b"), "iaSname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("b78743e8-a0ff-428c-866d-fe7e54ded38d"), new DateTime(2022, 2, 22, 4, 0, 0, 0, DateTimeKind.Unspecified), "description52", "image52", new Guid("ba562878-7a9a-4776-90dd-12afc6eee017"), "tFUname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("b8b8a897-66f6-45bd-af39-55c40acb6be6"), new DateTime(2022, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "description72", "image72", new Guid("e58a9fa5-aaff-406b-bd9e-24093a44f1e6"), "pmdname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ba46cd6e-758e-4db9-be30-247b3fba7237"), new DateTime(2022, 2, 17, 4, 0, 0, 0, DateTimeKind.Unspecified), "description76", "image76", new Guid("ab54faf4-2bab-42c2-a2ef-71ad2cd5d28e"), "BZvname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ba89b06c-9ef6-4f6f-a5b2-dd150f7a87d0"), new DateTime(2022, 2, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "description84", "image84", new Guid("db9f0685-b1ec-4a5c-b414-eb3ca825a1f0"), "yafname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ba95bb02-0575-49be-8841-93cb0e91013e"), new DateTime(2022, 2, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "description60", "image60", new Guid("786e83d4-1a2a-4947-880a-30c1c3e1c330"), "dxSname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("baff60b1-d19e-46e0-a2cc-285c0f0efa63"), new DateTime(2022, 2, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), "description20", "image20", new Guid("30992094-3923-4e33-9c9c-5da52ce88478"), "BCFname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("bcf88740-805d-41d9-9038-2bee7fafac2a"), new DateTime(2022, 3, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "description12", "image12", new Guid("fa052b59-d834-4a7e-bc18-0fd9a9b2ba27"), "Bevname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "InventoryId", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("bd25ba38-8e72-49dc-a1a2-ccbb20d558fc"), new DateTime(2022, 3, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "description16", "image16", new Guid("20c0b013-3d09-4201-9399-9f816b79e531"), "Xhfname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("bf612d4f-1c3a-49ef-87e8-fc1e20a5fe45"), new DateTime(2022, 2, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), "description80", "image80", new Guid("c18d4369-e80d-4cdd-8113-a2f7bff49619"), "qsFname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c0375205-dccc-451b-8fb1-653a0f11c394"), new DateTime(2022, 2, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), "description20", "image20", new Guid("30992094-3923-4e33-9c9c-5da52ce88478"), "wEdname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("c0c24617-b9c7-4ad3-ab83-47197a52da62"), new DateTime(2022, 2, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), "description44", "image44", new Guid("8fcd38a4-9c93-472e-86db-0d92c44fa086"), "WNwname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("c1d54fcc-5179-4f91-90e4-b9572ee8d18c"), new DateTime(2022, 3, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "description12", "image12", new Guid("fa052b59-d834-4a7e-bc18-0fd9a9b2ba27"), "osxname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c1d6c9d8-29bf-4b09-9b06-7e3d9edc2330"), new DateTime(2022, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), "description56", "image56", new Guid("fc203436-743b-4e52-9724-04fc44265f6b"), "SZjname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c2442cd1-7afe-4d32-a125-05c3125050e3"), new DateTime(2022, 2, 17, 4, 0, 0, 0, DateTimeKind.Unspecified), "description76", "image76", new Guid("ab54faf4-2bab-42c2-a2ef-71ad2cd5d28e"), "hAyname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c3436321-908e-4635-9d7d-eed261e1722f"), new DateTime(2022, 2, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "description36", "image36", new Guid("d6d03af4-0bcb-4a79-9168-a059e949574d"), "RAGname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("c35aff7f-f2ae-4442-8f1b-dbd60802dc5c"), new DateTime(2022, 2, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), "description44", "image44", new Guid("8fcd38a4-9c93-472e-86db-0d92c44fa086"), "wGSname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c49dcfa4-1a5e-4545-86b6-6f4c564f7aa4"), new DateTime(2022, 3, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "description12", "image12", new Guid("fa052b59-d834-4a7e-bc18-0fd9a9b2ba27"), "Mdnname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c6745144-a26b-48ed-84af-a7386b47b9f2"), new DateTime(2022, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "description64", "image64", new Guid("503f5044-de7d-48df-9814-4fc432aa0c93"), "uOqname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("c7647784-d025-4843-8af7-4760facd3d51"), new DateTime(2022, 3, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "description16", "image16", new Guid("20c0b013-3d09-4201-9399-9f816b79e531"), "IfEname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ca126b5a-4984-4381-8340-b8d7ae5418af"), new DateTime(2022, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), "description56", "image56", new Guid("fc203436-743b-4e52-9724-04fc44265f6b"), "Araname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("cb302e52-f239-4746-a93c-37b108c29b26"), new DateTime(2022, 3, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "description12", "image12", new Guid("fa052b59-d834-4a7e-bc18-0fd9a9b2ba27"), "JQsname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("cbda8ac9-a21b-45eb-8072-72e1072d88f2"), new DateTime(2022, 3, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), "description12", "image12", new Guid("fa052b59-d834-4a7e-bc18-0fd9a9b2ba27"), "DScname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("cf22334e-7074-4363-83b4-74caadfd6363"), new DateTime(2022, 2, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), "description80", "image80", new Guid("c18d4369-e80d-4cdd-8113-a2f7bff49619"), "cpSname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("cfd28ad7-84dc-4b27-8a14-d09cde63bb48"), new DateTime(2022, 2, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), "description40", "image40", new Guid("d0be61bf-b9c7-4752-99c1-e801ac67ed99"), "uraname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("cfea1f4c-e20a-4cde-afca-d26aea9640d1"), new DateTime(2022, 2, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), "description44", "image44", new Guid("8fcd38a4-9c93-472e-86db-0d92c44fa086"), "oAZname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("d356c80f-82fc-42e4-8763-e94a4893bb6b"), new DateTime(2022, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "description64", "image64", new Guid("503f5044-de7d-48df-9814-4fc432aa0c93"), "WvFname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d36d7e71-0c7a-4a27-b0df-e2431c722604"), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "description48", "image48", new Guid("0e88a26e-e8ed-4692-b4ce-c0c6aa8adf9f"), "KVrname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d3b36cd2-1377-40c4-8a1d-746b87211206"), new DateTime(2022, 2, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "description36", "image36", new Guid("d6d03af4-0bcb-4a79-9168-a059e949574d"), "FRIname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d42fc5c1-d345-4ff6-a471-72ed0cede58c"), new DateTime(2022, 2, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "description60", "image60", new Guid("786e83d4-1a2a-4947-880a-30c1c3e1c330"), "rJmname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("d43316cf-e7a6-434b-9d83-032f52a6902d"), new DateTime(2022, 2, 27, 4, 0, 0, 0, DateTimeKind.Unspecified), "description28", "image28", new Guid("180c633b-5b7f-4b67-8daa-564895633320"), "hMzname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d4777abe-cca8-41c6-9525-32b050fddc2a"), new DateTime(2022, 2, 20, 12, 0, 0, 0, DateTimeKind.Unspecified), "description60", "image60", new Guid("786e83d4-1a2a-4947-880a-30c1c3e1c330"), "LBVname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d5e663dc-d547-482b-9cf5-c04c8b797b2f"), new DateTime(2022, 3, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "description16", "image16", new Guid("20c0b013-3d09-4201-9399-9f816b79e531"), "yxyname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d6694276-bd85-4300-93f8-4b31f0460754"), new DateTime(2022, 2, 27, 4, 0, 0, 0, DateTimeKind.Unspecified), "description28", "image28", new Guid("180c633b-5b7f-4b67-8daa-564895633320"), "hxename", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d8cd7464-4671-46b5-9919-4a0b26d891f0"), new DateTime(2022, 2, 17, 4, 0, 0, 0, DateTimeKind.Unspecified), "description76", "image76", new Guid("ab54faf4-2bab-42c2-a2ef-71ad2cd5d28e"), "QOHname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d96cf038-2aa2-43b5-8a31-f012cd626263"), new DateTime(2022, 2, 21, 8, 0, 0, 0, DateTimeKind.Unspecified), "description56", "image56", new Guid("fc203436-743b-4e52-9724-04fc44265f6b"), "VQename", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d9a36fe9-6c3c-43e1-a554-3aed7f203182"), new DateTime(2022, 2, 22, 4, 0, 0, 0, DateTimeKind.Unspecified), "description52", "image52", new Guid("ba562878-7a9a-4776-90dd-12afc6eee017"), "wYZname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("da53625a-7518-4d7f-9cc7-577343fff9c7"), new DateTime(2022, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "description88", "image88", new Guid("4fa8b41c-d8b4-4f38-bf51-0b996da80102"), "NTIname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("db4ec750-ff05-4633-a4fa-c2219705aefb"), new DateTime(2022, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "description48", "image48", new Guid("0e88a26e-e8ed-4692-b4ce-c0c6aa8adf9f"), "vlrname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("dcafde3f-bd42-4578-9348-929f4f0a868f"), new DateTime(2022, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "description64", "image64", new Guid("503f5044-de7d-48df-9814-4fc432aa0c93"), "EVCname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("df9897b6-0019-4d05-8b87-6c1c80bc1130"), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "description0", "image0", new Guid("2e19ba6a-4af9-408a-a1be-8d31d571189e"), "zYaname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("e0591000-3a48-4e3c-a687-103e2fcf35b3"), new DateTime(2022, 2, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "description84", "image84", new Guid("db9f0685-b1ec-4a5c-b414-eb3ca825a1f0"), "ATTname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e136f5b7-ef8d-4c39-b9cf-6e8069603ac5"), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "description24", "image24", new Guid("b617e231-4636-43fd-a5d3-47759f304294"), "ckpname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("e1ec8d70-4187-457d-87cf-36208f07b64f"), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "description0", "image0", new Guid("2e19ba6a-4af9-408a-a1be-8d31d571189e"), "sYUname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("e1fa75d1-ca5c-4e66-ac5c-f10ac1f07f0c"), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "description24", "image24", new Guid("b617e231-4636-43fd-a5d3-47759f304294"), "byvname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e2fd9c94-b3da-4177-a4f2-e21ffe5c9066"), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "description0", "image0", new Guid("2e19ba6a-4af9-408a-a1be-8d31d571189e"), "copname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e3aedb3a-b12c-4645-9493-759b4773b267"), new DateTime(2022, 3, 4, 4, 0, 0, 0, DateTimeKind.Unspecified), "description4", "image4", new Guid("af4ca65f-e856-4e63-b2dd-0960ac7eb2da"), "Qqrname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("e5c8d1a4-10be-4375-a08a-8b56ed300cb0"), new DateTime(2022, 2, 28, 20, 0, 0, 0, DateTimeKind.Unspecified), "description20", "image20", new Guid("30992094-3923-4e33-9c9c-5da52ce88478"), "kAGname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("e89827dc-4dcd-45cd-bba8-598ab3c5d1b8"), new DateTime(2022, 3, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), "description8", "image8", new Guid("fe3cce01-d893-4890-ae24-664c7a543c38"), "Vxrname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e8e4866a-7f66-4620-a6ae-8089c6b6e4cf"), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "description24", "image24", new Guid("b617e231-4636-43fd-a5d3-47759f304294"), "vdwname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") }
                });

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "InventoryId", "Name", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("e9d06d56-fa26-4d76-8833-07f282a9aa41"), new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "description24", "image24", new Guid("b617e231-4636-43fd-a5d3-47759f304294"), "qFPname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("eaf35885-9e66-4f4a-8d69-9d15c1c22e22"), new DateTime(2022, 2, 19, 16, 0, 0, 0, DateTimeKind.Unspecified), "description64", "image64", new Guid("503f5044-de7d-48df-9814-4fc432aa0c93"), "dENname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ebb4416e-75ab-4ced-97fc-0afd437edafb"), new DateTime(2022, 2, 17, 4, 0, 0, 0, DateTimeKind.Unspecified), "description76", "image76", new Guid("ab54faf4-2bab-42c2-a2ef-71ad2cd5d28e"), "KiYname", new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4") },
                    { new Guid("eca54705-a07f-43ba-a43e-92df97913c7e"), new DateTime(2022, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "description88", "image88", new Guid("4fa8b41c-d8b4-4f38-bf51-0b996da80102"), "xKVname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("ee902399-1e91-4a09-ab30-158fb68ec451"), new DateTime(2022, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), "description32", "image32", new Guid("19d4b69a-7438-419d-8d82-3228cd4a8470"), "qRXname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ef09b411-f89c-4e1d-9f6d-26a7f71dfc53"), new DateTime(2022, 2, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), "description80", "image80", new Guid("c18d4369-e80d-4cdd-8113-a2f7bff49619"), "YjAname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("ef1a3bf6-f4ff-4521-aae4-2e5bbb107e76"), new DateTime(2022, 3, 4, 4, 0, 0, 0, DateTimeKind.Unspecified), "description4", "image4", new Guid("af4ca65f-e856-4e63-b2dd-0960ac7eb2da"), "PPGname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ef1d9326-5a47-45a9-a779-4f308f48ef82"), new DateTime(2022, 2, 23, 20, 0, 0, 0, DateTimeKind.Unspecified), "description44", "image44", new Guid("8fcd38a4-9c93-472e-86db-0d92c44fa086"), "Padname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f125f0a6-7cf1-42be-9ef8-152045b878be"), new DateTime(2022, 2, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), "description84", "image84", new Guid("db9f0685-b1ec-4a5c-b414-eb3ca825a1f0"), "KzCname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f1a571b6-aeb2-43ad-b627-0dea2d3b1d6b"), new DateTime(2022, 2, 16, 8, 0, 0, 0, DateTimeKind.Unspecified), "description80", "image80", new Guid("c18d4369-e80d-4cdd-8113-a2f7bff49619"), "pYvname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f3418f7f-1384-4b4e-a789-abe3144cc330"), new DateTime(2022, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), "description32", "image32", new Guid("19d4b69a-7438-419d-8d82-3228cd4a8470"), "iUQname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("f3bc87df-6bb5-44af-965c-41182c6be482"), new DateTime(2022, 2, 22, 4, 0, 0, 0, DateTimeKind.Unspecified), "description52", "image52", new Guid("ba562878-7a9a-4776-90dd-12afc6eee017"), "acGname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f5c2a78a-bb0f-471a-b4f6-f7d9aba00af0"), new DateTime(2022, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), "description32", "image32", new Guid("19d4b69a-7438-419d-8d82-3228cd4a8470"), "Eeiname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("f5f0e9e8-4dfa-421d-a84f-61192a295e99"), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "description0", "image0", new Guid("2e19ba6a-4af9-408a-a1be-8d31d571189e"), "VWIname", new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853") },
                    { new Guid("f9f0b2d4-6a16-4e58-8299-ff9b7db36441"), new DateTime(2022, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), "description32", "image32", new Guid("19d4b69a-7438-419d-8d82-3228cd4a8470"), "SBKname", new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22") },
                    { new Guid("fac5a612-29a9-4aeb-a8ab-dc0bf0e2bcc9"), new DateTime(2022, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "description88", "image88", new Guid("4fa8b41c-d8b4-4f38-bf51-0b996da80102"), "bQYname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fb9bde92-4e69-4d70-9cfb-e8ea061f0f32"), new DateTime(2022, 2, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), "description68", "image68", new Guid("b7cbf2e9-f981-44dc-8608-d5d3c8594332"), "ZpSname", new Guid("df84fff7-56a1-456b-a25e-3625ae48b223") },
                    { new Guid("fecd4048-d5ec-46a7-9aeb-251b828bb2d4"), new DateTime(2022, 2, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), "description36", "image36", new Guid("d6d03af4-0bcb-4a79-9168-a059e949574d"), "hHFname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("fed38e8e-33db-425b-b522-eeccdb7ae83e"), new DateTime(2022, 2, 18, 20, 0, 0, 0, DateTimeKind.Unspecified), "description68", "image68", new Guid("b7cbf2e9-f981-44dc-8608-d5d3c8594332"), "nEpname", new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ffbd57a7-77b8-424d-a91c-7e91ad9826d8"), new DateTime(2022, 2, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), "description88", "image88", new Guid("4fa8b41c-d8b4-4f38-bf51-0b996da80102"), "gWBname", new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Defects_Inventory_InventoryId",
                table: "Defects",
                column: "InventoryId",
                principalTable: "Inventory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Rooms_RoomId",
                table: "Inventory",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Users_UserId",
                table: "Inventory",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Setups_Rooms_RoomId",
                table: "Setups",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Defects_Inventory_InventoryId",
                table: "Defects");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Rooms_RoomId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Users_UserId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_Setups_Rooms_RoomId",
                table: "Setups");

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("00e8984d-a83c-418c-af7f-3663e8c508c8"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("0216b6cb-4ec1-4fbc-82cf-ae62824411fc"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("025bf2e3-6000-4851-a62f-2f191d8d8bf1"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("02e0bd0a-85f5-43e9-b08a-acf88dff7695"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("0374419f-e80b-4ff8-9e99-df46a9575519"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("03aa1f25-b86f-4729-8d66-f5472e767766"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("054c963b-0816-4bff-aff4-2028f366aa0d"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("063464dd-2ce9-4ffd-9a6a-c1439df01917"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("07265c93-422f-494d-b7f0-622c34cbb4fd"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("0734db10-467b-4bf5-b3e4-9f590252ec20"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("08d6bd1e-a939-4ea8-aaa1-5f0c0bef51f7"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("0900de9d-b265-4287-af6f-1f4636f9cd5f"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("09f9beeb-57f9-4044-8257-eb54cc2f9195"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("0a95ca77-429d-4a86-8836-00dcf97baa75"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("0b6842c7-ec22-4013-9d8a-6c3e40ac860e"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("0c4ae9d2-9940-440b-9fe8-12616cb1b54c"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("0d461f46-2f11-436b-ba69-85cae3e59885"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("0e849276-e1f0-4db6-9093-283b9b9a6a37"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("0e8a9b67-8267-4c6c-a9b1-e973facd5182"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("0f64a08e-7996-43e7-aec6-f712da6f5c82"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("10498ab1-3a0e-47c7-adb3-998b7852f6cc"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("105ec755-2ebd-40d8-8eff-7c156d14071c"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("11c1df94-bad9-40a6-8226-faa72c5d886f"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("13075733-3f81-4267-af39-3e246a56d2ff"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("15beb348-b7c6-4e17-9d87-f68b0f48d479"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("1928737b-453d-430f-9039-7753fd719fd1"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("19f79b42-6ef7-436a-b92e-4278c193b33d"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("1cd89331-6c03-40d8-894d-5a09e15e8e13"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("1de561fa-12f1-4659-b9be-76883fb9ebf3"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("1eff9bef-c925-4b89-a1bd-517ef86bbbb9"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("1f2de717-2753-48a5-985a-50c695294375"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("20632247-776e-41e3-9143-468523e32f63"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("2078d8cb-1dfc-4744-8438-59754701e013"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("215f2ee9-d3df-4f32-b3c3-3678c5a89cfa"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("28c74d31-c5f8-434b-9c32-b554a49a9813"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("29921340-eb06-4909-baa8-12a45da2f782"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("29dc3bfc-a0ff-415f-b010-a127ea056e20"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("2ae6a154-7f8e-4f44-821c-de2d754b8872"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("2bacbbc1-ee86-41bc-ae5a-813758b54030"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("2bb65f7e-ec24-4e93-9ae7-c06ea73ba8d4"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("2c28a33c-37af-4320-ada6-0a82ba36eb93"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("2d6da3c8-9779-41c8-a7f2-6ef1072147b6"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("30383fef-5aec-4316-a021-33d7ed66a862"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("309734af-85f2-4f35-b912-57366e45684d"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("31b91b01-f4d1-4817-9f02-f631b0d8eeec"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("340419c5-f623-40bf-b697-381ddd2a2a13"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("3493ca8b-7e6e-45cc-a4d8-f348b7e0eb5c"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("35f101a2-5558-449a-9999-a467ae65b508"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("38073bb5-d66e-4529-ad3d-3ccfed273f8a"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("38afb9b1-b853-4042-a3bf-08fd9821363a"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("398800ab-d96f-42c9-8c4b-3b46dbab92b2"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("3c855c14-5384-4785-9a03-85b4b4e9bd72"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("3cd35b22-3615-4d41-95cb-45928fc54d30"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("3cd6a784-a563-48c6-9609-b91afaf53452"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("3fbec66b-c674-4ee2-a978-ee3fbb6ecbc7"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("40a783f7-b40c-45ab-90ff-85c871b81575"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("42dfb4cc-18c8-4998-a8d3-150610eb3363"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("4310eb83-0c09-41dc-bc9c-365fe07cc319"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("4345976d-1fd8-426e-97ce-9fad4dc61222"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("438bbda2-64c0-446c-b2f3-533ad7d08979"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("48932955-86f2-457e-843b-3d6d95064ebf"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("48b7f6e6-c0ef-4d02-a361-86159a247004"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("49fe0f10-c460-4700-b90e-1eb91bcc610d"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("4baa1c20-231c-45a9-b22d-5e60e74e0894"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("4c49b3d5-e2c1-4e0c-a750-3bf60c1904b6"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("4c69f606-80c0-4ce1-a356-bf6e40b3e6cf"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("4ce3e9e6-986c-47ae-9ac8-1a3739c64729"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("4cedef50-f468-4e90-9ec2-eb7d3f856bf4"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("4e209b37-80a7-4f0f-9a2a-bb4ec85d7500"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("4e773106-19f3-4f90-a2b6-65472a25e98f"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("4e7fd957-db1b-4372-9bd0-cca8e1343425"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("4ec8e11e-fdfd-43ce-bbd2-e88cdd319483"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("4f32e401-58e2-4b46-9f31-64887529c3cd"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("4f6b6b40-0ad7-4829-b919-61d13fc4e745"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("4f9131d7-05da-4fc6-80fa-913c708b03ab"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("4fc4b676-95a6-4d4a-b3d5-a646cb6bdffd"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("4fff67bf-dfc3-4d30-8e5a-6709a5555785"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("505a0ef4-bfe3-4db5-b38d-fcaa0465bad5"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("505b2abf-dfce-4833-9aa6-76e27a0ade0e"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("50d56b5e-6c9d-4705-a149-73692879ea3c"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("51f3ba48-0ce3-4a57-bc29-3a8247d09729"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("52f6fb68-91cf-4bc8-826c-ec6871216ddc"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("534df5b7-a23e-4a80-9f7a-57b2031e695a"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("540d0c64-65e6-42dc-9ff0-e1b186dc5645"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("5543f978-6afb-4c96-bef6-7d5daa2407a0"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("55bbe939-84b8-4506-8663-5805ea35e639"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("55e395d4-4ad5-4ba1-a47a-426190e5d34a"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("594ee8be-ae59-49d1-9f5c-5df34450d63b"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("5a152202-d244-4683-85fa-b165bebbba17"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("5a49cb55-fc90-4c22-ae5a-8e6d0be81101"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("5b52f1e3-9ba6-41c4-a951-3fed0ed198e2"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("6012f12f-0026-44ef-891b-e52886f89271"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("62106c69-e147-4da4-a061-63d5b1bb2620"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("624b6f7c-8e6b-45dc-8961-787fbcadf1ab"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("640c0038-2045-4b41-b582-0431d2818a57"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("65891c74-7518-46d8-94fa-cdcdcb289f64"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("65fde388-dc33-41d1-924b-cbdaec0a3a78"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("683758bf-0ab9-4d03-9115-ba43a063736a"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("6a23770f-19f0-4b4b-a05d-1ff47a557bc7"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("6af057fd-a8bc-4506-931a-291d81fc7fa8"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("6f6a5ed3-2247-4687-a800-9695b49aea6b"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("6f772df3-5e19-42cd-a078-6e1aa3ba3924"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("7031ec55-c64a-432c-a161-a3d7bafeb773"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("70d93b26-08e0-425f-93b1-2a4feaad76be"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("71034104-e0f5-4a66-97f6-6b015e490b70"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("71b4754e-72ef-4980-bc99-255c44c11cce"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("76d8fbdd-45a7-487f-b866-ad31dba4b0a3"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("7880efd4-5b7a-4dd0-9d01-9fc2f688d5e8"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("7d1f43ca-9017-4473-a178-1fbb8927bd5a"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("7d62cb02-5ebe-430c-b294-3d00a2f3d362"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("7dd054d4-75a6-4e99-a07e-bcb3d738ced2"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("7ef9ce85-d41f-4df6-a6bb-2e0d4d49fe68"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("7f6612e0-b554-46c5-8823-05400f22d13e"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("8009ed0c-faa3-4d55-a77d-d93e1ec617c9"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("8144bd17-c0e7-4631-b5ca-28a353704117"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("82002a7d-da1b-46bd-a00c-6199995ae942"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("82fa1cbb-3f26-4493-ad13-f3d5018c248e"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("831547d7-1977-4373-b5da-4e14108a3bf4"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("85d4e079-731c-4150-bf0f-85e8f103a368"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("86200565-507b-4ef4-b0d9-0bb9acb6052a"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("87520706-23ee-41e6-a9a9-8c05c09a6a0d"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("87d31df9-9e15-4a93-9ea1-d72a93466488"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("88bbd204-bd73-436e-9ba9-bc710d8caab4"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("8906fd70-b019-4c91-b9de-42b6a740b72d"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("8a063ba4-b998-49af-a41e-6e3ddbcf681e"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("8a827498-29bf-488b-927d-a742555174ef"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("8b452621-feb3-400f-91c4-a3296287db82"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("8b7ce3a5-c3e3-447c-807e-fc2467d33d12"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("8c6ea7cc-eb05-45d2-9743-baa0d582d9a3"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("912eaab3-42bb-4ee0-a606-373809e31705"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("915d76c9-5121-49d5-ba4c-bc689fe89bf0"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("940b0c60-cdfe-46e0-a92a-4599c6c826d6"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("9454716d-6d94-42ed-b8f7-48846691efc6"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("9521e584-a2ad-40d7-889c-fbef76a62841"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("95af5cda-62a4-47bb-8c12-b198d8e65d63"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("99ab9a5e-401c-48ef-b054-b3b7a54d5672"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("9a4c04c3-d7d5-4db6-83e8-8a79abba4344"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("9b3c374e-508f-4042-9914-d2e2798d6d45"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("9d1fe59b-2c6c-42c0-b8cb-011409d417a6"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("9dc48a31-cec9-4b7f-b614-6e3e5af491eb"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("9e1699cf-049f-4a61-b25c-effdb2fd63da"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("9e1acc37-4d32-4069-894e-e68d2f14b0cd"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("9eeba69f-28a3-4f84-b5a9-975cdadef483"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("a0a8076d-bfa0-476d-84c6-661286ea4f32"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("a0f7f710-8055-4f8c-8ba6-be0fbd611efe"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("a1a0c12a-ba60-420c-8179-54b68fb74131"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("a429a537-7392-4bc8-b8ae-4c39b3e5ea33"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("a4c84827-9a21-47c4-a45b-37f991301237"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("a4eb601f-82bb-4ca9-8a00-b972505a3aab"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("a8a30e0e-bae4-4b69-acec-f2126230532b"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("a9812776-b15e-4ae9-ba5c-c3411026a753"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("a9d6fcd7-f599-4bac-9344-1f93f8b6c4d7"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("ab32034c-d5d1-4d05-9866-9c4f97ad50d5"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("abe150bb-bab2-462e-aec0-1df9053fd650"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("acc0f4a7-6584-41ff-bc0f-2ebebbde3b99"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("af635851-faeb-45bd-af1f-84c9f8948a59"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("b0336bca-d2d5-4a23-a826-a364f334e54d"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("b2e521bc-28e5-4299-b48e-44aec31d0d43"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("b34fab26-feaf-4d9d-866e-0ffc15203876"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("b3869d9d-34b3-4a6c-81fc-5f5490a27c57"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("b4247d0b-e5f9-4647-81f4-d42840b4cb69"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("b78743e8-a0ff-428c-866d-fe7e54ded38d"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("b8b8a897-66f6-45bd-af39-55c40acb6be6"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("ba46cd6e-758e-4db9-be30-247b3fba7237"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("ba89b06c-9ef6-4f6f-a5b2-dd150f7a87d0"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("ba95bb02-0575-49be-8841-93cb0e91013e"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("baff60b1-d19e-46e0-a2cc-285c0f0efa63"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("bcf88740-805d-41d9-9038-2bee7fafac2a"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("bd25ba38-8e72-49dc-a1a2-ccbb20d558fc"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("bf612d4f-1c3a-49ef-87e8-fc1e20a5fe45"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("c0375205-dccc-451b-8fb1-653a0f11c394"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("c0c24617-b9c7-4ad3-ab83-47197a52da62"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("c1d54fcc-5179-4f91-90e4-b9572ee8d18c"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("c1d6c9d8-29bf-4b09-9b06-7e3d9edc2330"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("c2442cd1-7afe-4d32-a125-05c3125050e3"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("c3436321-908e-4635-9d7d-eed261e1722f"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("c35aff7f-f2ae-4442-8f1b-dbd60802dc5c"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("c49dcfa4-1a5e-4545-86b6-6f4c564f7aa4"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("c6745144-a26b-48ed-84af-a7386b47b9f2"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("c7647784-d025-4843-8af7-4760facd3d51"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("ca126b5a-4984-4381-8340-b8d7ae5418af"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("cb302e52-f239-4746-a93c-37b108c29b26"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("cbda8ac9-a21b-45eb-8072-72e1072d88f2"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("cf22334e-7074-4363-83b4-74caadfd6363"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("cfd28ad7-84dc-4b27-8a14-d09cde63bb48"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("cfea1f4c-e20a-4cde-afca-d26aea9640d1"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("d356c80f-82fc-42e4-8763-e94a4893bb6b"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("d36d7e71-0c7a-4a27-b0df-e2431c722604"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("d3b36cd2-1377-40c4-8a1d-746b87211206"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("d42fc5c1-d345-4ff6-a471-72ed0cede58c"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("d43316cf-e7a6-434b-9d83-032f52a6902d"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("d4777abe-cca8-41c6-9525-32b050fddc2a"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("d5e663dc-d547-482b-9cf5-c04c8b797b2f"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("d6694276-bd85-4300-93f8-4b31f0460754"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("d8cd7464-4671-46b5-9919-4a0b26d891f0"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("d96cf038-2aa2-43b5-8a31-f012cd626263"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("d9a36fe9-6c3c-43e1-a554-3aed7f203182"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("da53625a-7518-4d7f-9cc7-577343fff9c7"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("db4ec750-ff05-4633-a4fa-c2219705aefb"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("dcafde3f-bd42-4578-9348-929f4f0a868f"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("df9897b6-0019-4d05-8b87-6c1c80bc1130"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("e0591000-3a48-4e3c-a687-103e2fcf35b3"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("e136f5b7-ef8d-4c39-b9cf-6e8069603ac5"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("e1ec8d70-4187-457d-87cf-36208f07b64f"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("e1fa75d1-ca5c-4e66-ac5c-f10ac1f07f0c"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("e2fd9c94-b3da-4177-a4f2-e21ffe5c9066"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("e3aedb3a-b12c-4645-9493-759b4773b267"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("e5c8d1a4-10be-4375-a08a-8b56ed300cb0"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("e89827dc-4dcd-45cd-bba8-598ab3c5d1b8"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("e8e4866a-7f66-4620-a6ae-8089c6b6e4cf"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("e9d06d56-fa26-4d76-8833-07f282a9aa41"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("eaf35885-9e66-4f4a-8d69-9d15c1c22e22"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("ebb4416e-75ab-4ced-97fc-0afd437edafb"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("eca54705-a07f-43ba-a43e-92df97913c7e"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("ee902399-1e91-4a09-ab30-158fb68ec451"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("ef09b411-f89c-4e1d-9f6d-26a7f71dfc53"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("ef1a3bf6-f4ff-4521-aae4-2e5bbb107e76"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("ef1d9326-5a47-45a9-a779-4f308f48ef82"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("f125f0a6-7cf1-42be-9ef8-152045b878be"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("f1a571b6-aeb2-43ad-b627-0dea2d3b1d6b"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("f3418f7f-1384-4b4e-a789-abe3144cc330"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("f3bc87df-6bb5-44af-965c-41182c6be482"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("f5c2a78a-bb0f-471a-b4f6-f7d9aba00af0"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("f5f0e9e8-4dfa-421d-a84f-61192a295e99"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("f9f0b2d4-6a16-4e58-8299-ff9b7db36441"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("fac5a612-29a9-4aeb-a8ab-dc0bf0e2bcc9"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("fb9bde92-4e69-4d70-9cfb-e8ea061f0f32"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("fecd4048-d5ec-46a7-9aeb-251b828bb2d4"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("fed38e8e-33db-425b-b522-eeccdb7ae83e"));

            migrationBuilder.DeleteData(
                table: "Defects",
                keyColumn: "Id",
                keyValue: new Guid("ffbd57a7-77b8-424d-a91c-7e91ad9826d8"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("020c384a-0253-405a-8380-85291093d718"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("0436d6e8-4c19-48bb-b431-a8892aa41325"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("04b5ac9a-b9b4-47f7-ab51-6a4caf95fc22"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("0f5a2762-57eb-416d-96fa-e193da476a20"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("0f932b91-1f8a-4667-bc3d-a77d664a5c01"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("14ff9088-78f2-4599-8a17-40a81f4b4942"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("15042df4-be62-42b8-b283-5a22d2a42d2e"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("17e7898b-81a1-4966-8a5e-731abb2cb993"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("18a1762a-fd36-4b5e-95b0-a1c6679cf22f"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("19f5574c-5c03-40da-9a33-ee0ef65db40e"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("1d7c1137-4593-4a83-b4a3-281663009c0a"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("205631a7-4a70-4640-94ad-91b267dced3f"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("23369bed-3191-45b5-9bd5-a1711e4ae893"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("26421551-7461-424b-84e3-371fbe64c04e"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("2790682e-2432-44a1-9359-a7c03fad0e71"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("2f9cb058-99d8-4df8-95f9-c2fb51107917"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("3d446d47-3834-462e-8cce-10bfa88e1fcb"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("3d6e1f33-fc93-4c49-9351-ed3c9d996cb3"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("4a76474b-85b6-4512-a69f-83dd63d9f4a5"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("4b0c35f0-a470-4f6c-8ec0-c7111abb872b"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("51f05dc7-a9b8-45e7-87e2-70c15c0a939e"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("54c100a2-9206-4d67-9382-1dc67397fbf4"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("554d618c-39d2-4f13-899c-e968e9b839d5"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("565e25c2-ef1a-463e-aa40-dd9ca829e3d8"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("5dc8196e-978c-4098-a87f-3484c4fd5fea"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("5f1e8877-a312-4ab4-9146-b2d468fc053a"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("630f2d8a-0b38-4399-ab8a-0a05873a0227"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("65347691-5a23-4a47-ba0e-081e31005336"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("6afc5fab-07bc-4cdc-900b-c428c4d53656"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("6c202b92-4d2e-4ec1-99a9-c871d5455cf4"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("6c32f183-8bae-41c4-ad95-c814e7b57aff"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("6e04789e-8438-4976-9d8e-8075cb91c823"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("6e6844b4-4676-48bd-b599-b069c2e5f892"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("6ee62753-8d38-4c25-b6cc-725c0e67db37"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("707cc78a-d3f8-49e9-9968-f68ea004fb91"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("72725c2e-b7b8-4c6f-9950-98b594a5d6af"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("73f4e4c6-28d4-4de1-8d0b-f1f53c769e48"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("7bf10606-9811-4f2a-adf5-8d58c167b52d"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("7d113009-18e1-4300-9364-952ed389532c"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("827864c1-546e-4313-a1f6-486dada2b600"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("85b9b016-ed3f-4cf3-a0c8-7cd3f0ede8ac"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("85c4b109-efe5-4e55-acea-4f8279712ed5"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("88efe266-692a-4442-a9e8-000d753effe7"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("9139059b-68cf-42a8-a509-c92c5f542d62"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("91dcae42-55e1-4cb8-9de8-32dd81689567"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("9dea60cf-ced5-489b-814a-bf8621c0197a"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("9f91d270-4995-4d83-a8ca-2542c2413bd5"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("a8222db1-0c0e-4623-9575-649c9423b1f2"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("aecb39e6-cab4-4827-a2d9-5ab701ee6f75"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("b0475e05-cfe6-44cb-b1a3-1931e56d91fd"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("b2be8704-f49a-4c05-87f6-5a2920db08cc"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("bd749ec4-92b0-467b-9104-8f821094b285"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("c3b38ebd-3c0c-44e9-8ff9-ec6b68d12b19"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("c58ac7cd-e6f7-4e37-bca3-2d065d309ef9"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("c8fad4a7-eb55-43f3-ab1d-fe90ed78dbce"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("d2684c37-1b37-4903-9e22-d766b7f0dcbf"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("d8d9e346-4743-4a65-a77e-7727efd79c7a"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("dbd071eb-bc7b-486c-a5ec-3e23ec8ce26c"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("ec54d878-c14e-4e11-bc95-93473d7eaa60"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("f10d00c8-925f-4eb9-ad91-b4f142d36d95"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("f15625c5-013b-4efc-b969-a254470ed0c9"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("f45c316c-fc86-464c-bc80-c3606dffe4b2"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("f59b3d89-dcad-4c74-ac14-ef10238bc6e9"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("f9254f90-bdcb-4367-acc0-86d272fba14d"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("f9d0df7b-46c2-41c2-bbd5-636af898857a"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("fcbfab03-154e-4107-93ef-343b46ebf8d2"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("fea6d5d2-3f7e-4b30-ad14-87678ce5a3c3"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("0e88a26e-e8ed-4692-b4ce-c0c6aa8adf9f"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("180c633b-5b7f-4b67-8daa-564895633320"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("19d4b69a-7438-419d-8d82-3228cd4a8470"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("20c0b013-3d09-4201-9399-9f816b79e531"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("2e19ba6a-4af9-408a-a1be-8d31d571189e"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("30992094-3923-4e33-9c9c-5da52ce88478"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("4fa8b41c-d8b4-4f38-bf51-0b996da80102"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("503f5044-de7d-48df-9814-4fc432aa0c93"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("786e83d4-1a2a-4947-880a-30c1c3e1c330"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("8fcd38a4-9c93-472e-86db-0d92c44fa086"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("ab54faf4-2bab-42c2-a2ef-71ad2cd5d28e"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("af4ca65f-e856-4e63-b2dd-0960ac7eb2da"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("b617e231-4636-43fd-a5d3-47759f304294"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("b7cbf2e9-f981-44dc-8608-d5d3c8594332"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("ba562878-7a9a-4776-90dd-12afc6eee017"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("c18d4369-e80d-4cdd-8113-a2f7bff49619"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("d0be61bf-b9c7-4752-99c1-e801ac67ed99"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("d6d03af4-0bcb-4a79-9168-a059e949574d"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("db9f0685-b1ec-4a5c-b414-eb3ca825a1f0"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("e58a9fa5-aaff-406b-bd9e-24093a44f1e6"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("fa052b59-d834-4a7e-bc18-0fd9a9b2ba27"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("fc203436-743b-4e52-9724-04fc44265f6b"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("fe3cce01-d893-4890-ae24-664c7a543c38"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("84781be4-945a-4d64-891b-3a972bb350e6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("86c2c54b-e698-4ac4-a1a5-033bf18366c2"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9950bacf-8d6a-424b-9912-785b952eed8e"));

            migrationBuilder.DeleteData(
                table: "Setups",
                keyColumn: "Id",
                keyValue: new Guid("748bdefd-c5a1-47ed-9360-3c0bce46dcc2"));

            migrationBuilder.DeleteData(
                table: "Setups",
                keyColumn: "Id",
                keyValue: new Guid("8211446b-2d59-40b1-9aa1-c5095fff1866"));

            migrationBuilder.DeleteData(
                table: "Setups",
                keyColumn: "Id",
                keyValue: new Guid("b6e86691-6cdd-449d-8cd7-1491097b6e10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("17b0da6b-6409-4055-b7d7-51af0a0ba928"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5160f8ba-8747-468e-8875-0266aef4673a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("750b202a-486a-45ff-8a97-d20fd285b59f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("856462f3-5148-4dc5-8a62-376294a0784c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96b94a16-c9e6-4435-bb30-1a317cbec853"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ca646c40-ca29-4d6e-8a7d-6ee543b3c4ad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cb3fe331-0113-4a25-b6d8-a70f83ab1c30"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("df84fff7-56a1-456b-a25e-3625ae48b223"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e62479a6-4492-4ed5-b4f9-255bcd1ba3f4"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e8f15028-fec8-49cc-bff5-5fc9f19a7d22"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("8fa68195-80f6-45f4-a037-464e7d1aec30"));

            migrationBuilder.InsertData(
                table: "Defects",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "InventoryId", "Name", "UpdateBy" },
                values: new object[] { new Guid("11111111-9833-45ca-9017-1ded701ef149"), new DateTime(2022, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "description1", "image1", null, "name1", new Guid("11111111-9833-45ca-9017-1ded701ef149") });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdateBy" },
                values: new object[] { new Guid("1c3f0894-eff9-4215-8742-aa7bd34b9753"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "Department of Ruby", new Guid("146c5a0f-ca18-43d3-84e9-e9f9c77521fc") });

            migrationBuilder.InsertData(
                table: "Setups",
                columns: new[] { "Id", "Category", "CreatedAt", "Name", "QRCode", "RoomId", "RoomName", "Status", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("2aadefab-7a22-422e-875c-bc0bfd63515a"), "WorkPlaces", new DateTime(2022, 3, 21, 15, 5, 14, 457, DateTimeKind.Local).AddTicks(4272), "Node Work Desk", "QRCode2", null, "No Room YET", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d6ecd83d-4397-4146-865d-137f98f4ecce"), null },
                    { new Guid("a74f0a5c-e6bf-4a72-a15d-f4bdad14bed8"), "WorkPlaces", new DateTime(2022, 3, 21, 15, 5, 14, 457, DateTimeKind.Local).AddTicks(4270), "Ruby Work Desk", "QRCode1", null, "No Room YET", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d6ecd83d-4397-4146-865d-137f98f4ecce"), null },
                    { new Guid("f37f31e2-d2e5-4d79-8585-e72b2d308661"), "WorkPlaces", new DateTime(2022, 3, 21, 15, 5, 14, 457, DateTimeKind.Local).AddTicks(4253), "DotNet Work Desk", "QRCode0", null, "No Room YET", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d6ecd83d-4397-4146-865d-137f98f4ecce"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsAdmin", "LastName", "Name", "Password", "Phone", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("1437c9ec-84e1-42ec-bda5-58ce8d6c9e5d"), new DateTime(2022, 3, 21, 15, 5, 14, 457, DateTimeKind.Local).AddTicks(4341), "2", false, "2", "2", "2", "0", new Guid("f9f5fb2d-9175-41d1-b0b4-641b0ee00c01") },
                    { new Guid("1a221a03-3bc5-4d60-a4de-94678877e797"), new DateTime(2022, 3, 21, 15, 5, 14, 457, DateTimeKind.Local).AddTicks(4361), "8", false, "8", "8", "8", "10", new Guid("142a2580-c590-429a-b9d8-e14d4f55ba12") },
                    { new Guid("3ccffad2-5f15-4cde-93a8-8428280ef6d6"), new DateTime(2022, 3, 21, 15, 5, 14, 457, DateTimeKind.Local).AddTicks(4352), "5", false, "5", "5", "5", "7", new Guid("9ca4720e-95da-463b-883a-ced6d78ddff4") },
                    { new Guid("3ec7ce50-f5c2-4bc0-a87c-6e1a29811101"), new DateTime(2022, 3, 21, 15, 5, 14, 457, DateTimeKind.Local).AddTicks(4390), "9", true, "9", "9", "9", "11", new Guid("da9611aa-495f-4d18-a18b-f5329c0555a7") },
                    { new Guid("4544df78-67d6-4884-ba72-211d32a25f54"), new DateTime(2022, 3, 21, 15, 5, 14, 457, DateTimeKind.Local).AddTicks(4357), "7", false, "7", "7", "7", "5", new Guid("cf44a8cc-5e32-4c1a-8009-e9c4ee8eff1a") },
                    { new Guid("4dab4c07-cda5-4724-8f7b-53f0ee2a04a3"), new DateTime(2022, 3, 21, 15, 5, 14, 457, DateTimeKind.Local).AddTicks(4338), "1", false, "1", "1", "1", "3", new Guid("a097705e-9527-415b-8b7d-01ea027778fb") },
                    { new Guid("6737c2f7-afc0-4004-91d7-196de556e80e"), new DateTime(2022, 3, 21, 15, 5, 14, 457, DateTimeKind.Local).AddTicks(4348), "4", false, "4", "4", "4", "6", new Guid("da35fb2f-9eb8-46af-b2b6-311981bc7129") },
                    { new Guid("a15c417c-77a7-4230-9165-81166fde3ca8"), new DateTime(2022, 3, 21, 15, 5, 14, 457, DateTimeKind.Local).AddTicks(4344), "3", true, "3", "3", "3", "1", new Guid("81329fdc-4102-4a4f-a71d-f9290f4350de") },
                    { new Guid("c323a3c7-33b5-428b-bc02-d9d0820dc18c"), new DateTime(2022, 3, 21, 15, 5, 14, 457, DateTimeKind.Local).AddTicks(4354), "6", true, "6", "6", "6", "4", new Guid("1540f968-64a8-46a8-9357-37d5e10eb1f3") },
                    { new Guid("d5179cdb-710b-4fb9-9769-cb294a9e731f"), new DateTime(2022, 3, 21, 15, 5, 14, 457, DateTimeKind.Local).AddTicks(4332), "0", true, "0", "0", "0", "2", new Guid("c459e52f-6608-4312-bc38-a0183d99cbe9") }
                });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "Id", "Category", "CreatedAt", "DepartmentId", "Name", "Price", "QRCode", "RoomId", "SetupId", "Status", "UpdateBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("03ee0159-4f58-4079-9569-f60cdc652799"), "Furniture", new DateTime(2022, 3, 2, 1, 0, 0, 0, DateTimeKind.Unspecified), null, "71", 17963, "71", null, new Guid("2aadefab-7a22-422e-875c-bc0bfd63515a"), false, new Guid("0def9068-0111-4987-8792-acf8af4e518e"), new Guid("4dab4c07-cda5-4724-8f7b-53f0ee2a04a3") },
                    { new Guid("06db4e81-8476-4cd5-a5e3-f0c096cebf71"), "Computers", new DateTime(2022, 3, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), null, "79", 59250, "79", null, new Guid("a74f0a5c-e6bf-4a72-a15d-f4bdad14bed8"), false, new Guid("fbddfe8b-1aa8-4bc1-b2aa-e4eba55ff422"), new Guid("3ec7ce50-f5c2-4bc0-a87c-6e1a29811101") },
                    { new Guid("2358f731-90fa-4a84-824a-0cb607948fbe"), "Kitchen", new DateTime(2022, 3, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), null, "75", 2400, "75", null, new Guid("f37f31e2-d2e5-4d79-8585-e72b2d308661"), false, new Guid("4b7d2524-5f91-4e0a-8b5e-5505e3a63e70"), new Guid("4544df78-67d6-4884-ba72-211d32a25f54") },
                    { new Guid("248e4cf2-7b40-4a04-8012-aa33aaa00bca"), "Furniture", new DateTime(2022, 3, 4, 18, 0, 0, 0, DateTimeKind.Unspecified), null, "6", 1518, "6", null, new Guid("a74f0a5c-e6bf-4a72-a15d-f4bdad14bed8"), false, new Guid("487b66e6-1d98-4cb1-a809-bf57be856dd8"), new Guid("a15c417c-77a7-4230-9165-81166fde3ca8") },
                    { new Guid("262cba63-b5a8-462d-8be6-b72e869edcb7"), "Kitchen", new DateTime(2022, 3, 4, 10, 0, 0, 0, DateTimeKind.Unspecified), null, "14", 3542, "14", null, new Guid("a74f0a5c-e6bf-4a72-a15d-f4bdad14bed8"), false, new Guid("02cda184-2bc0-4d44-af01-4ba470f686bd"), new Guid("4544df78-67d6-4884-ba72-211d32a25f54") },
                    { new Guid("37ab16cc-9fd6-4bfc-babf-e55d78d7ed2a"), "Kitchen", new DateTime(2022, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "48", 31200, "48", null, new Guid("f37f31e2-d2e5-4d79-8585-e72b2d308661"), false, new Guid("768039ec-f502-4bc0-9f66-27159ef9e2ab"), new Guid("3ccffad2-5f15-4cde-93a8-8428280ef6d6") },
                    { new Guid("3f91b518-f08a-440f-9a85-78a66f5ecaf3"), "Kitchen", new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "168", 109200, "168", null, new Guid("f37f31e2-d2e5-4d79-8585-e72b2d308661"), false, new Guid("0c05cb02-4e6d-4be5-a14b-1c57adfa0620"), new Guid("1a221a03-3bc5-4d60-a4de-94678877e797") },
                    { new Guid("4aae605f-333c-4f10-80f8-b3e10f8f3e63"), "Kitchen", new DateTime(2022, 3, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), null, "77", 19481, "77", null, new Guid("a74f0a5c-e6bf-4a72-a15d-f4bdad14bed8"), false, new Guid("8ed60d33-d41b-4646-bd33-68388a4724ee"), new Guid("c323a3c7-33b5-428b-bc02-d9d0820dc18c") },
                    { new Guid("4d1c78f5-0044-4929-8a9f-aaaea7b3e509"), "Kitchen", new DateTime(2022, 3, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), null, "78", 19734, "78", null, new Guid("2aadefab-7a22-422e-875c-bc0bfd63515a"), false, new Guid("a44ecf77-2acc-4546-b1c0-a29ec2e7b182"), new Guid("6737c2f7-afc0-4004-91d7-196de556e80e") },
                    { new Guid("4fe9245f-46ae-4aa6-b9a3-b1dbbd72b577"), "Kitchen", new DateTime(2022, 2, 28, 15, 0, 0, 0, DateTimeKind.Unspecified), null, "105", 3360, "105", null, new Guid("2aadefab-7a22-422e-875c-bc0bfd63515a"), false, new Guid("31b26483-d750-4f9b-ac57-dc6724e9ab0a"), new Guid("4544df78-67d6-4884-ba72-211d32a25f54") },
                    { new Guid("614596ee-465a-4ec6-9cf9-09100e90b1a8"), "Computers", new DateTime(2022, 3, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), null, "82", 20746, "82", null, new Guid("a74f0a5c-e6bf-4a72-a15d-f4bdad14bed8"), false, new Guid("ef7abb96-1bbb-4bd8-8a72-89733b38b8f6"), new Guid("1437c9ec-84e1-42ec-bda5-58ce8d6c9e5d") },
                    { new Guid("66eb5e88-078a-4d81-8ee4-5b1b373fcfe3"), "Furniture", new DateTime(2022, 2, 25, 1, 0, 0, 0, DateTimeKind.Unspecified), null, "191", 48323, "191", null, new Guid("a74f0a5c-e6bf-4a72-a15d-f4bdad14bed8"), false, new Guid("a33516b0-5682-490c-a172-9d251612cec1"), new Guid("3ccffad2-5f15-4cde-93a8-8428280ef6d6") },
                    { new Guid("8400bb6f-0971-4133-b1b2-03793cea7045"), "Kitchen", new DateTime(2022, 3, 4, 4, 0, 0, 0, DateTimeKind.Unspecified), null, "20", 13000, "20", null, new Guid("f37f31e2-d2e5-4d79-8585-e72b2d308661"), false, new Guid("0c11b275-a2bd-48c7-b20b-b55c02a61966"), new Guid("a15c417c-77a7-4230-9165-81166fde3ca8") },
                    { new Guid("971512a9-d549-44ad-8e79-d3ad86719c60"), "Kitchen", new DateTime(2022, 2, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), null, "104", 67600, "104", null, new Guid("a74f0a5c-e6bf-4a72-a15d-f4bdad14bed8"), false, new Guid("5fcac083-d987-43f0-9c8b-05631eac3de7"), new Guid("6737c2f7-afc0-4004-91d7-196de556e80e") },
                    { new Guid("999b7d83-56de-4665-983b-8921d737d7e1"), "Kitchen", new DateTime(2022, 2, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), null, "159", 40227, "159", null, new Guid("a74f0a5c-e6bf-4a72-a15d-f4bdad14bed8"), false, new Guid("d44884e5-33ec-4e62-98d2-1a86c3ad2d10"), new Guid("1a221a03-3bc5-4d60-a4de-94678877e797") },
                    { new Guid("a50d6370-dff3-4893-a867-a682e9545b0d"), "Computers", new DateTime(2022, 3, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), null, "88", 57200, "88", null, new Guid("f37f31e2-d2e5-4d79-8585-e72b2d308661"), false, new Guid("3b86a6f7-6f36-491a-bd09-35b4e9fb61d8"), new Guid("3ec7ce50-f5c2-4bc0-a87c-6e1a29811101") },
                    { new Guid("b1005bdd-2531-462c-b4e6-cf50e29b29ad"), "Kitchen", new DateTime(2022, 3, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "12", 7800, "12", null, new Guid("f37f31e2-d2e5-4d79-8585-e72b2d308661"), false, new Guid("32bd8b7c-b80b-4505-a06e-a416bd12b70b"), new Guid("6737c2f7-afc0-4004-91d7-196de556e80e") },
                    { new Guid("b348199a-f684-4dee-97a8-2fe106c637ea"), "Computers", new DateTime(2022, 3, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), null, "58", 14674, "58", null, new Guid("2aadefab-7a22-422e-875c-bc0bfd63515a"), false, new Guid("66984a7e-034d-484c-9b08-3054d2ec392c"), new Guid("a15c417c-77a7-4230-9165-81166fde3ca8") },
                    { new Guid("b60e07e1-2f88-4404-a635-081333310bb9"), "Computers", new DateTime(2022, 3, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), null, "25", 18750, "25", null, new Guid("f37f31e2-d2e5-4d79-8585-e72b2d308661"), false, new Guid("1a6868bc-01a7-48ae-ad3a-79e29d925fda"), new Guid("c323a3c7-33b5-428b-bc02-d9d0820dc18c") },
                    { new Guid("c7bae62a-4720-40bd-931c-dd091d8e3fe0"), "Kitchen", new DateTime(2022, 2, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "108", 70200, "108", null, new Guid("2aadefab-7a22-422e-875c-bc0bfd63515a"), false, new Guid("9fbbb4e4-3a76-45bc-9e77-73ccf2683f63"), new Guid("3ccffad2-5f15-4cde-93a8-8428280ef6d6") },
                    { new Guid("cf531c63-ecb8-4da7-b42a-f087ece8c678"), "Kitchen", new DateTime(2022, 2, 24, 22, 0, 0, 0, DateTimeKind.Unspecified), null, "194", 49082, "194", null, new Guid("2aadefab-7a22-422e-875c-bc0bfd63515a"), false, new Guid("3e481919-7569-49d9-bfb0-2064635391e4"), new Guid("1437c9ec-84e1-42ec-bda5-58ce8d6c9e5d") },
                    { new Guid("cffd5201-763e-47c0-b5fd-065049f1b6df"), "Furniture", new DateTime(2022, 2, 26, 2, 0, 0, 0, DateTimeKind.Unspecified), null, "166", 41998, "166", null, new Guid("a74f0a5c-e6bf-4a72-a15d-f4bdad14bed8"), false, new Guid("b06275b0-c5be-43a2-befc-2b1e4b56e01e"), new Guid("4dab4c07-cda5-4724-8f7b-53f0ee2a04a3") },
                    { new Guid("d05d379e-0700-4d9c-9851-c062c0b9fddc"), "Kitchen", new DateTime(2022, 3, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), null, "53", 13409, "53", null, new Guid("2aadefab-7a22-422e-875c-bc0bfd63515a"), false, new Guid("3787dad0-2c32-44bc-a5fa-143d43fc92cb"), new Guid("1a221a03-3bc5-4d60-a4de-94678877e797") },
                    { new Guid("da142d7a-809d-4743-8aef-decb1b822021"), "Kitchen", new DateTime(2022, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "192", 124800, "192", null, new Guid("2aadefab-7a22-422e-875c-bc0bfd63515a"), false, new Guid("8654429b-d715-499e-9665-9ea18cc50533"), new Guid("3ec7ce50-f5c2-4bc0-a87c-6e1a29811101") },
                    { new Guid("dd0cb3df-6294-4953-9d82-41550ac42fda"), "Furniture", new DateTime(2022, 2, 24, 20, 0, 0, 0, DateTimeKind.Unspecified), null, "196", 127400, "196", null, new Guid("f37f31e2-d2e5-4d79-8585-e72b2d308661"), false, new Guid("6eb449f7-ebe0-482e-b79e-e3e3be97fd50"), new Guid("1437c9ec-84e1-42ec-bda5-58ce8d6c9e5d") },
                    { new Guid("f3fc66d6-e173-4163-b93d-7d255b493ab1"), "Furniture", new DateTime(2022, 2, 28, 9, 0, 0, 0, DateTimeKind.Unspecified), null, "111", 28083, "111", null, new Guid("f37f31e2-d2e5-4d79-8585-e72b2d308661"), false, new Guid("b41cb3f7-e97b-45bb-80c6-557a2ae22606"), new Guid("d5179cdb-710b-4fb9-9769-cb294a9e731f") },
                    { new Guid("f4d9f222-f88d-4c99-be9f-67e767fcfe88"), "Computers", new DateTime(2022, 3, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), null, "88", 57200, "88", null, new Guid("2aadefab-7a22-422e-875c-bc0bfd63515a"), false, new Guid("47d81a68-94dc-482d-9bbe-64654eb4cb27"), new Guid("d5179cdb-710b-4fb9-9769-cb294a9e731f") },
                    { new Guid("f7fffacb-7add-449a-b86b-a701d5cb52e4"), "Computers", new DateTime(2022, 3, 2, 23, 0, 0, 0, DateTimeKind.Unspecified), null, "49", 36750, "49", null, new Guid("a74f0a5c-e6bf-4a72-a15d-f4bdad14bed8"), false, new Guid("4e958377-b453-4f16-ba19-52e009daa481"), new Guid("d5179cdb-710b-4fb9-9769-cb294a9e731f") },
                    { new Guid("fa1e3596-898d-424d-af06-b1a0271a0fbe"), "Kitchen", new DateTime(2022, 3, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), null, "9", 2277, "9", null, new Guid("f37f31e2-d2e5-4d79-8585-e72b2d308661"), false, new Guid("fb5efe71-ca31-461f-be55-351c433bf477"), new Guid("4dab4c07-cda5-4724-8f7b-53f0ee2a04a3") },
                    { new Guid("fd1651a0-8e3c-4e87-9b92-efc39dd571b6"), "Furniture", new DateTime(2022, 2, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), null, "126", 31878, "126", null, new Guid("2aadefab-7a22-422e-875c-bc0bfd63515a"), false, new Guid("fdbb883d-7c26-40a2-bd7f-15f9298a9f42"), new Guid("c323a3c7-33b5-428b-bc02-d9d0820dc18c") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Defects_Inventory_InventoryId",
                table: "Defects",
                column: "InventoryId",
                principalTable: "Inventory",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Rooms_RoomId",
                table: "Inventory",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Users_UserId",
                table: "Inventory",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Setups_Rooms_RoomId",
                table: "Setups",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }
    }
}
