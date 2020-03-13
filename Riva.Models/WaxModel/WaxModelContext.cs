using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Riva.Models.WaxModel
{
    public partial class WaxModelContext : DbContext
    {
        public WaxModelContext()
        {
        }

        public WaxModelContext(DbContextOptions<WaxModelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<C3dPrintLogs> C3dPrintLogs { get; set; }
        public virtual DbSet<WaxLogs> WaxLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=WaxModel;User Id=sa;Password=pass123456;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C3dPrintLogs>(entity =>
            {
                entity.ToTable("C3D_Print_Logs");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ItemPath)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Metal)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NameReference)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedBy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SampleReceivedManagerDate).HasColumnType("datetime");

                entity.Property(e => e.WaxReceivedCastingDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WaxLogs>(entity =>
            {
                entity.ToTable("Wax_logs");

                entity.Property(e => e.Customer)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Metal)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedBy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Style)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UnitsMadeBy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UnitsMadeDate).HasColumnType("datetime");

                entity.Property(e => e.UnitsReceivedBy)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UnitsReceivedDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
