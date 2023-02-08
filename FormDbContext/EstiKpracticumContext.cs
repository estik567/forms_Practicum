using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace forms.Repositories.Models;

public partial class EstiKpracticumContext : DbContext,IContext
{
    public EstiKpracticumContext()
    {
    }

    public EstiKpracticumContext(DbContextOptions<EstiKpracticumContext> options)
        : base(options)
    {
    }

    //public virtual DbSet<Child> Children { get; set; }
    public DbSet<Child> children { get; set; }
    //public virtual DbSet<User> Users { get; set; }
    public DbSet<User> users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=sqlsrv;Initial Catalog=estiKPracticum;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Child>(entity =>
        {
            entity.ToTable("child");

            entity.Property(e => e.ChildId).HasColumnName("childId");
            entity.Property(e => e.ChildDateBorn)
                .HasColumnType("date")
                .HasColumnName("childDateBorn");
            entity.Property(e => e.ChildName)
                .HasMaxLength(20)
                .HasColumnName("childName");
            entity.Property(e => e.ChildTz).HasMaxLength(9);
            entity.Property(e => e.ParentTz).HasMaxLength(9);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("user");

            entity.Property(e => e.UserId).HasColumnName("userId");
            entity.Property(e => e.DateBorn)
                .HasColumnType("date")
                .HasColumnName("dateBorn");
            entity.Property(e => e.FirstName)
                .HasMaxLength(20)
                .HasColumnName("firstName");
            entity.Property(e => e.Hmo)
                .HasMaxLength(20)
                .HasColumnName("hmo");
            entity.Property(e => e.LastName)
                .HasMaxLength(20)
                .HasColumnName("lastName");
            entity.Property(e => e.MaleOrFemale)
                .HasMaxLength(20)
                .HasColumnName("maleOrFemale");
            entity.Property(e => e.Tz)
                .HasMaxLength(9)
                .HasColumnName("tz");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
