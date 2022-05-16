using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Levi_Inventarization_Backend.Migrations
{
    public partial class testMock4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("0268c3ff-c937-4932-9d91-6cabdb65b3e0"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("85820674-82db-4b4b-a521-8578cea9849a"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("dc743943-6c5c-4d4e-9c6c-fc45f531f98e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c115248-b1cc-4fbc-a607-66f6c952e8c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27aa471e-f6e4-4487-8a14-c28414e56ff5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("441576a7-bc71-4d14-994b-94cddf8191b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("476b60d6-b579-4ed7-8150-69cf5ff734b7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("54de72cb-b1ff-4803-b4eb-7d211823e03a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8907d3c7-0cd5-4de3-8df4-5ba0063f9357"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9147208-a488-4407-ac59-d0f52029e20c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aeadeca8-666d-4b7c-8858-d08feb6838fb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d70a0553-4c29-4f87-a43e-3951cc1daa38"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee4d33f9-5a94-4461-9ea2-9e2295d684c4"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("7e352b0f-b369-4f51-b723-a7e4784188c8"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("7e352b0f-b369-4f51-b723-a7e4784188c8"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "Office Department", new Guid("aeadeca8-666d-4b7c-8858-d08feb6838fb") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsAdmin", "LastName", "Name", "Password", "Phone", "SetupId", "SetupName", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("1c115248-b1cc-4fbc-a607-66f6c952e8c9"), new DateTime(2022, 3, 25, 12, 55, 6, 128, DateTimeKind.Local).AddTicks(6454), "3", true, "JLd", "TvA", "3", "1", null, null, new Guid("87442ccb-7309-43aa-b7a9-4c384254b6dd") },
                    { new Guid("27aa471e-f6e4-4487-8a14-c28414e56ff5"), new DateTime(2022, 3, 25, 12, 55, 6, 128, DateTimeKind.Local).AddTicks(6518), "8", false, "sRWXrdsM", "myvXUvpT", "8", "10", null, null, new Guid("7ca2980f-73e5-4017-8c91-fbcaded621c3") },
                    { new Guid("441576a7-bc71-4d14-994b-94cddf8191b2"), new DateTime(2022, 3, 25, 12, 55, 6, 128, DateTimeKind.Local).AddTicks(6443), "2", false, "xG", "md", "2", "0", null, null, new Guid("a3493027-43a8-4da6-b098-d04cd0c7e9c7") },
                    { new Guid("476b60d6-b579-4ed7-8150-69cf5ff734b7"), new DateTime(2022, 3, 25, 12, 55, 6, 128, DateTimeKind.Local).AddTicks(6501), "6", true, "KonDaP", "awnKaV", "6", "4", null, null, new Guid("9ef660ad-0e1c-41d7-8ee0-18f85c7de71c") },
                    { new Guid("54de72cb-b1ff-4803-b4eb-7d211823e03a"), new DateTime(2022, 3, 25, 12, 55, 6, 128, DateTimeKind.Local).AddTicks(6494), "5", false, "HAikr", "ucoTw", "5", "7", null, null, new Guid("45480663-1141-45d5-b4ae-098ef3b19023") },
                    { new Guid("8907d3c7-0cd5-4de3-8df4-5ba0063f9357"), new DateTime(2022, 3, 25, 12, 55, 6, 128, DateTimeKind.Local).AddTicks(6422), "1", false, "V", "h", "1", "3", null, null, new Guid("4fe861d4-27aa-406e-957a-8c5201716360") },
                    { new Guid("a9147208-a488-4407-ac59-d0f52029e20c"), new DateTime(2022, 3, 25, 12, 55, 6, 128, DateTimeKind.Local).AddTicks(6510), "7", false, "XPIOZHt", "ZUpjVUg", "7", "5", null, null, new Guid("7fc359a0-83d2-41e4-81b6-69a52ecc24b5") },
                    { new Guid("aeadeca8-666d-4b7c-8858-d08feb6838fb"), new DateTime(2022, 3, 25, 12, 55, 6, 128, DateTimeKind.Local).AddTicks(6526), "10", true, "JpWYhEByAc", "ULPdEVPxPm", "10", "10", null, null, new Guid("63d4de99-ae42-497e-abd8-8ff393392558") },
                    { new Guid("d70a0553-4c29-4f87-a43e-3951cc1daa38"), new DateTime(2022, 3, 25, 12, 55, 6, 128, DateTimeKind.Local).AddTicks(6379), "0", true, "", "", "0", "2", null, null, new Guid("6cec4e79-048d-4234-84bc-f6c6de502e0e") },
                    { new Guid("ee4d33f9-5a94-4461-9ea2-9e2295d684c4"), new DateTime(2022, 3, 25, 12, 55, 6, 128, DateTimeKind.Local).AddTicks(6460), "4", false, "UOCp", "icWJ", "4", "6", null, null, new Guid("b212ab07-dd9b-4778-9f68-ad8d7cadb203") }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Name" },
                values: new object[] { new Guid("0268c3ff-c937-4932-9d91-6cabdb65b3e0"), new DateTime(2022, 3, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7e352b0f-b369-4f51-b723-a7e4784188c8"), "Node" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Name" },
                values: new object[] { new Guid("85820674-82db-4b4b-a521-8578cea9849a"), new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7e352b0f-b369-4f51-b723-a7e4784188c8"), "Ruby" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Name" },
                values: new object[] { new Guid("dc743943-6c5c-4d4e-9c6c-fc45f531f98e"), new DateTime(2022, 3, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7e352b0f-b369-4f51-b723-a7e4784188c8"), ".Net" });
        }
    }
}
