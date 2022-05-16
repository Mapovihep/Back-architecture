using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Levi_Inventarization_Backend.Migrations
{
    public partial class testMock5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("4ba4825a-1dce-4291-b6e3-025f9032409e"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("5f0c319b-7751-4e45-997e-4b82308312d2"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("a3d7fbf7-0cbe-4fda-96ee-cd5140281291"));

            migrationBuilder.DeleteData(
                table: "Setups",
                keyColumn: "Id",
                keyValue: new Guid("297510f1-9dfb-47d9-a1fc-130e08406ba1"));

            migrationBuilder.DeleteData(
                table: "Setups",
                keyColumn: "Id",
                keyValue: new Guid("51e2cecb-3614-491a-a90f-e5a0dea9a56b"));

            migrationBuilder.DeleteData(
                table: "Setups",
                keyColumn: "Id",
                keyValue: new Guid("cff8fdb3-010b-41b2-86bc-0da4fb43788f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13f7a3d4-8b15-432a-98d9-b118a09b7f15"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4646f67a-c751-4e11-8af0-91d7575eb49f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48a10b7e-6b57-457d-b9ec-38585ac2bc52"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("63e4f715-f264-441f-bec5-6407fc6f4e4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("64109abb-3cc7-45de-a727-18fdc8849574"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70741402-7368-4cc7-9dd2-3712d00079dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76c3969e-642e-4cb5-a221-8b9b1aa32536"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ad36067-6e1f-4f19-9b84-38569c98b5e5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b5a3d934-0530-488f-b110-e63c9e5edf82"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bcbbed2a-9fa5-4f8c-a6e4-8d805f758e7e"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("ea9da194-1f06-4639-925b-64255483df7b"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdateBy" },
                values: new object[] { new Guid("53f78352-d9a5-4356-a245-bef25d93e28e"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "Office Department", new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb") });

            migrationBuilder.InsertData(
                table: "Setups",
                columns: new[] { "Id", "Category", "CreatedAt", "Name", "Image", "RoomId", "RoomName", "Status", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), "WorkPlaces", new DateTime(2022, 3, 25, 12, 59, 27, 751, DateTimeKind.Local).AddTicks(6201), "Ruby Work Desk", "QRCode", null, "Ruby", false, new DateTime(2022, 3, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5a7a3da3-d6a7-4931-b8b4-7cdfa1e38d65") },
                    { new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), "WorkPlaces", new DateTime(2022, 3, 25, 12, 59, 27, 751, DateTimeKind.Local).AddTicks(6225), ".Net Work Desk", "QRCode", null, ".Net", false, new DateTime(2022, 3, 7, 16, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("1814522f-0ad6-4ec8-8e0a-027650ec506a") },
                    { new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), "WorkPlaces", new DateTime(2022, 3, 25, 12, 59, 27, 751, DateTimeKind.Local).AddTicks(6221), "Node Work Desk", "QRCode", null, "Node", false, new DateTime(2022, 3, 10, 18, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("277bafb7-2e12-4b69-8cc8-86fd51b02599") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsAdmin", "LastName", "Name", "Password", "Phone", "SetupId", "SetupName", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("1814522f-0ad6-4ec8-8e0a-027650ec506a"), new DateTime(2022, 3, 25, 12, 59, 27, 751, DateTimeKind.Local).AddTicks(6037), "2", false, "Pl", "kw", "2", "0", null, null, new Guid("e124d9af-0229-4ec8-bfe5-0eaf3da6ccd2") },
                    { new Guid("277bafb7-2e12-4b69-8cc8-86fd51b02599"), new DateTime(2022, 3, 25, 12, 59, 27, 751, DateTimeKind.Local).AddTicks(6019), "1", false, "P", "E", "1", "3", null, null, new Guid("0b96352e-41d9-4b11-96d4-79cac9df62c6") },
                    { new Guid("5a7a3da3-d6a7-4931-b8b4-7cdfa1e38d65"), new DateTime(2022, 3, 25, 12, 59, 27, 751, DateTimeKind.Local).AddTicks(5971), "0", true, "", "", "0", "2", null, null, new Guid("2df68843-b482-46d5-8966-2338cefea001") },
                    { new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new DateTime(2022, 3, 25, 12, 59, 27, 751, DateTimeKind.Local).AddTicks(6134), "10", true, "VSdsjFjKNV", "lnODcVSXaU", "10", "10", null, null, new Guid("13b8dcf0-8afa-4aea-bd48-2d7ddfd3b089") },
                    { new Guid("6c227153-efd1-4e94-9d44-efc8f756be2d"), new DateTime(2022, 3, 25, 12, 59, 27, 751, DateTimeKind.Local).AddTicks(6062), "5", false, "lenfx", "KiEhP", "5", "7", null, null, new Guid("14d73128-04a4-45d9-ad44-9e7dfc2e7c44") },
                    { new Guid("76e0b472-0466-4496-b7a4-3d64367f2a60"), new DateTime(2022, 3, 25, 12, 59, 27, 751, DateTimeKind.Local).AddTicks(6050), "4", false, "SKVy", "CzpO", "4", "6", null, null, new Guid("40c8a261-4cbb-417b-8f24-857b6fbec60a") },
                    { new Guid("d96059d7-a233-47f4-a83e-7c59910d25d9"), new DateTime(2022, 3, 25, 12, 59, 27, 751, DateTimeKind.Local).AddTicks(6043), "3", true, "lyS", "JBJ", "3", "1", null, null, new Guid("fcca91ed-85c6-4d83-b0d6-0bce294c61a3") },
                    { new Guid("e38923a3-697e-4405-ab97-5fa3020df6c8"), new DateTime(2022, 3, 25, 12, 59, 27, 751, DateTimeKind.Local).AddTicks(6068), "6", true, "tHIfxH", "RPLgAB", "6", "4", null, null, new Guid("4b05fb90-b4bf-46aa-8f48-ece6eb596fa3") },
                    { new Guid("e7c2e230-6377-4e2c-b6f5-ecd2ca836b8e"), new DateTime(2022, 3, 25, 12, 59, 27, 751, DateTimeKind.Local).AddTicks(6122), "8", false, "hPvhWmRT", "pWacUGJq", "8", "10", null, null, new Guid("d69e69cc-d07e-41b7-85d8-04c5339c4f0f") },
                    { new Guid("f8a827d7-7c72-4fac-a919-03478aa408b5"), new DateTime(2022, 3, 25, 12, 59, 27, 751, DateTimeKind.Local).AddTicks(6114), "7", false, "NvtGGOQ", "vxUpzqI", "7", "5", null, null, new Guid("5175be64-f693-4ac8-a760-e0d11dcf7c58") }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Name" },
                values: new object[] { new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new DateTime(2022, 3, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), new Guid("53f78352-d9a5-4356-a245-bef25d93e28e"), "Node" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Name" },
                values: new object[] { new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("53f78352-d9a5-4356-a245-bef25d93e28e"), "Ruby" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Name" },
                values: new object[] { new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new DateTime(2022, 3, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), new Guid("53f78352-d9a5-4356-a245-bef25d93e28e"), ".Net" });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "Id", "Category", "CreatedAt", "DepartmentId", "Name", "Price", "QRCode", "RoomId", "SetupId", "Status", "UpdateBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("01fb8a81-75f5-41c2-ae6a-dc15facd19f1"), "Kitchen", new DateTime(2022, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), null, "qBMlYwDM", 33902, "QR 134", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("f8a827d7-7c72-4fac-a919-03478aa408b5") },
                    { new Guid("088033be-5470-45eb-81f5-a3778e1b9e2c"), "Computers", new DateTime(2022, 2, 28, 2, 0, 0, 0, DateTimeKind.Unspecified), null, "SNBvaFGm", 29854, "QR 118", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("6c227153-efd1-4e94-9d44-efc8f756be2d") },
                    { new Guid("08d29254-7738-4ab4-9b9c-457d8f611d02"), "Kitchen", new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "mpojSITN", 0, "QR 0", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("e38923a3-697e-4405-ab97-5fa3020df6c8") },
                    { new Guid("0d13028b-37ee-4482-ad3a-a1c80876c12c"), "Computers", new DateTime(2022, 3, 4, 11, 0, 0, 0, DateTimeKind.Unspecified), null, "TzOgFxLO", 9750, "QR 13", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb") },
                    { new Guid("0d903e44-15e4-4269-ae50-31c50c64f7aa"), "Furniture", new DateTime(2022, 2, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "hVBBOPZb", 101400, "QR 156", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5a7a3da3-d6a7-4931-b8b4-7cdfa1e38d65") },
                    { new Guid("10ffdc22-56ad-4162-8c3a-919460ae9066"), "Kitchen", new DateTime(2022, 2, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "LbHKptIg", 70200, "QR 108", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("277bafb7-2e12-4b69-8cc8-86fd51b02599") },
                    { new Guid("1534d191-0ba9-4481-8b09-3f29de9fda87"), "Kitchen", new DateTime(2022, 3, 1, 22, 0, 0, 0, DateTimeKind.Unspecified), null, "zPRzaXnK", 18722, "QR 74", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("1814522f-0ad6-4ec8-8e0a-027650ec506a") },
                    { new Guid("1539cec9-a6dd-4eac-9192-fe8e003de4ec"), "Kitchen", new DateTime(2022, 2, 27, 19, 0, 0, 0, DateTimeKind.Unspecified), null, "tKRSxwvt", 4000, "QR 125", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("e38923a3-697e-4405-ab97-5fa3020df6c8") },
                    { new Guid("18c713df-e010-4bb8-92c9-de953914e3f5"), "Computers", new DateTime(2022, 3, 4, 2, 0, 0, 0, DateTimeKind.Unspecified), null, "ALqkjjOq", 5566, "QR 22", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("76e0b472-0466-4496-b7a4-3d64367f2a60") },
                    { new Guid("18dd8900-8c12-4d80-b80e-40a803336bed"), "Furniture", new DateTime(2022, 2, 26, 22, 0, 0, 0, DateTimeKind.Unspecified), null, "VrNEjCuW", 36938, "QR 146", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb") },
                    { new Guid("1b033a21-f0fe-4d89-8b91-85ffb26dcb25"), "Kitchen", new DateTime(2022, 2, 27, 7, 0, 0, 0, DateTimeKind.Unspecified), null, "LGCsXGXm", 34661, "QR 137", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("6c227153-efd1-4e94-9d44-efc8f756be2d") },
                    { new Guid("1e52058d-26fb-42c9-a557-e610389b0ebf"), "Furniture", new DateTime(2022, 3, 4, 23, 0, 0, 0, DateTimeKind.Unspecified), null, "MKQAadRf", 750, "QR 1", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("e38923a3-697e-4405-ab97-5fa3020df6c8") },
                    { new Guid("1eda9ec8-5bc6-446d-9d8f-e640ea4ac3f4"), "Computers", new DateTime(2022, 2, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), null, "evIDAmPb", 72750, "QR 97", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("277bafb7-2e12-4b69-8cc8-86fd51b02599") },
                    { new Guid("203b655f-2505-4b58-ab3a-87d9d4f6635a"), "Computers", new DateTime(2022, 3, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), null, "ecPXYgaw", 63750, "QR 85", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("1814522f-0ad6-4ec8-8e0a-027650ec506a") },
                    { new Guid("2280b9de-23c1-47e9-bcc7-676137be0e9d"), "Kitchen", new DateTime(2022, 2, 27, 21, 0, 0, 0, DateTimeKind.Unspecified), null, "QBnDVZqr", 31119, "QR 123", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("1814522f-0ad6-4ec8-8e0a-027650ec506a") },
                    { new Guid("27b61faf-73ed-4c37-8422-2381f3fba99f"), "Kitchen", new DateTime(2022, 3, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), null, "cRCnMfVD", 759, "QR 3", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("277bafb7-2e12-4b69-8cc8-86fd51b02599") },
                    { new Guid("318c4db5-5d1c-454f-8bfd-89be2c1226ad"), "Computers", new DateTime(2022, 3, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), null, "QSMotLxc", 54750, "QR 73", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb") },
                    { new Guid("3216deaf-c2d3-459e-a0fc-40649197b278"), "Furniture", new DateTime(2022, 2, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), null, "xkNritHX", 90750, "QR 121", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("6c227153-efd1-4e94-9d44-efc8f756be2d") },
                    { new Guid("35bebde8-4d90-4c9c-9b08-285566a58cd1"), "Kitchen", new DateTime(2022, 3, 2, 4, 0, 0, 0, DateTimeKind.Unspecified), null, "aOUpeOKb", 44200, "QR 68", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5a7a3da3-d6a7-4931-b8b4-7cdfa1e38d65") },
                    { new Guid("36a0c1de-eb22-4ca7-8b02-453a3f93e122"), "Furniture", new DateTime(2022, 3, 2, 1, 0, 0, 0, DateTimeKind.Unspecified), null, "bLjREJxg", 17963, "QR 71", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("76e0b472-0466-4496-b7a4-3d64367f2a60") },
                    { new Guid("36ed4b4a-88fb-41b9-851b-9c057203d317"), "Furniture", new DateTime(2022, 2, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), null, "kNxkHOoC", 90750, "QR 121", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb") },
                    { new Guid("376079d2-6487-4d3e-9fbf-9c2119ba5df2"), "Computers", new DateTime(2022, 3, 4, 5, 0, 0, 0, DateTimeKind.Unspecified), null, "tvHRnoGo", 14250, "QR 19", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb") },
                    { new Guid("3a00445c-1236-405e-b5ed-d3b3039d0d07"), "Kitchen", new DateTime(2022, 2, 26, 9, 0, 0, 0, DateTimeKind.Unspecified), null, "hYdRmElz", 40227, "QR 159", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("e38923a3-697e-4405-ab97-5fa3020df6c8") },
                    { new Guid("3aba7265-8b79-4f8d-8092-73ab0796bf16"), "Computers", new DateTime(2022, 2, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), null, "fLZCBjzt", 119600, "QR 184", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("e38923a3-697e-4405-ab97-5fa3020df6c8") },
                    { new Guid("3c83e66d-b7aa-4e13-8957-d75542beb883"), "Kitchen", new DateTime(2022, 3, 4, 6, 0, 0, 0, DateTimeKind.Unspecified), null, "TQrvfjDq", 4554, "QR 18", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("6c227153-efd1-4e94-9d44-efc8f756be2d") },
                    { new Guid("3f88d153-2ce1-4ee1-b7f6-e59a3bf81bb4"), "Kitchen", new DateTime(2022, 2, 28, 22, 0, 0, 0, DateTimeKind.Unspecified), null, "fEVrpNVA", 24794, "QR 98", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("277bafb7-2e12-4b69-8cc8-86fd51b02599") },
                    { new Guid("40061b40-d668-4c45-a6f7-9219ce002cad"), "Computers", new DateTime(2022, 3, 4, 2, 0, 0, 0, DateTimeKind.Unspecified), null, "DfhLTZyS", 5566, "QR 22", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("d96059d7-a233-47f4-a83e-7c59910d25d9") },
                    { new Guid("42db678d-310b-4f29-9a28-8ed3c258929a"), "Computers", new DateTime(2022, 3, 3, 20, 0, 0, 0, DateTimeKind.Unspecified), null, "zdOWgHAG", 18200, "QR 28", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("e7c2e230-6377-4e2c-b6f5-ecd2ca836b8e") },
                    { new Guid("4ac0c977-97cd-4152-8a37-8f0542614026"), "Computers", new DateTime(2022, 3, 4, 5, 0, 0, 0, DateTimeKind.Unspecified), null, "EYPCdfDj", 14250, "QR 19", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5a7a3da3-d6a7-4931-b8b4-7cdfa1e38d65") },
                    { new Guid("51196db2-016b-403e-ba80-63f4282a8e52"), "Kitchen", new DateTime(2022, 3, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), null, "buRZJsmB", 10626, "QR 42", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("6c227153-efd1-4e94-9d44-efc8f756be2d") },
                    { new Guid("563885db-c1a9-42ec-8178-b58221d975a1"), "Kitchen", new DateTime(2022, 3, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "mLOgaUOg", 7800, "QR 12", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5a7a3da3-d6a7-4931-b8b4-7cdfa1e38d65") },
                    { new Guid("5c76dea8-75ad-4301-b877-aa640a07c900"), "Kitchen", new DateTime(2022, 2, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), null, "BBSlBmzT", 3520, "QR 110", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("1814522f-0ad6-4ec8-8e0a-027650ec506a") },
                    { new Guid("5f73a4b4-395a-4a64-accf-24967b00e46e"), "Furniture", new DateTime(2022, 3, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "FQbfmvCY", 23400, "QR 36", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("d96059d7-a233-47f4-a83e-7c59910d25d9") },
                    { new Guid("630736af-1df8-429f-bf6f-f2de29dfbf75"), "Kitchen", new DateTime(2022, 3, 3, 1, 0, 0, 0, DateTimeKind.Unspecified), null, "cALjkAeJ", 11891, "QR 47", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("d96059d7-a233-47f4-a83e-7c59910d25d9") },
                    { new Guid("6747e895-60e0-433a-8cc1-b04e7afdcaf7"), "Computers", new DateTime(2022, 2, 28, 23, 0, 0, 0, DateTimeKind.Unspecified), null, "XkEPQlWp", 72750, "QR 97", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("1814522f-0ad6-4ec8-8e0a-027650ec506a") },
                    { new Guid("68abd06d-de41-4bd7-aad5-8c7bf6b9bffe"), "Kitchen", new DateTime(2022, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), null, "HydPONaM", 33902, "QR 134", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("e7c2e230-6377-4e2c-b6f5-ecd2ca836b8e") },
                    { new Guid("6a0ad719-70e4-4a97-976a-61bf7a68a38b"), "Computers", new DateTime(2022, 2, 25, 14, 0, 0, 0, DateTimeKind.Unspecified), null, "aBEuoelg", 45034, "QR 178", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb") },
                    { new Guid("6c3dd301-8e7e-4e0b-afdd-fd76bb0f5277"), "Kitchen", new DateTime(2022, 3, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), null, "soHGKRDh", 20999, "QR 83", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("76e0b472-0466-4496-b7a4-3d64367f2a60") },
                    { new Guid("6ebb5aea-1ddf-425b-9e71-fbc9a0db6173"), "Computers", new DateTime(2022, 3, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), null, "iAMLkskB", 27750, "QR 37", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("f8a827d7-7c72-4fac-a919-03478aa408b5") },
                    { new Guid("765f21de-c4cc-4785-8347-f21431e693da"), "Kitchen", new DateTime(2022, 2, 26, 3, 0, 0, 0, DateTimeKind.Unspecified), null, "gNdDeALr", 5280, "QR 165", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("f8a827d7-7c72-4fac-a919-03478aa408b5") },
                    { new Guid("7698bcf4-a80b-4eeb-a281-ff98bbce91f8"), "Computers", new DateTime(2022, 2, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), null, "dZSlvdrg", 81750, "QR 109", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("f8a827d7-7c72-4fac-a919-03478aa408b5") },
                    { new Guid("7799fff9-6340-4680-8653-de31cfaf0882"), "Computers", new DateTime(2022, 2, 25, 5, 0, 0, 0, DateTimeKind.Unspecified), null, "KGeLDbHU", 140250, "QR 187", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("e7c2e230-6377-4e2c-b6f5-ecd2ca836b8e") }
                });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "Id", "Category", "CreatedAt", "DepartmentId", "Name", "Price", "QRCode", "RoomId", "SetupId", "Status", "UpdateBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("7cdb72e5-4228-4718-a0bb-932dbfe1ec2f"), "Kitchen", new DateTime(2022, 3, 4, 22, 0, 0, 0, DateTimeKind.Unspecified), null, "dlwYuObP", 506, "QR 2", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("277bafb7-2e12-4b69-8cc8-86fd51b02599") },
                    { new Guid("7d26e2c9-495b-4dbe-96de-3dd3d65fb714"), "Kitchen", new DateTime(2022, 3, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), null, "bAgQcDvc", 14927, "QR 59", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("6c227153-efd1-4e94-9d44-efc8f756be2d") },
                    { new Guid("813316fb-d453-48b9-a053-26e895ced3d1"), "Kitchen", new DateTime(2022, 3, 2, 22, 0, 0, 0, DateTimeKind.Unspecified), null, "hjMMNSwv", 1600, "QR 50", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5a7a3da3-d6a7-4931-b8b4-7cdfa1e38d65") },
                    { new Guid("8152bc21-e0a0-41cc-83f3-6b47eb5ebd31"), "Kitchen", new DateTime(2022, 2, 27, 1, 0, 0, 0, DateTimeKind.Unspecified), null, "HzSPUOsb", 36179, "QR 143", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5a7a3da3-d6a7-4931-b8b4-7cdfa1e38d65") },
                    { new Guid("856f90c4-69ec-4e46-82b2-eab82e76c26b"), "Kitchen", new DateTime(2022, 3, 2, 13, 0, 0, 0, DateTimeKind.Unspecified), null, "WIdzRtxg", 14927, "QR 59", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("e7c2e230-6377-4e2c-b6f5-ecd2ca836b8e") },
                    { new Guid("858b8717-c5f9-46dc-9dd3-efe9c455fb9c"), "Furniture", new DateTime(2022, 3, 1, 20, 0, 0, 0, DateTimeKind.Unspecified), null, "CsWKAitm", 49400, "QR 76", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("76e0b472-0466-4496-b7a4-3d64367f2a60") },
                    { new Guid("89512c88-80e0-4e4d-a5e3-f6d4c7b75e34"), "Furniture", new DateTime(2022, 2, 26, 2, 0, 0, 0, DateTimeKind.Unspecified), null, "wprUyabY", 41998, "QR 166", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("1814522f-0ad6-4ec8-8e0a-027650ec506a") },
                    { new Guid("8a786613-dd02-42d5-bcf6-ede9912a2f6e"), "Furniture", new DateTime(2022, 3, 3, 22, 0, 0, 0, DateTimeKind.Unspecified), null, "mKeAXcXJ", 6578, "QR 26", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("76e0b472-0466-4496-b7a4-3d64367f2a60") },
                    { new Guid("8b1ddcb9-f8fb-443f-8990-3ab757aea677"), "Kitchen", new DateTime(2022, 3, 3, 1, 0, 0, 0, DateTimeKind.Unspecified), null, "LjsowIen", 11891, "QR 47", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("1814522f-0ad6-4ec8-8e0a-027650ec506a") },
                    { new Guid("8c22fb46-3b4c-420e-a7b9-d3d432b5739d"), "Computers", new DateTime(2022, 2, 26, 8, 0, 0, 0, DateTimeKind.Unspecified), null, "bGjkoZpB", 104000, "QR 160", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("277bafb7-2e12-4b69-8cc8-86fd51b02599") },
                    { new Guid("907fd146-789a-4c9f-9a2f-c082aa9cd157"), "Furniture", new DateTime(2022, 2, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), null, "nQoFTOAO", 33143, "QR 131", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("e7c2e230-6377-4e2c-b6f5-ecd2ca836b8e") },
                    { new Guid("90c9eecc-6580-406e-bc32-565c81e1118c"), "Furniture", new DateTime(2022, 3, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), null, "KGydBBgo", 68250, "QR 91", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("e38923a3-697e-4405-ab97-5fa3020df6c8") },
                    { new Guid("921dd97b-6596-4bac-8258-56bc29bc003c"), "Kitchen", new DateTime(2022, 2, 26, 3, 0, 0, 0, DateTimeKind.Unspecified), null, "ukysBzHr", 5280, "QR 165", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("f8a827d7-7c72-4fac-a919-03478aa408b5") },
                    { new Guid("93d850c7-35bd-4cd7-a6b6-f590ea7e094c"), "Computers", new DateTime(2022, 2, 27, 5, 0, 0, 0, DateTimeKind.Unspecified), null, "ZrQzVzoY", 104250, "QR 139", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("d96059d7-a233-47f4-a83e-7c59910d25d9") },
                    { new Guid("94d4bf7f-558e-4b4a-9798-ffe6be52b92d"), "Kitchen", new DateTime(2022, 2, 27, 1, 0, 0, 0, DateTimeKind.Unspecified), null, "pPhlHVkq", 36179, "QR 143", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("76e0b472-0466-4496-b7a4-3d64367f2a60") },
                    { new Guid("95b9df86-b3e3-456e-886b-7034b4241fb9"), "Computers", new DateTime(2022, 3, 3, 23, 0, 0, 0, DateTimeKind.Unspecified), null, "OhEYFjkm", 18750, "QR 25", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("277bafb7-2e12-4b69-8cc8-86fd51b02599") },
                    { new Guid("9a0cf7bd-3f9c-46e7-86dd-7130f2d629b6"), "Kitchen", new DateTime(2022, 2, 26, 3, 0, 0, 0, DateTimeKind.Unspecified), null, "bfUtCYxg", 5280, "QR 165", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("f8a827d7-7c72-4fac-a919-03478aa408b5") },
                    { new Guid("a07053d4-0ad2-42ca-b0d9-d2ee8334ab5c"), "Kitchen", new DateTime(2022, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LDKKolCw", 109200, "QR 168", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("e38923a3-697e-4405-ab97-5fa3020df6c8") },
                    { new Guid("a8a233a6-a11b-40b6-937b-328770abe076"), "Kitchen", new DateTime(2022, 2, 25, 3, 0, 0, 0, DateTimeKind.Unspecified), null, "sMiGkrZK", 47817, "QR 189", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("6c227153-efd1-4e94-9d44-efc8f756be2d") },
                    { new Guid("a8f9dd85-4fb2-4f21-b590-30c9387a3d41"), "Computers", new DateTime(2022, 3, 3, 5, 0, 0, 0, DateTimeKind.Unspecified), null, "nyRLDQfG", 32250, "QR 43", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("76e0b472-0466-4496-b7a4-3d64367f2a60") },
                    { new Guid("a99b688e-c393-4461-981f-7c3b99acb502"), "Kitchen", new DateTime(2022, 3, 3, 6, 0, 0, 0, DateTimeKind.Unspecified), null, "oRbehTpJ", 10626, "QR 42", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("6c227153-efd1-4e94-9d44-efc8f756be2d") },
                    { new Guid("aa21c052-b79d-4869-909e-f734220b812f"), "Kitchen", new DateTime(2022, 2, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), null, "RxSswpkz", 33902, "QR 134", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("e7c2e230-6377-4e2c-b6f5-ecd2ca836b8e") },
                    { new Guid("acb8757d-f11c-4074-be88-d1f15ae88d60"), "Kitchen", new DateTime(2022, 2, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "Fqdlpxlt", 117000, "QR 180", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb") },
                    { new Guid("b0b86b30-42b9-451c-bc67-4ade9f112fd9"), "Computers", new DateTime(2022, 2, 27, 20, 0, 0, 0, DateTimeKind.Unspecified), null, "eGOaqjYy", 80600, "QR 124", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("277bafb7-2e12-4b69-8cc8-86fd51b02599") },
                    { new Guid("b144230f-0eb1-4825-b25f-575521d8f082"), "Furniture", new DateTime(2022, 3, 1, 5, 0, 0, 0, DateTimeKind.Unspecified), null, "kmdsLncY", 68250, "QR 91", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5a7a3da3-d6a7-4931-b8b4-7cdfa1e38d65") },
                    { new Guid("b37fa986-569b-4ce5-ad2c-67582f376e46"), "Computers", new DateTime(2022, 2, 28, 5, 0, 0, 0, DateTimeKind.Unspecified), null, "TkArIRRl", 86250, "QR 115", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("6c227153-efd1-4e94-9d44-efc8f756be2d") },
                    { new Guid("b39ca608-8646-478c-ba44-4d73cacba022"), "Kitchen", new DateTime(2022, 3, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), null, "iNdHvuzO", 9614, "QR 38", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("e38923a3-697e-4405-ab97-5fa3020df6c8") },
                    { new Guid("be706e99-4124-48cd-b521-1d761ab9f8e5"), "Furniture", new DateTime(2022, 2, 26, 17, 0, 0, 0, DateTimeKind.Unspecified), null, "fYsfdtrb", 113250, "QR 151", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("e7c2e230-6377-4e2c-b6f5-ecd2ca836b8e") },
                    { new Guid("c0848173-dce3-4b68-a426-e77829cfba56"), "Computers", new DateTime(2022, 2, 28, 11, 0, 0, 0, DateTimeKind.Unspecified), null, "yuPEQZCp", 81750, "QR 109", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("d96059d7-a233-47f4-a83e-7c59910d25d9") },
                    { new Guid("c1b891f0-64df-434d-a518-6268f984a420"), "Kitchen", new DateTime(2022, 3, 3, 1, 0, 0, 0, DateTimeKind.Unspecified), null, "RcBWRFZK", 11891, "QR 47", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("d96059d7-a233-47f4-a83e-7c59910d25d9") },
                    { new Guid("c77dfd64-6c76-42ef-bba3-1564a03c842b"), "Kitchen", new DateTime(2022, 3, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), null, "JwJxldZq", 22517, "QR 89", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("76e0b472-0466-4496-b7a4-3d64367f2a60") },
                    { new Guid("c966ef6b-67d3-4dfa-ac55-1de88e1f6aba"), "Kitchen", new DateTime(2022, 2, 27, 7, 0, 0, 0, DateTimeKind.Unspecified), null, "lLSAxMgz", 34661, "QR 137", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb") },
                    { new Guid("cc91d673-96f2-43ad-89cb-bbb5c8d3267d"), "Kitchen", new DateTime(2022, 2, 24, 19, 0, 0, 0, DateTimeKind.Unspecified), null, "vCEmDmDr", 49841, "QR 197", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("d96059d7-a233-47f4-a83e-7c59910d25d9") },
                    { new Guid("d1bcbeb5-b5d5-473b-9e7b-9138afed5046"), "Kitchen", new DateTime(2022, 2, 26, 3, 0, 0, 0, DateTimeKind.Unspecified), null, "epRJeFzx", 5280, "QR 165", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5a7a3da3-d6a7-4931-b8b4-7cdfa1e38d65") },
                    { new Guid("d7758898-bd88-4c16-bfeb-11daec1b3a53"), "Kitchen", new DateTime(2022, 3, 3, 3, 0, 0, 0, DateTimeKind.Unspecified), null, "QlOZOzvL", 1440, "QR 45", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb") },
                    { new Guid("d8b5e7b9-b998-4191-a04d-c01958c85983"), "Computers", new DateTime(2022, 2, 28, 5, 0, 0, 0, DateTimeKind.Unspecified), null, "vjewQLln", 86250, "QR 115", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("f8a827d7-7c72-4fac-a919-03478aa408b5") },
                    { new Guid("dcce5cc5-e0e3-456e-980f-b36445f4d41f"), "Furniture", new DateTime(2022, 2, 25, 21, 0, 0, 0, DateTimeKind.Unspecified), null, "HNOEzqxw", 43263, "QR 171", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("1814522f-0ad6-4ec8-8e0a-027650ec506a") },
                    { new Guid("de5b1add-ef5a-4a94-b7cd-b733aac14500"), "Kitchen", new DateTime(2022, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "DHsJjPYm", 78000, "QR 120", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("e38923a3-697e-4405-ab97-5fa3020df6c8") },
                    { new Guid("df4d6d48-d3e1-46a7-b882-83f076025658"), "Kitchen", new DateTime(2022, 2, 24, 18, 0, 0, 0, DateTimeKind.Unspecified), null, "ZTfsNTuk", 50094, "QR 198", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("f8a827d7-7c72-4fac-a919-03478aa408b5") },
                    { new Guid("dfc5a46d-3953-4cf3-a8c5-d266f1bc4071"), "Kitchen", new DateTime(2022, 2, 26, 3, 0, 0, 0, DateTimeKind.Unspecified), null, "IGvahnbL", 5280, "QR 165", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("76e0b472-0466-4496-b7a4-3d64367f2a60") },
                    { new Guid("e1385848-d2a9-4cbd-81b8-b90193c7f885"), "Kitchen", new DateTime(2022, 3, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), null, "FdXuQzMU", 20999, "QR 83", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("e7c2e230-6377-4e2c-b6f5-ecd2ca836b8e") },
                    { new Guid("e25ef516-c6e5-4413-9b20-8efe5d41fee5"), "Furniture", new DateTime(2022, 2, 28, 4, 0, 0, 0, DateTimeKind.Unspecified), null, "XreWfkbC", 75400, "QR 116", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"), false, null, new Guid("1814522f-0ad6-4ec8-8e0a-027650ec506a") }
                });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "Id", "Category", "CreatedAt", "DepartmentId", "Name", "Price", "QRCode", "RoomId", "SetupId", "Status", "UpdateBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("eb7a0af2-ab26-4ac3-a153-ca374c9f7808"), "Kitchen", new DateTime(2022, 3, 1, 22, 0, 0, 0, DateTimeKind.Unspecified), null, "hxcfSxdB", 18722, "QR 74", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("d96059d7-a233-47f4-a83e-7c59910d25d9") },
                    { new Guid("edf3bbbd-3a86-4a6d-9deb-02c78bfd7b44"), "Computers", new DateTime(2022, 3, 4, 5, 0, 0, 0, DateTimeKind.Unspecified), null, "LxejnCIi", 14250, "QR 19", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("277bafb7-2e12-4b69-8cc8-86fd51b02599") },
                    { new Guid("efc50f2e-a801-482f-b2c0-78250ba076ba"), "Computers", new DateTime(2022, 2, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), null, "DmPHKtSJ", 96200, "QR 148", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, null, new Guid("e7c2e230-6377-4e2c-b6f5-ecd2ca836b8e") },
                    { new Guid("f1987f1b-c1ee-4fb0-81a1-9bad1ad9fc64"), "Kitchen", new DateTime(2022, 2, 26, 1, 0, 0, 0, DateTimeKind.Unspecified), null, "qlnzSfeM", 42251, "QR 167", new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("5a7a3da3-d6a7-4931-b8b4-7cdfa1e38d65") },
                    { new Guid("fbd6f412-c6b0-42ab-ba43-562e128acef2"), "Kitchen", new DateTime(2022, 2, 25, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "evaICgju", 117000, "QR 180", new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"), new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"), false, new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"), new Guid("d96059d7-a233-47f4-a83e-7c59910d25d9") },
                    { new Guid("fbe2cb2e-d327-4dfb-a420-921d737e41c5"), "Furniture", new DateTime(2022, 2, 27, 23, 0, 0, 0, DateTimeKind.Unspecified), null, "DCeihJWo", 90750, "QR 121", new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"), new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"), false, null, new Guid("f8a827d7-7c72-4fac-a919-03478aa408b5") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("01fb8a81-75f5-41c2-ae6a-dc15facd19f1"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("088033be-5470-45eb-81f5-a3778e1b9e2c"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("08d29254-7738-4ab4-9b9c-457d8f611d02"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("0d13028b-37ee-4482-ad3a-a1c80876c12c"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("0d903e44-15e4-4269-ae50-31c50c64f7aa"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("10ffdc22-56ad-4162-8c3a-919460ae9066"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("1534d191-0ba9-4481-8b09-3f29de9fda87"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("1539cec9-a6dd-4eac-9192-fe8e003de4ec"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("18c713df-e010-4bb8-92c9-de953914e3f5"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("18dd8900-8c12-4d80-b80e-40a803336bed"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("1b033a21-f0fe-4d89-8b91-85ffb26dcb25"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("1e52058d-26fb-42c9-a557-e610389b0ebf"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("1eda9ec8-5bc6-446d-9d8f-e640ea4ac3f4"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("203b655f-2505-4b58-ab3a-87d9d4f6635a"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("2280b9de-23c1-47e9-bcc7-676137be0e9d"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("27b61faf-73ed-4c37-8422-2381f3fba99f"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("318c4db5-5d1c-454f-8bfd-89be2c1226ad"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("3216deaf-c2d3-459e-a0fc-40649197b278"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("35bebde8-4d90-4c9c-9b08-285566a58cd1"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("36a0c1de-eb22-4ca7-8b02-453a3f93e122"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("36ed4b4a-88fb-41b9-851b-9c057203d317"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("376079d2-6487-4d3e-9fbf-9c2119ba5df2"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("3a00445c-1236-405e-b5ed-d3b3039d0d07"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("3aba7265-8b79-4f8d-8092-73ab0796bf16"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("3c83e66d-b7aa-4e13-8957-d75542beb883"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("3f88d153-2ce1-4ee1-b7f6-e59a3bf81bb4"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("40061b40-d668-4c45-a6f7-9219ce002cad"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("42db678d-310b-4f29-9a28-8ed3c258929a"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("4ac0c977-97cd-4152-8a37-8f0542614026"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("51196db2-016b-403e-ba80-63f4282a8e52"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("563885db-c1a9-42ec-8178-b58221d975a1"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("5c76dea8-75ad-4301-b877-aa640a07c900"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("5f73a4b4-395a-4a64-accf-24967b00e46e"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("630736af-1df8-429f-bf6f-f2de29dfbf75"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("6747e895-60e0-433a-8cc1-b04e7afdcaf7"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("68abd06d-de41-4bd7-aad5-8c7bf6b9bffe"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("6a0ad719-70e4-4a97-976a-61bf7a68a38b"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("6c3dd301-8e7e-4e0b-afdd-fd76bb0f5277"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("6ebb5aea-1ddf-425b-9e71-fbc9a0db6173"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("765f21de-c4cc-4785-8347-f21431e693da"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("7698bcf4-a80b-4eeb-a281-ff98bbce91f8"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("7799fff9-6340-4680-8653-de31cfaf0882"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("7cdb72e5-4228-4718-a0bb-932dbfe1ec2f"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("7d26e2c9-495b-4dbe-96de-3dd3d65fb714"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("813316fb-d453-48b9-a053-26e895ced3d1"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("8152bc21-e0a0-41cc-83f3-6b47eb5ebd31"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("856f90c4-69ec-4e46-82b2-eab82e76c26b"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("858b8717-c5f9-46dc-9dd3-efe9c455fb9c"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("89512c88-80e0-4e4d-a5e3-f6d4c7b75e34"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("8a786613-dd02-42d5-bcf6-ede9912a2f6e"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("8b1ddcb9-f8fb-443f-8990-3ab757aea677"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("8c22fb46-3b4c-420e-a7b9-d3d432b5739d"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("907fd146-789a-4c9f-9a2f-c082aa9cd157"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("90c9eecc-6580-406e-bc32-565c81e1118c"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("921dd97b-6596-4bac-8258-56bc29bc003c"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("93d850c7-35bd-4cd7-a6b6-f590ea7e094c"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("94d4bf7f-558e-4b4a-9798-ffe6be52b92d"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("95b9df86-b3e3-456e-886b-7034b4241fb9"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("9a0cf7bd-3f9c-46e7-86dd-7130f2d629b6"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("a07053d4-0ad2-42ca-b0d9-d2ee8334ab5c"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("a8a233a6-a11b-40b6-937b-328770abe076"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("a8f9dd85-4fb2-4f21-b590-30c9387a3d41"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("a99b688e-c393-4461-981f-7c3b99acb502"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("aa21c052-b79d-4869-909e-f734220b812f"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("acb8757d-f11c-4074-be88-d1f15ae88d60"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("b0b86b30-42b9-451c-bc67-4ade9f112fd9"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("b144230f-0eb1-4825-b25f-575521d8f082"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("b37fa986-569b-4ce5-ad2c-67582f376e46"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("b39ca608-8646-478c-ba44-4d73cacba022"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("be706e99-4124-48cd-b521-1d761ab9f8e5"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("c0848173-dce3-4b68-a426-e77829cfba56"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("c1b891f0-64df-434d-a518-6268f984a420"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("c77dfd64-6c76-42ef-bba3-1564a03c842b"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("c966ef6b-67d3-4dfa-ac55-1de88e1f6aba"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("cc91d673-96f2-43ad-89cb-bbb5c8d3267d"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("d1bcbeb5-b5d5-473b-9e7b-9138afed5046"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("d7758898-bd88-4c16-bfeb-11daec1b3a53"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("d8b5e7b9-b998-4191-a04d-c01958c85983"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("dcce5cc5-e0e3-456e-980f-b36445f4d41f"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("de5b1add-ef5a-4a94-b7cd-b733aac14500"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("df4d6d48-d3e1-46a7-b882-83f076025658"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("dfc5a46d-3953-4cf3-a8c5-d266f1bc4071"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("e1385848-d2a9-4cbd-81b8-b90193c7f885"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("e25ef516-c6e5-4413-9b20-8efe5d41fee5"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("eb7a0af2-ab26-4ac3-a153-ca374c9f7808"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("edf3bbbd-3a86-4a6d-9deb-02c78bfd7b44"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("efc50f2e-a801-482f-b2c0-78250ba076ba"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("f1987f1b-c1ee-4fb0-81a1-9bad1ad9fc64"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("fbd6f412-c6b0-42ab-ba43-562e128acef2"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("fbe2cb2e-d327-4dfb-a420-921d737e41c5"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("1f8a08c4-f535-4807-83cc-6c74a76d3676"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("5bef8e9b-4f39-4b43-9a8f-c7b900b96afd"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("e49c6469-cdd8-43af-b636-ee816b294c14"));

            migrationBuilder.DeleteData(
                table: "Setups",
                keyColumn: "Id",
                keyValue: new Guid("428b81df-44a1-4502-aafd-8a4e4a406594"));

            migrationBuilder.DeleteData(
                table: "Setups",
                keyColumn: "Id",
                keyValue: new Guid("b7c7e2e3-1f03-4ce6-a845-84adf47af4fa"));

            migrationBuilder.DeleteData(
                table: "Setups",
                keyColumn: "Id",
                keyValue: new Guid("ed0e1f5c-283a-4f1a-858c-0539e24a8ebe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1814522f-0ad6-4ec8-8e0a-027650ec506a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("277bafb7-2e12-4b69-8cc8-86fd51b02599"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5a7a3da3-d6a7-4931-b8b4-7cdfa1e38d65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fecaddd-72c0-4bca-84d5-3ef56f7e93fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6c227153-efd1-4e94-9d44-efc8f756be2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("76e0b472-0466-4496-b7a4-3d64367f2a60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d96059d7-a233-47f4-a83e-7c59910d25d9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e38923a3-697e-4405-ab97-5fa3020df6c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e7c2e230-6377-4e2c-b6f5-ecd2ca836b8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f8a827d7-7c72-4fac-a919-03478aa408b5"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("53f78352-d9a5-4356-a245-bef25d93e28e"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdateBy" },
                values: new object[] { new Guid("ea9da194-1f06-4639-925b-64255483df7b"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "Office Department", new Guid("48a10b7e-6b57-457d-b9ec-38585ac2bc52") });

            migrationBuilder.InsertData(
                table: "Setups",
                columns: new[] { "Id", "Category", "CreatedAt", "Name", "Image", "RoomId", "RoomName", "Status", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("297510f1-9dfb-47d9-a1fc-130e08406ba1"), "WorkPlaces", new DateTime(2022, 3, 25, 12, 55, 29, 964, DateTimeKind.Local).AddTicks(2372), "Ruby Work Desk", "QRCode", null, "Ruby", false, new DateTime(2022, 3, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48a10b7e-6b57-457d-b9ec-38585ac2bc52"), new Guid("64109abb-3cc7-45de-a727-18fdc8849574") },
                    { new Guid("51e2cecb-3614-491a-a90f-e5a0dea9a56b"), "WorkPlaces", new DateTime(2022, 3, 25, 12, 55, 29, 964, DateTimeKind.Local).AddTicks(2392), "Node Work Desk", "QRCode", null, "Node", false, new DateTime(2022, 3, 10, 22, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48a10b7e-6b57-457d-b9ec-38585ac2bc52"), new Guid("76c3969e-642e-4cb5-a221-8b9b1aa32536") },
                    { new Guid("cff8fdb3-010b-41b2-86bc-0da4fb43788f"), "WorkPlaces", new DateTime(2022, 3, 25, 12, 55, 29, 964, DateTimeKind.Local).AddTicks(2396), ".Net Work Desk", "QRCode", null, ".Net", false, new DateTime(2022, 3, 10, 2, 0, 0, 0, DateTimeKind.Unspecified), new Guid("48a10b7e-6b57-457d-b9ec-38585ac2bc52"), new Guid("9ad36067-6e1f-4f19-9b84-38569c98b5e5") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsAdmin", "LastName", "Name", "Password", "Phone", "SetupId", "SetupName", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("13f7a3d4-8b15-432a-98d9-b118a09b7f15"), new DateTime(2022, 3, 25, 12, 55, 29, 964, DateTimeKind.Local).AddTicks(2241), "3", true, "psa", "kZp", "3", "1", null, null, new Guid("9c3cd523-5c6f-46cc-af17-7a49efac58a0") },
                    { new Guid("4646f67a-c751-4e11-8af0-91d7575eb49f"), new DateTime(2022, 3, 25, 12, 55, 29, 964, DateTimeKind.Local).AddTicks(2248), "4", false, "fJQI", "NSjI", "4", "6", null, null, new Guid("63a52faa-99d0-4754-90cd-117e207322d7") },
                    { new Guid("48a10b7e-6b57-457d-b9ec-38585ac2bc52"), new DateTime(2022, 3, 25, 12, 55, 29, 964, DateTimeKind.Local).AddTicks(2290), "10", true, "ifxdGGYZIm", "SJiofPjPnU", "10", "10", null, null, new Guid("2a0ef830-5d13-4273-8e19-c2b9988f7721") },
                    { new Guid("63e4f715-f264-441f-bec5-6407fc6f4e4b"), new DateTime(2022, 3, 25, 12, 55, 29, 964, DateTimeKind.Local).AddTicks(2257), "5", false, "AyotP", "uYyFc", "5", "7", null, null, new Guid("af74c14f-7cab-41fe-8c50-35d6520a745b") },
                    { new Guid("64109abb-3cc7-45de-a727-18fdc8849574"), new DateTime(2022, 3, 25, 12, 55, 29, 964, DateTimeKind.Local).AddTicks(2146), "0", true, "", "", "0", "2", null, null, new Guid("a3824c2d-1e34-4356-a06f-7d63546bb6c6") },
                    { new Guid("70741402-7368-4cc7-9dd2-3712d00079dd"), new DateTime(2022, 3, 25, 12, 55, 29, 964, DateTimeKind.Local).AddTicks(2264), "6", true, "NybSPt", "nmNxMW", "6", "4", null, null, new Guid("910f8974-65b9-40bc-966a-638525c74add") },
                    { new Guid("76c3969e-642e-4cb5-a221-8b9b1aa32536"), new DateTime(2022, 3, 25, 12, 55, 29, 964, DateTimeKind.Local).AddTicks(2186), "1", false, "N", "s", "1", "3", null, null, new Guid("0b4ba2a4-ec09-48e1-aca6-54493a15dedc") },
                    { new Guid("9ad36067-6e1f-4f19-9b84-38569c98b5e5"), new DateTime(2022, 3, 25, 12, 55, 29, 964, DateTimeKind.Local).AddTicks(2207), "2", false, "ZZ", "Sv", "2", "0", null, null, new Guid("792b1963-ff4d-4cbc-9241-cc102d1cc5fb") },
                    { new Guid("b5a3d934-0530-488f-b110-e63c9e5edf82"), new DateTime(2022, 3, 25, 12, 55, 29, 964, DateTimeKind.Local).AddTicks(2280), "8", false, "JVuUKtJk", "PvbDMmZU", "8", "10", null, null, new Guid("a3730a8a-2d8c-4d12-a39c-3fa879c4a936") },
                    { new Guid("bcbbed2a-9fa5-4f8c-a6e4-8d805f758e7e"), new DateTime(2022, 3, 25, 12, 55, 29, 964, DateTimeKind.Local).AddTicks(2273), "7", false, "fjkAkbh", "yOixgqr", "7", "5", null, null, new Guid("9d8712ec-55c1-4f7c-b5b6-39df58c3c696") }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Name" },
                values: new object[] { new Guid("4ba4825a-1dce-4291-b6e3-025f9032409e"), new DateTime(2022, 3, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ea9da194-1f06-4639-925b-64255483df7b"), "Node" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Name" },
                values: new object[] { new Guid("5f0c319b-7751-4e45-997e-4b82308312d2"), new DateTime(2022, 3, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ea9da194-1f06-4639-925b-64255483df7b"), ".Net" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Name" },
                values: new object[] { new Guid("a3d7fbf7-0cbe-4fda-96ee-cd5140281291"), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ea9da194-1f06-4639-925b-64255483df7b"), "Ruby" });
        }
    }
}
