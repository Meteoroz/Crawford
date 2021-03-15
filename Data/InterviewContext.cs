using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Data
{
    public partial class InterviewContext : DbContext, IInterviewContext
    {
        public InterviewContext()
        {
        }

        public InterviewContext(DbContextOptions<InterviewContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DevLossType> DevLossType { get; set; }
        public virtual DbSet<DevUser> DevUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DevLossType>(entity =>
            {
                entity.HasKey(e => e.LossTypeId)
                    .HasName("PK__dev_Loss__757E355409D32E4C");

                entity.ToTable("dev_LossType");

                entity.Property(e => e.LossTypeId)
                    .HasColumnName("LossTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LossTypeCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LossTypeDescription)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DevUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__dev_User__1788CCACC2F250D8");

                entity.ToTable("dev_User");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
