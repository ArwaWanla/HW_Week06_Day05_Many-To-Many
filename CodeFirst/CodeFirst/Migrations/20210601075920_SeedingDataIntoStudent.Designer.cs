﻿// <auto-generated />
using CodeFirst.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeFirst.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210601075920_SeedingDataIntoStudent")]
    partial class SeedingDataIntoStudent
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CodeFirst.Models.RoomModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Empty")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("CodeFirst.Models.StudentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Eamil")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Eamil = "arwa@gmail.com",
                            FirstName = "Arwa",
                            LastName = "Wan La"
                        },
                        new
                        {
                            Id = 2,
                            Eamil = "reham@gmail.com",
                            FirstName = "Reham",
                            LastName = "Alonaizy"
                        },
                        new
                        {
                            Id = 3,
                            Eamil = "amal@gmail.com",
                            FirstName = "Amal",
                            LastName = "Almutairy"
                        },
                        new
                        {
                            Id = 4,
                            Eamil = "abulaziz@gmail.com",
                            FirstName = "Abdulaziz",
                            LastName = "almohammady"
                        });
                });

            modelBuilder.Entity("CodeFirst.Models.TeacherModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Eamil")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
