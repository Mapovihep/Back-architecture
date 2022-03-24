using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Levi_Inventarization_Backend.Migrations
{
    public partial class addedIdOfUserToInventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("051b9d7b-a622-4d5d-bb0d-468317e16743"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("0bd17248-41e1-4991-be41-ae060bfd2f34"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("224cf715-93e8-4fd8-9298-764d9827bad8"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("22a4e63d-bd34-4277-8de5-d7b703485ff4"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("3c8f2d60-fb38-48b6-910f-1e920e679fbb"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("3d41ef90-be84-492d-b58f-99c097a74ded"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("47f147e3-3da9-49a0-897a-6c772b985d84"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("55fce935-f9df-4657-a8fc-725488b31457"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("5d5e2288-a094-47d1-aaaf-aed90a6c0d9c"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("6e669e7e-3775-4dbb-9158-b69adff930c2"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("72d4e4b5-59b3-4f80-831e-709340cfdaa8"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("7e3d87e3-efa6-451b-8c2a-13230e8c2807"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("7f6231da-8802-4977-842b-90e69394cb3f"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("94039a14-6141-47ba-b64e-646891089dd8"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("995b6d32-b0ef-4c35-bce0-db1109552b37"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("c6cfca97-797f-48e2-b0ce-f735e61f5ab3"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("c8da1328-8403-439e-9d46-5dcc13b521f0"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("d829adec-c005-4d29-bd6a-168f249b013e"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("f2db931f-7918-48b0-a491-0dc1e26a09bc"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("ffed5add-2e43-49ed-9171-138d100e036c"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ec13f037-ec1a-4507-8db5-88c30c23b52e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("05510482-0605-443e-8271-806902ec15c0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22ae9b75-717b-4d99-985f-564c6e0078f5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("256aed38-39b1-4901-8a2a-4aa996257b4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("48a01d0d-9966-47b6-adee-3c134fe502fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("52721195-193a-47e1-8e4e-8a7e87cb8d8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5fb77a76-5eb0-4748-a48b-077a22e9b0da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("60ac99ab-4e78-4402-8d33-ccbb5502e071"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67e778fe-9fa2-4d2b-91f7-98b1ca0c4367"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69ee4e5f-a0ad-429b-a34d-dfb6ce9c8d8b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("750b8b30-f473-4afc-ac0e-68257e446898"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("77273e46-7390-4bd5-8b47-c7d8df14ab7b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7fa216b4-9ff3-4433-8877-ecf03807eeab"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aaab4f97-a60b-4572-b2cb-5b80ddea7da7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b6da3c1a-9cb3-42cc-a91f-6b3c47203c68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bd5c95d2-85d1-438a-ac39-d9ce8c8b96aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c1901d6a-be0e-43d4-827d-2369c0bc7e81"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5fdf333-9ecb-467f-8647-d24aea2d5c34"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dc086561-55f1-4be9-a075-4c67259a3821"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("decffedc-8213-439f-975b-4eea7f5d487b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fc2c4214-8696-4e28-a6d7-c83843e9d25c"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("4079c2e4-8579-4476-9a45-8dd424a23968"));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdateBy" },
                values: new object[] { new Guid("5af1b4e9-ed7e-4e21-88c0-761583677ed8"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), "DepName", new Guid("b1c06f08-f8c4-4085-81b4-e359e0f154f1") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "IsAdmin", "LastName", "Name", "Password", "Phone", "UpdateBy" },
                values: new object[,]
                {
                    { new Guid("0a9b865e-141c-4003-868e-c36b7169ff13"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3493), "12", true, "12", "12", "12", "14", new Guid("6ae25300-2adc-4bb5-8d2e-a1436d785f73") },
                    { new Guid("11759b4f-1bac-4250-b0e4-671e86dadc59"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3509), "17", false, "17", "17", "17", "19", new Guid("ab0983d4-5bbe-48f2-9829-95460b25eba6") },
                    { new Guid("18c69b49-a7f0-4f2d-9a0f-e4ec8fb7ebac"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3430), "4", true, "4", "4", "4", "6", new Guid("39753bfd-4075-448f-a9a6-652e39ab2ab2") },
                    { new Guid("39a75166-a187-47a8-836c-35a69cbb321f"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3428), "3", false, "3", "3", "3", "1", new Guid("0558795d-0505-4879-8a3a-4c30e6b275b1") },
                    { new Guid("3b41845a-1331-4b4f-b3a4-c79bf5c8536f"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3441), "7", false, "7", "7", "7", "5", new Guid("eb4a5ecb-b7c6-470b-9a8b-786d11941a53") },
                    { new Guid("4cc3a3ac-a089-4c87-9d55-796df6092c10"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3505), "16", true, "16", "16", "16", "18", new Guid("7e804622-2b85-40aa-a4df-261354f8f233") },
                    { new Guid("58be0c84-7766-4caa-9015-5b5a2c4d8ef3"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3496), "13", false, "13", "13", "13", "15", new Guid("0a9efeed-3495-4533-bfa4-91e693058609") },
                    { new Guid("68facc2b-2042-479b-bacb-189ae0f43586"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3410), "0", true, "0", "0", "0", "2", new Guid("5344b26f-6af0-4335-834b-22415fdb54d5") },
                    { new Guid("6d65cc91-9788-493e-a7a3-66c26aac19b6"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3453), "11", false, "11", "11", "11", "9", new Guid("8e3851e0-0795-4b16-b6c1-7b8f372ea65b") },
                    { new Guid("7ea5adf8-7ce1-431e-b055-69b3fcd6e7e6"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3434), "5", false, "5", "5", "5", "7", new Guid("a514d7d0-ab45-485f-b959-0dc1f62316d1") },
                    { new Guid("825f32b6-28f1-4d5b-9cfa-0751e707ad64"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3423), "2", true, "2", "2", "2", "0", new Guid("4a500193-55e5-47df-86c3-7dea13a1e7d2") },
                    { new Guid("8b7aebf2-70e9-4580-ba92-f788f01de4d6"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3449), "10", true, "10", "10", "10", "8", new Guid("8b006002-5ba7-4482-970a-d9da7bf99831") },
                    { new Guid("8d99bb46-1d21-4354-9de4-385dff5efff9"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3512), "18", true, "18", "18", "18", "16", new Guid("a243c5f4-ef85-4c2b-918d-803e9efa9852") },
                    { new Guid("9650b96a-6d18-4837-b0f6-03315a4ca396"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3420), "1", false, "1", "1", "1", "3", new Guid("d4b306ed-77e4-4fff-b140-71d8cc8ea3de") },
                    { new Guid("a3a1933f-7b1d-4221-8d0a-a633d88e8795"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3437), "6", true, "6", "6", "6", "4", new Guid("5657255f-18cb-4c41-86e9-8cfcac453015") },
                    { new Guid("aa6edc92-27e4-4973-a5c0-e38616727ca1"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3447), "9", false, "9", "9", "9", "11", new Guid("86f8c942-3260-4c1d-a01e-8a9b140b56ab") },
                    { new Guid("ba498452-9245-4c8b-92f4-94c2529eac09"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3516), "19", false, "19", "19", "19", "17", new Guid("30315f8d-42b1-4798-b004-c09ef6fc4f95") },
                    { new Guid("c3810118-01ef-4aa3-aac3-ed8a5dfd0bf8"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3443), "8", true, "8", "8", "8", "10", new Guid("a7c4961c-ecca-47e2-82d5-58deb020cfce") },
                    { new Guid("d0fa8711-413c-4bc5-8d40-7412cf33ad14"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3499), "14", true, "14", "14", "14", "12", new Guid("cfe02064-d227-4b4e-89ce-79dec7291201") },
                    { new Guid("f5aaf162-1206-48df-9e06-f77cb9928c7e"), new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3503), "15", false, "15", "15", "15", "13", new Guid("cb4af5c8-f857-4b70-a716-5decfdabc5a5") }
                });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "Id", "Category", "CreatedAt", "DepartmentId", "Name", "Price", "QRCode", "RoomId", "Status", "UpdateBy", "UserId" },
                values: new object[,]
                {
                    { new Guid("05ba9bc8-dc6d-45b4-aab0-f47bfc72aaba"), "Furniture", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "111", 28083, "111", null, false, new Guid("e0a121f6-320a-44f0-aaaa-cb96788ac3d4"), new Guid("7ea5adf8-7ce1-431e-b055-69b3fcd6e7e6") },
                    { new Guid("069c61e7-35ff-43d0-922a-efe1a1fd224c"), "Computers", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "169", 126750, "169", null, false, new Guid("edde72f4-0d9a-4eb1-9c81-7ab03f7d62a0"), new Guid("39a75166-a187-47a8-836c-35a69cbb321f") },
                    { new Guid("07356cbd-a83d-4a8e-812a-16fa1d0d129c"), "Computers", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "184", 119600, "184", null, false, new Guid("f8e6f9bf-9f67-42fe-ad5c-01d362862d4f"), new Guid("4cc3a3ac-a089-4c87-9d55-796df6092c10") },
                    { new Guid("0d0d1e39-99dc-4bc6-b189-165332f5e58d"), "Furniture", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "191", 48323, "191", null, false, new Guid("98adaa8e-dab1-4d71-8aa0-06c0ef721104"), new Guid("58be0c84-7766-4caa-9015-5b5a2c4d8ef3") },
                    { new Guid("2aacfdd4-b3d7-41c0-a5bd-56cb040110ff"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "47", 11891, "47", null, false, new Guid("b842caa4-4e14-4543-bddd-e07e43ed7a95"), new Guid("11759b4f-1bac-4250-b0e4-671e86dadc59") },
                    { new Guid("38a35f3f-f163-4017-9fd9-977e7a798611"), "Furniture", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "151", 113250, "151", null, false, new Guid("41997b33-80e7-4ce8-856b-9a7e43a15067"), new Guid("d0fa8711-413c-4bc5-8d40-7412cf33ad14") },
                    { new Guid("40112db8-e1c7-45f7-9f3c-dc05c73d3d76"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "63", 15939, "63", null, false, new Guid("c35f342b-3d73-4d45-b283-0b4cabdc46e1"), new Guid("ba498452-9245-4c8b-92f4-94c2529eac09") },
                    { new Guid("41a64704-4133-4f24-891b-c1a45e5c476a"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "144", 93600, "144", null, false, new Guid("4a38018e-589d-4dbd-8af4-f86dfc046559"), new Guid("6d65cc91-9788-493e-a7a3-66c26aac19b6") },
                    { new Guid("48caaee3-550e-4855-a658-33331df7ea7d"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "29", 7337, "29", null, false, new Guid("02a43dd1-8898-45f9-b7b3-f07b618b80bd"), new Guid("c3810118-01ef-4aa3-aac3-ed8a5dfd0bf8") },
                    { new Guid("66bbfeda-45e8-4b95-b44a-44fcbd0606d8"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "24", 15600, "24", null, false, new Guid("d331da1a-e33e-4a2f-86f1-30ea47772844"), new Guid("9650b96a-6d18-4837-b0f6-03315a4ca396") },
                    { new Guid("814642c7-fa18-4fcb-b049-0b6ad2ba6e3e"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "138", 34914, "138", null, false, new Guid("cab3a2cc-3be9-45d0-864e-a0e8b0583925"), new Guid("0a9b865e-141c-4003-868e-c36b7169ff13") },
                    { new Guid("9235e960-0430-4dbf-a73a-42858dc74183"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "113", 28589, "113", null, false, new Guid("1319c5cc-ebac-4e19-9fb6-09a8b4fe9952"), new Guid("a3a1933f-7b1d-4221-8d0a-a633d88e8795") },
                    { new Guid("ae19dff7-7c78-42ba-a013-db72c39eaefa"), "Furniture", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "86", 21758, "86", null, false, new Guid("ba47db7e-fc02-4426-aa96-6ff70d7a4313"), new Guid("8d99bb46-1d21-4354-9de4-385dff5efff9") },
                    { new Guid("b362f2d6-9c6c-466b-88a2-d60f93cee723"), "Furniture", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "61", 45750, "61", null, false, new Guid("1f59be36-4acd-4d6a-bedd-e83c814f69e5"), new Guid("3b41845a-1331-4b4f-b3a4-c79bf5c8536f") },
                    { new Guid("b89532c7-a03a-4156-9478-19aaa459fcd9"), "Furniture", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "186", 47058, "186", null, false, new Guid("7525d094-c923-495d-83e7-c4b734908bb3"), new Guid("aa6edc92-27e4-4973-a5c0-e38616727ca1") },
                    { new Guid("bc638d8d-7886-46d9-81bd-2284943ebad0"), "Furniture", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "136", 88400, "136", null, false, new Guid("9a6a25b8-e0f2-4c46-9761-a92330bcf70f"), new Guid("f5aaf162-1206-48df-9e06-f77cb9928c7e") },
                    { new Guid("c5e93e48-d424-4785-acad-ebe26e8cb029"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "92", 59800, "92", null, false, new Guid("efddc87a-8c39-45ad-a5db-2932a331b432"), new Guid("8b7aebf2-70e9-4580-ba92-f788f01de4d6") },
                    { new Guid("d58d05c9-0003-4783-a8b2-5ae47631e927"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "119", 30107, "119", null, false, new Guid("c99494e8-f557-4721-b379-439b6231446b"), new Guid("18c69b49-a7f0-4f2d-9a0f-e4ec8fb7ebac") },
                    { new Guid("f1b87c60-89fd-42f3-9a08-4aef2269914b"), "Kitchen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "140", 91000, "140", null, false, new Guid("effe22e4-3620-40a8-87c2-9cfc9d6ec1b7"), new Guid("825f32b6-28f1-4d5b-9cfa-0751e707ad64") },
                    { new Guid("f2416d06-395e-4e13-ab2b-c1d13d9ed4cb"), "Computers", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "199", 149250, "199", null, false, new Guid("cad226f9-b70c-4d02-ba7f-84b0e761584c"), new Guid("68facc2b-2042-479b-bacb-189ae0f43586") }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Name" },
                values: new object[] { new Guid("6989209d-ac34-4257-be25-8d32ee9e002a"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), new Guid("5af1b4e9-ed7e-4e21-88c0-761583677ed8"), "Name2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("05ba9bc8-dc6d-45b4-aab0-f47bfc72aaba"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("069c61e7-35ff-43d0-922a-efe1a1fd224c"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("07356cbd-a83d-4a8e-812a-16fa1d0d129c"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("0d0d1e39-99dc-4bc6-b189-165332f5e58d"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("2aacfdd4-b3d7-41c0-a5bd-56cb040110ff"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("38a35f3f-f163-4017-9fd9-977e7a798611"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("40112db8-e1c7-45f7-9f3c-dc05c73d3d76"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("41a64704-4133-4f24-891b-c1a45e5c476a"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("48caaee3-550e-4855-a658-33331df7ea7d"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("66bbfeda-45e8-4b95-b44a-44fcbd0606d8"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("814642c7-fa18-4fcb-b049-0b6ad2ba6e3e"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("9235e960-0430-4dbf-a73a-42858dc74183"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("ae19dff7-7c78-42ba-a013-db72c39eaefa"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("b362f2d6-9c6c-466b-88a2-d60f93cee723"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("b89532c7-a03a-4156-9478-19aaa459fcd9"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("bc638d8d-7886-46d9-81bd-2284943ebad0"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("c5e93e48-d424-4785-acad-ebe26e8cb029"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("d58d05c9-0003-4783-a8b2-5ae47631e927"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("f1b87c60-89fd-42f3-9a08-4aef2269914b"));

            migrationBuilder.DeleteData(
                table: "Inventory",
                keyColumn: "Id",
                keyValue: new Guid("f2416d06-395e-4e13-ab2b-c1d13d9ed4cb"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6989209d-ac34-4257-be25-8d32ee9e002a"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5af1b4e9-ed7e-4e21-88c0-761583677ed8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0a9b865e-141c-4003-868e-c36b7169ff13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11759b4f-1bac-4250-b0e4-671e86dadc59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("18c69b49-a7f0-4f2d-9a0f-e4ec8fb7ebac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("39a75166-a187-47a8-836c-35a69cbb321f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b41845a-1331-4b4f-b3a4-c79bf5c8536f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4cc3a3ac-a089-4c87-9d55-796df6092c10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58be0c84-7766-4caa-9015-5b5a2c4d8ef3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("68facc2b-2042-479b-bacb-189ae0f43586"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6d65cc91-9788-493e-a7a3-66c26aac19b6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7ea5adf8-7ce1-431e-b055-69b3fcd6e7e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("825f32b6-28f1-4d5b-9cfa-0751e707ad64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8b7aebf2-70e9-4580-ba92-f788f01de4d6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8d99bb46-1d21-4354-9de4-385dff5efff9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9650b96a-6d18-4837-b0f6-03315a4ca396"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a3a1933f-7b1d-4221-8d0a-a633d88e8795"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aa6edc92-27e4-4973-a5c0-e38616727ca1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ba498452-9245-4c8b-92f4-94c2529eac09"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c3810118-01ef-4aa3-aac3-ed8a5dfd0bf8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d0fa8711-413c-4bc5-8d40-7412cf33ad14"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5aaf162-1206-48df-9e06-f77cb9928c7e"));

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
                    { new Guid("decffedc-8213-439f-975b-4eea7f5d487b"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4470), "15", false, "15", "15", "15", "13", new Guid("c582797d-a8e9-478a-bbcb-92130c18c82c") },
                    { new Guid("fc2c4214-8696-4e28-a6d7-c83843e9d25c"), new DateTime(2022, 3, 5, 11, 22, 48, 879, DateTimeKind.Local).AddTicks(4442), "5", false, "5", "5", "5", "7", new Guid("5e19e15f-7fc4-4a2d-ba6e-67fc06c42212") }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "CreatedAt", "DepartmentId", "Name" },
                values: new object[] { new Guid("ec13f037-ec1a-4507-8db5-88c30c23b52e"), new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local), new Guid("4079c2e4-8579-4476-9a45-8dd424a23968"), "Name2" });
        }
    }
}
