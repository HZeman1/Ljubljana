using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace REST;

public partial class LjubljanaDeloContext : DbContext
{
    public LjubljanaDeloContext()
    {
    }

    public LjubljanaDeloContext(DbContextOptions<LjubljanaDeloContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Kopija> Kopijas { get; set; }

    public virtual DbSet<Vozilo> Vozilos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=LjubljanaDelo;Trusted_Connection=True;Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kopija>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Kopija");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KratkoImeVozila)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NamembnostVozila)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("namembnostVozila");
            entity.Property(e => e.Oprema)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Registracija)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StevilkaSledilneNaprave)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ZnamkaVozila)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vozilo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SeznamVo__3214EC2758C99040");

            entity.ToTable("Vozilo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KratkoImeVozila)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.NamembnostVozila)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("namembnostVozila");
            entity.Property(e => e.Oprema)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Registracija)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.ZnamkaVozila)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
