using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Levi_Inventarization_Backend.Migrations
{
    public partial class testMock3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("79fa6059-18a4-4067-baa9-0a5b891a6292"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("02701b86-fefb-4d8c-9c82-a2f466678731"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c02dc2e-2ef4-4bcd-a633-1085fd165efe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("21fa6dde-3af2-4c4e-b3e4-1d709d96a47d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22c0915c-68b4-43e7-bed2-ad1ace423777"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2677da7d-3bf5-4395-b080-cf33022580f1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5861a1e7-a408-4c74-a84c-62dfc9e7b7e7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8c3c8bdb-1437-4605-8d46-fa5ef47f263f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b110161e-7fa4-48ea-b709-b3be228b714f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7724312-b91a-4cc2-a061-224c7bd46e03"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("def23a17-3e8d-4eb5-a1b2-70749c6a398d"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("79fa6059-18a4-4067-baa9-0a5b891a6292"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "Office Department", new Guid("22c0915c-68b4-43e7-bed2-ad1ace423777") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsAdmin", "LastName", "Name", "Password", "Phone", "SetupId", "SetupName", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("02701b86-fefb-4d8c-9c82-a2f466678731"), new DateTime(2022, 3, 25, 12, 54, 36, 534, DateTimeKind.Local).AddTicks(3071), "2", false, "Nd", "aD", "2", "0", null, null, new Guid("c72505fe-afb9-4281-a7be-690fb150e83b") },
                    { new Guid("0c02dc2e-2ef4-4bcd-a633-1085fd165efe"), new DateTime(2022, 3, 25, 12, 54, 36, 534, DateTimeKind.Local).AddTicks(3114), "8", false, "SZCAMytw", "NdeHHBsb", "8", "10", null, null, new Guid("b3805486-47a5-48bc-90ec-02c3d682d6c8") },
                    { new Guid("21fa6dde-3af2-4c4e-b3e4-1d709d96a47d"), new DateTime(2022, 3, 25, 12, 54, 36, 534, DateTimeKind.Local).AddTicks(3083), "4", false, "peSQ", "ksvF", "4", "6", null, null, new Guid("88e3fd9e-706b-4a54-8318-794786256609") },
                    { new Guid("22c0915c-68b4-43e7-bed2-ad1ace423777"), new DateTime(2022, 3, 25, 12, 54, 36, 534, DateTimeKind.Local).AddTicks(3124), "10", true, "yMYOnCnmWX", "CqzTcOWBUf", "10", "10", null, null, new Guid("3a5d4289-4d01-4012-9dc7-7687d9d27bf3") },
                    { new Guid("2677da7d-3bf5-4395-b080-cf33022580f1"), new DateTime(2022, 3, 25, 12, 54, 36, 534, DateTimeKind.Local).AddTicks(3004), "0", true, "", "", "0", "2", null, null, new Guid("d93b898e-dd1e-41c7-ac43-98fc91741b53") },
                    { new Guid("5861a1e7-a408-4c74-a84c-62dfc9e7b7e7"), new DateTime(2022, 3, 25, 12, 54, 36, 534, DateTimeKind.Local).AddTicks(3052), "1", false, "N", "a", "1", "3", null, null, new Guid("ded32b86-fd73-4ae9-bf55-9a7096a10dc9") },
                    { new Guid("8c3c8bdb-1437-4605-8d46-fa5ef47f263f"), new DateTime(2022, 3, 25, 12, 54, 36, 534, DateTimeKind.Local).AddTicks(3108), "7", false, "cVBiGLJ", "HMtXEWR", "7", "5", null, null, new Guid("8b28bcbd-e29a-4e6b-b316-d8c73f626c93") },
                    { new Guid("b110161e-7fa4-48ea-b709-b3be228b714f"), new DateTime(2022, 3, 25, 12, 54, 36, 534, DateTimeKind.Local).AddTicks(3094), "5", false, "ytBgy", "jrier", "5", "7", null, null, new Guid("d0dcef66-b5d0-4361-a1a8-4c56a0b5eb8b") },
                    { new Guid("b7724312-b91a-4cc2-a061-224c7bd46e03"), new DateTime(2022, 3, 25, 12, 54, 36, 534, DateTimeKind.Local).AddTicks(3101), "6", true, "ZwOIEm", "AfyomX", "6", "4", null, null, new Guid("6236e15e-09ed-407d-8eb6-b6fb69f8c54c") },
                    { new Guid("def23a17-3e8d-4eb5-a1b2-70749c6a398d"), new DateTime(2022, 3, 25, 12, 54, 36, 534, DateTimeKind.Local).AddTicks(3077), "3", true, "TVC", "EGX", "3", "1", null, null, new Guid("3a98bf30-5810-4110-88bc-06e30c5e0591") }
                });
        }
    }
}
