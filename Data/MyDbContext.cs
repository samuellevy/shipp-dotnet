﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using shipp.Models;

namespace shipp.Data
{
  public partial class MyDbContext : DbContext
  {
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseMySql("server=localhost;user id=root;database=shipp_v1", x => x.ServerVersion("10.4.11-mariadb"));
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    // Entities
    public DbSet<Folder> Folders { get; set; }
    public DbSet<Sheet> Sheets { get; set; }
  }
}
