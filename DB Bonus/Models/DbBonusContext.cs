using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DB_Bonus.Models;

public partial class DbBonusContext : DbContext
{
    public DbBonusContext()
    {
    }

    public DbBonusContext(DbContextOptions<DbBonusContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Donor> Donors { get; set; }
    public virtual DbSet<BloodDonation> BloodDonations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
                optionsBuilder.UseSqlServer("DefaultConnection");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Donor>(entity =>
        {
            entity.HasKey(e => e.DonorId);

            entity.ToTable("Donor");

            entity.Property(e => e.DonorId).HasColumnName("DonorID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DateOfBirth);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BloodType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Address)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BloodDonation>(entity =>
        {
            entity.HasKey(e => e.DonationId);

            entity.ToTable("BloodDonation");

            entity.Property(e => e.DonationId).HasColumnName("DonationID");
            entity.Property(e => e.DonorId).HasColumnName("DonorID");
            entity.Property(e => e.DonationDate);
            entity.Property(e => e.Quantity);
            entity.Property(e => e.BloodType)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Donor)
                .WithMany(p => p.Donations)
                .HasForeignKey(d => d.DonorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BloodDonation_Donor");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
