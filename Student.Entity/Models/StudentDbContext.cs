using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Student.Entity.Models;

public partial class StudentDbContext : DbContext
{
    public StudentDbContext()
    {
    }

    public StudentDbContext(DbContextOptions<StudentDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<StudentMaster> Students { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Overriding Models
        modelBuilder.Entity<StudentMaster>(entity =>
        {
            entity.HasKey(e => e.StudentId);
            entity.ToTable("Students");
        });
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
