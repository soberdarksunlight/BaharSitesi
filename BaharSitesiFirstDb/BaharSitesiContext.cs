using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BaharSitesiFirstDb;

public partial class BaharSitesiContext : DbContext
{
    public BaharSitesiContext()
    {
    }

    public BaharSitesiContext(DbContextOptions<BaharSitesiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aidat> Aidats { get; set; }

    public virtual DbSet<Daire> Daires { get; set; }

    public virtual DbSet<DaireAidat> DaireAidats { get; set; }

    public virtual DbSet<EvSahipleri> EvSahipleris { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=DESKTOP-UQL2HJ9\\SQLEXPRESS;Initial Catalog=BaharSitesi;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aidat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Aidat");

            entity.Property(e => e.BaslangicTarihi).HasColumnType("datetime");
            entity.Property(e => e.BitisTarihi).HasColumnType("datetime");
        });

        modelBuilder.Entity<Daire>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Daire");

            entity.Property(e => e.Blok)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DaireAidat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DaireAidat");

            entity.Property(e => e.Dönem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SonÖdemeTarihi).HasColumnType("datetime");
            entity.Property(e => e.ÖdemeTarihi).HasColumnType("datetime");
        });

        modelBuilder.Entity<EvSahipleri>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EvSahipleri");

            entity.Property(e => e.Adi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Eposta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sifre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Soyadi)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TelefonNo)
                .HasMaxLength(13)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
