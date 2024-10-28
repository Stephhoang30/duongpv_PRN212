using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Question2.Models;

public partial class Duongpv14PrnContext : DbContext
{
    public Duongpv14PrnContext()
    {
    }

    public Duongpv14PrnContext(DbContextOptions<Duongpv14PrnContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Lecturer> Lecturers { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentSubject> StudentSubjects { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Console.WriteLine(Directory.GetCurrentDirectory());
        IConfiguration config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", true, true)
        .Build();
        var strConn = config["ConnectionStrings:MyDatabase"];
        optionsBuilder.UseSqlServer(strConn);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Class>(entity =>
        {
            entity.Property(e => e.ClassName)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Lecturer>(entity =>
        {
            entity.Property(e => e.FullName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Note).HasColumnType("ntext");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.Property(e => e.FullName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Nationality).HasColumnType("ntext");
            entity.Property(e => e.Note).HasColumnType("ntext");

            entity.HasOne(d => d.Lecture).WithMany(p => p.Students)
                .HasForeignKey(d => d.LectureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Students_Lecturers");

            entity.HasMany(d => d.Classes).WithMany(p => p.Students)
                .UsingEntity<Dictionary<string, object>>(
                    "StudentClass",
                    r => r.HasOne<Class>().WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Student_Class_Classes"),
                    l => l.HasOne<Student>().WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Student_Class_Students"),
                    j =>
                    {
                        j.HasKey("StudentId", "ClassId");
                        j.ToTable("Student_Class");
                    });
        });

        modelBuilder.Entity<StudentSubject>(entity =>
        {
            entity.HasKey(e => new { e.StudentId, e.SubjectId });

            entity.ToTable("Student_Subject");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentSubjects)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Subject_Students");

            entity.HasOne(d => d.Subject).WithMany(p => p.StudentSubjects)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Student_Subject_Subjects");
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.Property(e => e.Subject1)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Subject");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
