// <auto-generated />
using System;
using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220203034712_InitDb")]
    partial class InitDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("Models.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("Models.Entities.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Temperature")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Device 1",
                            Status = "Available",
                            Temperature = 10m,
                            Type = 0,
                            TypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Device 2",
                            Status = "Offline",
                            Temperature = 15m,
                            Type = 0,
                            TypeId = 3
                        },
                        new
                        {
                            Id = 3,
                            Name = "Device 3",
                            Status = "Available",
                            Temperature = 7m,
                            Type = 0,
                            TypeId = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Device 4",
                            Status = "Offline",
                            Temperature = 4m,
                            Type = 0,
                            TypeId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Device 5",
                            Status = "Offline",
                            Temperature = 20m,
                            Type = 0,
                            TypeId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Device 6",
                            Status = "Available",
                            Temperature = 12m,
                            Type = 0,
                            TypeId = 3
                        },
                        new
                        {
                            Id = 7,
                            Name = "Device 7",
                            Status = "Available",
                            Temperature = 21m,
                            Type = 0,
                            TypeId = 3
                        },
                        new
                        {
                            Id = 8,
                            Name = "Device 8",
                            Status = "Offline",
                            Temperature = 19m,
                            Type = 0,
                            TypeId = 2
                        },
                        new
                        {
                            Id = 9,
                            Name = "Device 9",
                            Status = "Offline",
                            Temperature = 22m,
                            Type = 0,
                            TypeId = 1
                        },
                        new
                        {
                            Id = 10,
                            Name = "Device 10",
                            Status = "Available",
                            Temperature = 40m,
                            Type = 0,
                            TypeId = 2
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
