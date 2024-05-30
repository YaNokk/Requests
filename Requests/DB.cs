using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Requests
{
    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comments>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<Requests>()
                .Property(e => e.homeTechType)
                .IsUnicode(false);

            modelBuilder.Entity<Requests>()
                .Property(e => e.homeTechModel)
                .IsUnicode(false);

            modelBuilder.Entity<Requests>()
                .Property(e => e.problemDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Requests>()
                .Property(e => e.repairParts)
                .IsUnicode(false);

            modelBuilder.Entity<Requests>()
                .HasMany(e => e.Comments)
                .WithRequired(e => e.Requests)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Requests)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.fio)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Comments)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.masterID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Requests)
                .WithRequired(e => e.Users)
                .HasForeignKey(e => e.clientID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Users>()
                .HasMany(e => e.Requests1)
                .WithRequired(e => e.Users1)
                .HasForeignKey(e => e.masterID)
                .WillCascadeOnDelete(false);
        }
    }
}
