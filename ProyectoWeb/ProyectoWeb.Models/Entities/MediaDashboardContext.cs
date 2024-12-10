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

    public virtual DbSet<ComponentExchangeRate> ComponentExchangeRates { get; set; }

    public virtual DbSet<ComponentWeather> ComponentWeathers { get; set; }

    public virtual DbSet<ExchangeRate> ExchangeRates { get; set; }

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
        modelBuilder.Entity<ComponentExchangeRate>(entity =>
        {
            entity.HasKey(e => e.ComponentExchangeId).HasName("PK__Componen__19EF155D93FFF17B");

            entity.ToTable("ComponentExchangeRate");

            entity.HasOne(d => d.Component).WithMany(p => p.ComponentExchangeRates)
                .HasForeignKey(d => d.ComponentId)
                .HasConstraintName("FK_ComponentExchange_Component");

            entity.HasOne(d => d.Rate).WithMany(p => p.ComponentExchangeRates)
                .HasForeignKey(d => d.RateId)
                .HasConstraintName("FK_ComponentExchange_Rate");
        });

        modelBuilder.Entity<ComponentWeather>(entity =>
        {
            entity.HasKey(e => e.ComponentWeatherId).HasName("PK__Componen__B17A4CE7C2C67BED");

            entity.ToTable("ComponentWeather");

            entity.HasOne(d => d.Component).WithMany(p => p.ComponentWeathers)
                .HasForeignKey(d => d.ComponentId)
                .HasConstraintName("FK_ComponentWeather_Component");

            entity.HasOne(d => d.Weather).WithMany(p => p.ComponentWeathers)
                .HasForeignKey(d => d.WeatherId)
                .HasConstraintName("FK_ComponentWeather_Weather");
        });

        modelBuilder.Entity<ExchangeRate>(entity =>
        {
            entity.HasKey(e => e.RateId).HasName("PK__Exchange__58A7CF5CC59D850A");

            entity.Property(e => e.Currency).HasMaxLength(10);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.ExchangeRate1)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("ExchangeRate");
        });

        modelBuilder.Entity<MediaComponent>(entity =>
        {
            entity.HasKey(e => e.ComponentId).HasName("PK__MediaCom__D79CF04E173E3B57");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MediaContent>(entity =>
        {
            entity.HasKey(e => e.ContentId).HasName("PK__MediaCon__2907A81ED651F3E4");

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
            entity.HasKey(e => e.NewsId).HasName("PK__News__954EBDF33D891209");

            entity.Property(e => e.PublishedDate).HasColumnType("datetime");
            entity.Property(e => e.Source).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.Url).HasMaxLength(500);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4CF106E73A");

            entity.HasIndex(e => e.Username, "UQ__Users__536C85E495E7953D").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Users__A9D10534FA1D64E4").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Role).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<Weather>(entity =>
        {
            entity.HasKey(e => e.WeatherId).HasName("PK__Weather__0BF97BF50F31BC24");

            entity.ToTable("Weather");

            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Condition).HasMaxLength(50);
            entity.Property(e => e.Date).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
