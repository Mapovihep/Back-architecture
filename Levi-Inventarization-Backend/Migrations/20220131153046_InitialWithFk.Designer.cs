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
    [Migration("20220131153046_InitialWithFk")]
    partial class InitialWithFk
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

                    b.Property<Guid>("InventoryEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UpdateBy")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("InventoryEntityId");

                    b.ToTable("Defects");
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

                    b.Property<Guid>("SetupEntityId")
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

                    b.HasIndex("SetupEntityId");

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
                        .WithMany("DefectsListEntity")
                        .HasForeignKey("InventoryEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InventoryEntity");
                });

            modelBuilder.Entity("Entities.InventoryEntity", b =>
                {
                    b.HasOne("Entities.DepartmentEntity", null)
                        .WithMany("InventoriesEntity")
                        .HasForeignKey("DepartmentEntityId");

                    b.HasOne("Entities.RoomEntity", "RoomEntity")
                        .WithMany()
                        .HasForeignKey("RoomEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.InventorySetupEntity", "SetupEntity")
                        .WithMany()
                        .HasForeignKey("SetupEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.UserEntity", "UserEntity")
                        .WithMany()
                        .HasForeignKey("UserEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomEntity");

                    b.Navigation("SetupEntity");

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
                        .WithMany("RoomsEntity")
                        .HasForeignKey("DepartmentEntityId");
                });

            modelBuilder.Entity("Entities.DepartmentEntity", b =>
                {
                    b.Navigation("InventoriesEntity");

                    b.Navigation("RoomsEntity");
                });

            modelBuilder.Entity("Entities.InventoryEntity", b =>
                {
                    b.Navigation("DefectsListEntity");
                });
#pragma warning restore 612, 618
        }
    }
}
