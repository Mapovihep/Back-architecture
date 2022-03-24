﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Levi_Inventarization_Backend.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220305085114_addedIdOfUserToInventory")]
    partial class addedIdOfUserToInventory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Defect", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("InventoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("InventoryId");

                    b.ToTable("Defects");

                    b.HasData(
                        new
                        {
                            Id = new Guid("11111111-9833-45ca-9017-1ded701ef149"),
                            CreatedAt = new DateTime(2022, 1, 24, 17, 54, 39, 230, DateTimeKind.Local),
                            Description = "description1",
                            Image = "image1",
                            Name = "name1",
                            UpdateBy = new Guid("11111111-9833-45ca-9017-1ded701ef149")
                        },
                        new
                        {
                            Id = new Guid("22222222-9833-45ca-9017-1ded701ef149"),
                            CreatedAt = new DateTime(2022, 1, 24, 17, 54, 39, 230, DateTimeKind.Local),
                            Description = "description2",
                            Image = "image2",
                            Name = "name2",
                            UpdateBy = new Guid("22222222-9833-45ca-9017-1ded701ef149")
                        });
                });

            modelBuilder.Entity("Entities.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5af1b4e9-ed7e-4e21-88c0-761583677ed8"),
                            CreatedAt = new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local),
                            Name = "DepName",
                            UpdateBy = new Guid("b1c06f08-f8c4-4085-81b4-e359e0f154f1")
                        });
                });

            modelBuilder.Entity("Entities.Inventory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("QRCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("RoomId");

                    b.HasIndex("UserId");

                    b.ToTable("Inventory");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f2416d06-395e-4e13-ab2b-c1d13d9ed4cb"),
                            Category = "Computers",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "199",
                            Price = 149250,
                            QRCode = "199",
                            Status = false,
                            UpdateBy = new Guid("cad226f9-b70c-4d02-ba7f-84b0e761584c"),
                            UserId = new Guid("68facc2b-2042-479b-bacb-189ae0f43586")
                        },
                        new
                        {
                            Id = new Guid("66bbfeda-45e8-4b95-b44a-44fcbd0606d8"),
                            Category = "Kitchen",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "24",
                            Price = 15600,
                            QRCode = "24",
                            Status = false,
                            UpdateBy = new Guid("d331da1a-e33e-4a2f-86f1-30ea47772844"),
                            UserId = new Guid("9650b96a-6d18-4837-b0f6-03315a4ca396")
                        },
                        new
                        {
                            Id = new Guid("f1b87c60-89fd-42f3-9a08-4aef2269914b"),
                            Category = "Kitchen",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "140",
                            Price = 91000,
                            QRCode = "140",
                            Status = false,
                            UpdateBy = new Guid("effe22e4-3620-40a8-87c2-9cfc9d6ec1b7"),
                            UserId = new Guid("825f32b6-28f1-4d5b-9cfa-0751e707ad64")
                        },
                        new
                        {
                            Id = new Guid("069c61e7-35ff-43d0-922a-efe1a1fd224c"),
                            Category = "Computers",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "169",
                            Price = 126750,
                            QRCode = "169",
                            Status = false,
                            UpdateBy = new Guid("edde72f4-0d9a-4eb1-9c81-7ab03f7d62a0"),
                            UserId = new Guid("39a75166-a187-47a8-836c-35a69cbb321f")
                        },
                        new
                        {
                            Id = new Guid("d58d05c9-0003-4783-a8b2-5ae47631e927"),
                            Category = "Kitchen",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "119",
                            Price = 30107,
                            QRCode = "119",
                            Status = false,
                            UpdateBy = new Guid("c99494e8-f557-4721-b379-439b6231446b"),
                            UserId = new Guid("18c69b49-a7f0-4f2d-9a0f-e4ec8fb7ebac")
                        },
                        new
                        {
                            Id = new Guid("05ba9bc8-dc6d-45b4-aab0-f47bfc72aaba"),
                            Category = "Furniture",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "111",
                            Price = 28083,
                            QRCode = "111",
                            Status = false,
                            UpdateBy = new Guid("e0a121f6-320a-44f0-aaaa-cb96788ac3d4"),
                            UserId = new Guid("7ea5adf8-7ce1-431e-b055-69b3fcd6e7e6")
                        },
                        new
                        {
                            Id = new Guid("9235e960-0430-4dbf-a73a-42858dc74183"),
                            Category = "Kitchen",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "113",
                            Price = 28589,
                            QRCode = "113",
                            Status = false,
                            UpdateBy = new Guid("1319c5cc-ebac-4e19-9fb6-09a8b4fe9952"),
                            UserId = new Guid("a3a1933f-7b1d-4221-8d0a-a633d88e8795")
                        },
                        new
                        {
                            Id = new Guid("b362f2d6-9c6c-466b-88a2-d60f93cee723"),
                            Category = "Furniture",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "61",
                            Price = 45750,
                            QRCode = "61",
                            Status = false,
                            UpdateBy = new Guid("1f59be36-4acd-4d6a-bedd-e83c814f69e5"),
                            UserId = new Guid("3b41845a-1331-4b4f-b3a4-c79bf5c8536f")
                        },
                        new
                        {
                            Id = new Guid("48caaee3-550e-4855-a658-33331df7ea7d"),
                            Category = "Kitchen",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "29",
                            Price = 7337,
                            QRCode = "29",
                            Status = false,
                            UpdateBy = new Guid("02a43dd1-8898-45f9-b7b3-f07b618b80bd"),
                            UserId = new Guid("c3810118-01ef-4aa3-aac3-ed8a5dfd0bf8")
                        },
                        new
                        {
                            Id = new Guid("b89532c7-a03a-4156-9478-19aaa459fcd9"),
                            Category = "Furniture",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "186",
                            Price = 47058,
                            QRCode = "186",
                            Status = false,
                            UpdateBy = new Guid("7525d094-c923-495d-83e7-c4b734908bb3"),
                            UserId = new Guid("aa6edc92-27e4-4973-a5c0-e38616727ca1")
                        },
                        new
                        {
                            Id = new Guid("c5e93e48-d424-4785-acad-ebe26e8cb029"),
                            Category = "Kitchen",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "92",
                            Price = 59800,
                            QRCode = "92",
                            Status = false,
                            UpdateBy = new Guid("efddc87a-8c39-45ad-a5db-2932a331b432"),
                            UserId = new Guid("8b7aebf2-70e9-4580-ba92-f788f01de4d6")
                        },
                        new
                        {
                            Id = new Guid("41a64704-4133-4f24-891b-c1a45e5c476a"),
                            Category = "Kitchen",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "144",
                            Price = 93600,
                            QRCode = "144",
                            Status = false,
                            UpdateBy = new Guid("4a38018e-589d-4dbd-8af4-f86dfc046559"),
                            UserId = new Guid("6d65cc91-9788-493e-a7a3-66c26aac19b6")
                        },
                        new
                        {
                            Id = new Guid("814642c7-fa18-4fcb-b049-0b6ad2ba6e3e"),
                            Category = "Kitchen",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "138",
                            Price = 34914,
                            QRCode = "138",
                            Status = false,
                            UpdateBy = new Guid("cab3a2cc-3be9-45d0-864e-a0e8b0583925"),
                            UserId = new Guid("0a9b865e-141c-4003-868e-c36b7169ff13")
                        },
                        new
                        {
                            Id = new Guid("0d0d1e39-99dc-4bc6-b189-165332f5e58d"),
                            Category = "Furniture",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "191",
                            Price = 48323,
                            QRCode = "191",
                            Status = false,
                            UpdateBy = new Guid("98adaa8e-dab1-4d71-8aa0-06c0ef721104"),
                            UserId = new Guid("58be0c84-7766-4caa-9015-5b5a2c4d8ef3")
                        },
                        new
                        {
                            Id = new Guid("38a35f3f-f163-4017-9fd9-977e7a798611"),
                            Category = "Furniture",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "151",
                            Price = 113250,
                            QRCode = "151",
                            Status = false,
                            UpdateBy = new Guid("41997b33-80e7-4ce8-856b-9a7e43a15067"),
                            UserId = new Guid("d0fa8711-413c-4bc5-8d40-7412cf33ad14")
                        },
                        new
                        {
                            Id = new Guid("bc638d8d-7886-46d9-81bd-2284943ebad0"),
                            Category = "Furniture",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "136",
                            Price = 88400,
                            QRCode = "136",
                            Status = false,
                            UpdateBy = new Guid("9a6a25b8-e0f2-4c46-9761-a92330bcf70f"),
                            UserId = new Guid("f5aaf162-1206-48df-9e06-f77cb9928c7e")
                        },
                        new
                        {
                            Id = new Guid("07356cbd-a83d-4a8e-812a-16fa1d0d129c"),
                            Category = "Computers",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "184",
                            Price = 119600,
                            QRCode = "184",
                            Status = false,
                            UpdateBy = new Guid("f8e6f9bf-9f67-42fe-ad5c-01d362862d4f"),
                            UserId = new Guid("4cc3a3ac-a089-4c87-9d55-796df6092c10")
                        },
                        new
                        {
                            Id = new Guid("2aacfdd4-b3d7-41c0-a5bd-56cb040110ff"),
                            Category = "Kitchen",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "47",
                            Price = 11891,
                            QRCode = "47",
                            Status = false,
                            UpdateBy = new Guid("b842caa4-4e14-4543-bddd-e07e43ed7a95"),
                            UserId = new Guid("11759b4f-1bac-4250-b0e4-671e86dadc59")
                        },
                        new
                        {
                            Id = new Guid("ae19dff7-7c78-42ba-a013-db72c39eaefa"),
                            Category = "Furniture",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "86",
                            Price = 21758,
                            QRCode = "86",
                            Status = false,
                            UpdateBy = new Guid("ba47db7e-fc02-4426-aa96-6ff70d7a4313"),
                            UserId = new Guid("8d99bb46-1d21-4354-9de4-385dff5efff9")
                        },
                        new
                        {
                            Id = new Guid("40112db8-e1c7-45f7-9f3c-dc05c73d3d76"),
                            Category = "Kitchen",
                            CreatedAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "63",
                            Price = 15939,
                            QRCode = "63",
                            Status = false,
                            UpdateBy = new Guid("c35f342b-3d73-4d45-b283-0b4cabdc46e1"),
                            UserId = new Guid("ba498452-9245-4c8b-92f4-94c2529eac09")
                        });
                });

            modelBuilder.Entity("Entities.InventorySetup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UpdatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.HasIndex("UserId");

                    b.ToTable("Setups");
                });

            modelBuilder.Entity("Entities.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6989209d-ac34-4257-be25-8d32ee9e002a"),
                            CreatedAt = new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local),
                            DepartmentId = new Guid("5af1b4e9-ed7e-4e21-88c0-761583677ed8"),
                            Name = "Name2"
                        });
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("68facc2b-2042-479b-bacb-189ae0f43586"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3410),
                            Email = "0",
                            IsAdmin = true,
                            LastName = "0",
                            Name = "0",
                            Password = "0",
                            Phone = "2",
                            UpdateBy = new Guid("5344b26f-6af0-4335-834b-22415fdb54d5")
                        },
                        new
                        {
                            Id = new Guid("9650b96a-6d18-4837-b0f6-03315a4ca396"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3420),
                            Email = "1",
                            IsAdmin = false,
                            LastName = "1",
                            Name = "1",
                            Password = "1",
                            Phone = "3",
                            UpdateBy = new Guid("d4b306ed-77e4-4fff-b140-71d8cc8ea3de")
                        },
                        new
                        {
                            Id = new Guid("825f32b6-28f1-4d5b-9cfa-0751e707ad64"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3423),
                            Email = "2",
                            IsAdmin = true,
                            LastName = "2",
                            Name = "2",
                            Password = "2",
                            Phone = "0",
                            UpdateBy = new Guid("4a500193-55e5-47df-86c3-7dea13a1e7d2")
                        },
                        new
                        {
                            Id = new Guid("39a75166-a187-47a8-836c-35a69cbb321f"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3428),
                            Email = "3",
                            IsAdmin = false,
                            LastName = "3",
                            Name = "3",
                            Password = "3",
                            Phone = "1",
                            UpdateBy = new Guid("0558795d-0505-4879-8a3a-4c30e6b275b1")
                        },
                        new
                        {
                            Id = new Guid("18c69b49-a7f0-4f2d-9a0f-e4ec8fb7ebac"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3430),
                            Email = "4",
                            IsAdmin = true,
                            LastName = "4",
                            Name = "4",
                            Password = "4",
                            Phone = "6",
                            UpdateBy = new Guid("39753bfd-4075-448f-a9a6-652e39ab2ab2")
                        },
                        new
                        {
                            Id = new Guid("7ea5adf8-7ce1-431e-b055-69b3fcd6e7e6"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3434),
                            Email = "5",
                            IsAdmin = false,
                            LastName = "5",
                            Name = "5",
                            Password = "5",
                            Phone = "7",
                            UpdateBy = new Guid("a514d7d0-ab45-485f-b959-0dc1f62316d1")
                        },
                        new
                        {
                            Id = new Guid("a3a1933f-7b1d-4221-8d0a-a633d88e8795"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3437),
                            Email = "6",
                            IsAdmin = true,
                            LastName = "6",
                            Name = "6",
                            Password = "6",
                            Phone = "4",
                            UpdateBy = new Guid("5657255f-18cb-4c41-86e9-8cfcac453015")
                        },
                        new
                        {
                            Id = new Guid("3b41845a-1331-4b4f-b3a4-c79bf5c8536f"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3441),
                            Email = "7",
                            IsAdmin = false,
                            LastName = "7",
                            Name = "7",
                            Password = "7",
                            Phone = "5",
                            UpdateBy = new Guid("eb4a5ecb-b7c6-470b-9a8b-786d11941a53")
                        },
                        new
                        {
                            Id = new Guid("c3810118-01ef-4aa3-aac3-ed8a5dfd0bf8"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3443),
                            Email = "8",
                            IsAdmin = true,
                            LastName = "8",
                            Name = "8",
                            Password = "8",
                            Phone = "10",
                            UpdateBy = new Guid("a7c4961c-ecca-47e2-82d5-58deb020cfce")
                        },
                        new
                        {
                            Id = new Guid("aa6edc92-27e4-4973-a5c0-e38616727ca1"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3447),
                            Email = "9",
                            IsAdmin = false,
                            LastName = "9",
                            Name = "9",
                            Password = "9",
                            Phone = "11",
                            UpdateBy = new Guid("86f8c942-3260-4c1d-a01e-8a9b140b56ab")
                        },
                        new
                        {
                            Id = new Guid("8b7aebf2-70e9-4580-ba92-f788f01de4d6"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3449),
                            Email = "10",
                            IsAdmin = true,
                            LastName = "10",
                            Name = "10",
                            Password = "10",
                            Phone = "8",
                            UpdateBy = new Guid("8b006002-5ba7-4482-970a-d9da7bf99831")
                        },
                        new
                        {
                            Id = new Guid("6d65cc91-9788-493e-a7a3-66c26aac19b6"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3453),
                            Email = "11",
                            IsAdmin = false,
                            LastName = "11",
                            Name = "11",
                            Password = "11",
                            Phone = "9",
                            UpdateBy = new Guid("8e3851e0-0795-4b16-b6c1-7b8f372ea65b")
                        },
                        new
                        {
                            Id = new Guid("0a9b865e-141c-4003-868e-c36b7169ff13"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3493),
                            Email = "12",
                            IsAdmin = true,
                            LastName = "12",
                            Name = "12",
                            Password = "12",
                            Phone = "14",
                            UpdateBy = new Guid("6ae25300-2adc-4bb5-8d2e-a1436d785f73")
                        },
                        new
                        {
                            Id = new Guid("58be0c84-7766-4caa-9015-5b5a2c4d8ef3"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3496),
                            Email = "13",
                            IsAdmin = false,
                            LastName = "13",
                            Name = "13",
                            Password = "13",
                            Phone = "15",
                            UpdateBy = new Guid("0a9efeed-3495-4533-bfa4-91e693058609")
                        },
                        new
                        {
                            Id = new Guid("d0fa8711-413c-4bc5-8d40-7412cf33ad14"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3499),
                            Email = "14",
                            IsAdmin = true,
                            LastName = "14",
                            Name = "14",
                            Password = "14",
                            Phone = "12",
                            UpdateBy = new Guid("cfe02064-d227-4b4e-89ce-79dec7291201")
                        },
                        new
                        {
                            Id = new Guid("f5aaf162-1206-48df-9e06-f77cb9928c7e"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3503),
                            Email = "15",
                            IsAdmin = false,
                            LastName = "15",
                            Name = "15",
                            Password = "15",
                            Phone = "13",
                            UpdateBy = new Guid("cb4af5c8-f857-4b70-a716-5decfdabc5a5")
                        },
                        new
                        {
                            Id = new Guid("4cc3a3ac-a089-4c87-9d55-796df6092c10"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3505),
                            Email = "16",
                            IsAdmin = true,
                            LastName = "16",
                            Name = "16",
                            Password = "16",
                            Phone = "18",
                            UpdateBy = new Guid("7e804622-2b85-40aa-a4df-261354f8f233")
                        },
                        new
                        {
                            Id = new Guid("11759b4f-1bac-4250-b0e4-671e86dadc59"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3509),
                            Email = "17",
                            IsAdmin = false,
                            LastName = "17",
                            Name = "17",
                            Password = "17",
                            Phone = "19",
                            UpdateBy = new Guid("ab0983d4-5bbe-48f2-9829-95460b25eba6")
                        },
                        new
                        {
                            Id = new Guid("8d99bb46-1d21-4354-9de4-385dff5efff9"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3512),
                            Email = "18",
                            IsAdmin = true,
                            LastName = "18",
                            Name = "18",
                            Password = "18",
                            Phone = "16",
                            UpdateBy = new Guid("a243c5f4-ef85-4c2b-918d-803e9efa9852")
                        },
                        new
                        {
                            Id = new Guid("ba498452-9245-4c8b-92f4-94c2529eac09"),
                            CreatedAt = new DateTime(2022, 3, 5, 11, 51, 14, 46, DateTimeKind.Local).AddTicks(3516),
                            Email = "19",
                            IsAdmin = false,
                            LastName = "19",
                            Name = "19",
                            Password = "19",
                            Phone = "17",
                            UpdateBy = new Guid("30315f8d-42b1-4798-b004-c09ef6fc4f95")
                        });
                });

            modelBuilder.Entity("Entities.Defect", b =>
                {
                    b.HasOne("Entities.Inventory", "Inventory")
                        .WithMany("DefectsList")
                        .HasForeignKey("InventoryId");

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("Entities.Inventory", b =>
                {
                    b.HasOne("Entities.Department", null)
                        .WithMany("InventoryList")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("Entities.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");

                    b.HasOne("Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Room");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.InventorySetup", b =>
                {
                    b.HasOne("Entities.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");

                    b.HasOne("Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Room");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Room", b =>
                {
                    b.HasOne("Entities.Department", null)
                        .WithMany("RoomsList")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("Entities.Department", b =>
                {
                    b.Navigation("InventoryList");

                    b.Navigation("RoomsList");
                });

            modelBuilder.Entity("Entities.Inventory", b =>
                {
                    b.Navigation("DefectsList");
                });
#pragma warning restore 612, 618
        }
    }
}