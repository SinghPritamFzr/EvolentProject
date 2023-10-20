﻿// <auto-generated />
using System;
using Evolent.DomainLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Evolent.DomainLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231020095154_EvolentDBConstraints")]
    partial class EvolentDBConstraints
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Evolent.DomainLayer.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("emailaddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("lastname")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "firstname", "lastname", "emailaddress" }, "IX_FLE_Constraint")
                        .IsUnique();

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
