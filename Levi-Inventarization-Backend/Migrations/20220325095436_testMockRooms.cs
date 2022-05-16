using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Levi_Inventarization_Backend.Migrations
{
    public partial class testMockRooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
