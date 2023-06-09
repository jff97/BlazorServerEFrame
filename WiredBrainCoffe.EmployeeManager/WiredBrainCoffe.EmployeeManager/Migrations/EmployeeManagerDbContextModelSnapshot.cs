﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WiredBrainCoffe.EmployeeManager.Data;

#nullable disable

namespace WiredBrainCoffe.EmployeeManager.Migrations
{
    [DbContext(typeof(EmployeeManagerDbContext))]
    partial class EmployeeManagerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WiredBrainCoffe.EmployeeManager.Data.models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Finance"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sales"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Human Resources"
                        },
                        new
                        {
                            Id = 5,
                            Name = "IT"
                        });
                });

            modelBuilder.Entity("WiredBrainCoffe.EmployeeManager.Data.models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeveloper")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Timestamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 2,
                            FirstName = "Anna",
                            IsDeveloper = false,
                            LastName = "Rockstar"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 5,
                            FirstName = "Julia",
                            IsDeveloper = true,
                            LastName = "Developer"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 5,
                            FirstName = "Thomas",
                            IsDeveloper = true,
                            LastName = "Huber"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 1,
                            FirstName = "Sara",
                            IsDeveloper = false,
                            LastName = "Metroid"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 4,
                            FirstName = "Ben",
                            IsDeveloper = false,
                            LastName = "Rockstar"
                        },
                        new
                        {
                            Id = 6,
                            DepartmentId = 3,
                            FirstName = "Alex",
                            IsDeveloper = true,
                            LastName = "Rider"
                        },
                        new
                        {
                            Id = 7,
                            DepartmentId = 5,
                            FirstName = "Sophie",
                            IsDeveloper = false,
                            LastName = "Ramos"
                        },
                        new
                        {
                            Id = 8,
                            DepartmentId = 2,
                            FirstName = "Julien",
                            IsDeveloper = false,
                            LastName = "Russell"
                        },
                        new
                        {
                            Id = 9,
                            DepartmentId = 4,
                            FirstName = "Yvonne",
                            IsDeveloper = false,
                            LastName = "Snider"
                        },
                        new
                        {
                            Id = 10,
                            DepartmentId = 1,
                            FirstName = "Jasmin",
                            IsDeveloper = true,
                            LastName = "Curtis"
                        });
                });

            modelBuilder.Entity("WiredBrainCoffe.EmployeeManager.Data.models.Employee", b =>
                {
                    b.HasOne("WiredBrainCoffe.EmployeeManager.Data.models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("WiredBrainCoffe.EmployeeManager.Data.models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
