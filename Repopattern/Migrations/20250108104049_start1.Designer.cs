﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repopattern.Context;

#nullable disable

namespace Repopattern.Migrations
{
    [DbContext(typeof(BatchDbContext))]
    [Migration("20250108104049_start1")]
    partial class start1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Repopattern.Models.Batch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Batches");
                });

            modelBuilder.Entity("Repopattern.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Repopattern.Models.User", b =>
                {
                    b.Property<int>("UserCode")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2")
                        .HasColumnOrder(4);

                    b.Property<int>("JoinigYear")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("UserName")
                        .HasColumnOrder(3);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnOrder(5);

                    b.HasKey("UserCode");

                    b.ToTable("UserDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
