using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HelpAssistant
{
    public partial class PraktContext : DbContext
    {
        public PraktContext()
        {
        }

        public PraktContext(DbContextOptions<PraktContext> options)
            : base(options)
        {
        }

        public virtual DbSet<StatusTask> StatusTask { get; set; }
        public virtual DbSet<Task> Task { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Prakt;Integrated Security=True");
            }
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatusTask>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusName).HasMaxLength(50);
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.TaskName).HasMaxLength(100);

                entity.HasOne(d => d.IdStatusNavigation)
                    .WithMany(p => p.Task)
                    .HasForeignKey(d => d.IdStatus)
                    .HasConstraintName("FK_Task_StatusTask");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.TaskIdUserNavigation)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK_Task_User");

                entity.HasOne(d => d.IdUserAcceptNavigation)
                    .WithMany(p => p.TaskIdUserAcceptNavigation)
                    .HasForeignKey(d => d.IdUserAccept)
                    .HasConstraintName("FK_Task_User1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Login)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Patronymic).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Surname).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
