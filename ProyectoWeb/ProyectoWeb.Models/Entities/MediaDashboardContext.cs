using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyectoWeb.Models.Entities;

public partial class MediaDashboardContext : DbContext
{
    public MediaDashboardContext()
    {
    }

    public MediaDashboardContext(DbContextOptions<MediaDashboardContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Advertisement> Advertisements { get; set; }

    public virtual DbSet<MediaComponent> MediaComponents { get; set; }

    public virtual DbSet<MediaContent> MediaContents { get; set; }

    public virtual DbSet<News> News { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Weather> Weathers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=RUKIA\\SQLEXPRESS;Database=MediaDashboard;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Advertisement>(entity =>
        {
            entity.HasKey(e => e.AdId).HasName("PK__Advertis__7130D5AE0BF49FA8");

            entity.ToTable(tb => tb.HasTrigger("trg_Advertisements_EndDateValidation"));

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ImageUrl).HasMaxLength(500);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TargetUrl).HasMaxLength(500);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<MediaComponent>(entity =>
        {
            entity.HasKey(e => e.ComponentId).HasName("PK__MediaCom__D79CF04EFC574961");

            entity.HasIndex(e => e.ComponentName, "UQ__MediaCom__DB06D1C11B7B63FB").IsUnique();

            entity.Property(e => e.ComponentName).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(255);
        });

        modelBuilder.Entity<MediaContent>(entity =>
        {
            entity.HasKey(e => e.ContentId).HasName("PK__MediaCon__2907A81E1AF01E1B");

            entity.ToTable("MediaContent");

            entity.Property(e => e.ContentType).HasMaxLength(50);
            entity.Property(e => e.ContentUrl).HasMaxLength(500);
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.PublishedDate).HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(100);

            entity.HasOne(d => d.Component).WithMany(p => p.MediaContents)
                .HasForeignKey(d => d.ComponentId)
                .HasConstraintName("FK_MediaContent_Component");
        });

        modelBuilder.Entity<News>(entity =>
        {
            entity.HasKey(e => e.NewsId).HasName("PK__News__954EBDF34509B729");

            entity.Property(e => e.PublishedDate).HasColumnType("datetime");
            entity.Property(e => e.Source).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.Url).HasMaxLength(500);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4C185E702A");

            entity.HasIndex(e => e.Username, "UQ__Users__536C85E4C562A29D").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Users__A9D10534EEF48DD4").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Role).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<Weather>(entity =>
        {
            entity.HasKey(e => e.WeatherId).HasName("PK__Weather__0BF97BF5C9EE81AE");

            entity.ToTable("Weather");

            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Condition).HasMaxLength(50);
            entity.Property(e => e.Date).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
