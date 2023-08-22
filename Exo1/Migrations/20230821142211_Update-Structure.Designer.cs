﻿// <auto-generated />
using System;
using Exo1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Exo1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230821142211_Update-Structure")]
    partial class UpdateStructure
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Exo1.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("address_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Commune")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("commune");

                    b.Property<string>("Complement")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("complement");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<int?>("Number")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("number");

                    b.Property<int?>("PostalCode")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("postal_code");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}