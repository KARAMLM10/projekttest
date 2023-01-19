﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projekttest.Data;

#nullable disable

namespace projekttest.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20230119133804_Initial migration")]
    partial class Initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("projekttest.Data.Calculator", b =>
                {
                    b.Property<int>("calculatorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("calculatorID"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Number1")
                        .HasColumnType("float");

                    b.Property<double>("Number2")
                        .HasColumnType("float");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("result")
                        .HasColumnType("float");

                    b.HasKey("calculatorID");

                    b.ToTable("calculators");
                });

            modelBuilder.Entity("projekttest.Data.RPSGAME", b =>
                {
                    b.Property<int>("rpsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("rpsID"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Scoure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("rpsID");

                    b.ToTable("RPSGAMEs");
                });

            modelBuilder.Entity("projekttest.Data.Shape", b =>
                {
                    b.Property<int>("shapeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("shapeID"), 1L, 1);

                    b.Property<double>("Area")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Perimeter")
                        .HasColumnType("float");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("shapeID");

                    b.ToTable("shapes");
                });
#pragma warning restore 612, 618
        }
    }
}
