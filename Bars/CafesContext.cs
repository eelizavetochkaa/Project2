using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bars;

public partial class CafesContext : DbContext
{
    public CafesContext()
    {
    }

    public CafesContext(DbContextOptions<CafesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bar> Bars { get; set; }

    public virtual DbSet<Matching> Matchings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=../../../Cafes.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bar>(entity =>
        {
            entity.ToTable("bars");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.HasOne(d => d.MatchingNavigation).WithMany(p => p.Bars).HasForeignKey(d => d.Matching);
        });

        modelBuilder.Entity<Matching>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
