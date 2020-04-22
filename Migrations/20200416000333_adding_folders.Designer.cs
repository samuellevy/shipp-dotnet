﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using shipp;
using shipp.Data;

namespace shipp.Migrations
{
  [DbContext(typeof(MyDbContext))]
  [Migration("20200416000333_adding_folders")]
  partial class adding_folders
  {
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
          .HasAnnotation("ProductVersion", "3.1.3")
          .HasAnnotation("Relational:MaxIdentifierLength", 64);

      modelBuilder.Entity("shipp.Models.Folder", b =>
          {
            b.Property<int>("id")
                      .ValueGeneratedOnAdd()
                      .HasColumnType("int");

            b.Property<DateTime>("createdAt")
                      .HasColumnType("datetime(6)");

            b.Property<string>("description")
                      .HasColumnType("longtext CHARACTER SET utf8mb4");

            b.Property<string>("title")
                      .HasColumnType("longtext CHARACTER SET utf8mb4");

            b.Property<int>("year")
                      .HasColumnType("int");

            b.HasKey("id");

            b.ToTable("Folders");
          });
#pragma warning restore 612, 618
    }
  }
}
