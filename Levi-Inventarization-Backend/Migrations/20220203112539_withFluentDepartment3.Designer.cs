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
    [Migration("20220203112539_withFluentDepartment3")]
    partial class withFluentDepartment3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.DefectEntity", b =>
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

                    b.Property<Guid?>("InventoryEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("InventoryEntityId");

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

            modelBuilder.Entity("Entities.DepartmentEntity", b =>
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
                            Id = new Guid("0d87a78f-e562-438e-8eac-f8cc7de72ef2"),
                            CreatedAt = new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local),
                            Name = "DepName",
                            UpdateBy = new Guid("6eafd64c-b672-4aef-81d7-2950f446db14")
                        });
                });

            modelBuilder.Entity("Entities.InventoryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DepartmentEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoomEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentEntityId");

                    b.HasIndex("RoomEntityId");

                    b.HasIndex("UserEntityId");

                    b.ToTable("InventoryLots");
                });

            modelBuilder.Entity("Entities.InventorySetupEntity", b =>
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

                    b.Property<Guid>("RoomEntityId")
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

                    b.Property<Guid>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoomEntityId");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Setups");
                });

            modelBuilder.Entity("Entities.RoomEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DepartmentEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentEntityId");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fac34a7f-ebba-43eb-8153-333288b9375b"),
                            CreatedAt = new DateTime(2021, 1, 24, 17, 54, 39, 230, DateTimeKind.Local),
                            Name = "Name2"
                        });
                });

            modelBuilder.Entity("Entities.UserEntity", b =>
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
                });

            modelBuilder.Entity("Entities.DefectEntity", b =>
                {
                    b.HasOne("Entities.InventoryEntity", "InventoryEntity")
                        .WithMany("DefectsEntity")
                        .HasForeignKey("InventoryEntityId");

                    b.Navigation("InventoryEntity");
                });

            modelBuilder.Entity("Entities.InventoryEntity", b =>
                {
                    b.HasOne("Entities.DepartmentEntity", null)
                        .WithMany("InventoryEntityList")
                        .HasForeignKey("DepartmentEntityId");

                    b.HasOne("Entities.RoomEntity", "RoomEntity")
                        .WithMany()
                        .HasForeignKey("RoomEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.UserEntity", "UserEntity")
                        .WithMany()
                        .HasForeignKey("UserEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomEntity");

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("Entities.InventorySetupEntity", b =>
                {
                    b.HasOne("Entities.RoomEntity", "RoomEntity")
                        .WithMany()
                        .HasForeignKey("RoomEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.UserEntity", "UserEntity")
                        .WithMany()
                        .HasForeignKey("UserEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomEntity");

                    b.Navigation("UserEntity");
                });

            modelBuilder.Entity("Entities.RoomEntity", b =>
                {
                    b.HasOne("Entities.DepartmentEntity", null)
                        .WithMany("RoomsEntityList")
                        .HasForeignKey("DepartmentEntityId");
                });

            modelBuilder.Entity("Entities.DepartmentEntity", b =>
                {
                    b.Navigation("InventoryEntityList");

                    b.Navigation("RoomsEntityList");
                });

            modelBuilder.Entity("Entities.InventoryEntity", b =>
                {
                    b.Navigation("DefectsEntity");
                });
#pragma warning restore 612, 618
        }
    }
}