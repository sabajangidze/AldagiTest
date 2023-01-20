using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Scheme> Schemes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var schemes = modelBuilder.Entity<Scheme>();
            var roles = modelBuilder.Entity<Role>();
            var users = modelBuilder.Entity<User>();

            schemes.Property(s => s.Name).IsRequired().HasMaxLength(50);
            schemes.Property(s => s.CreatedAt).IsRequired();

            roles.Property(r => r.Type).IsRequired().HasMaxLength(50);
            roles.Property(r => r.CreatedAt).IsRequired();
            roles.HasOne(r => r.User).WithOne(u => u.Role).HasForeignKey<User>(u => u.RoleId).IsRequired();

            users.Property(u => u.FirstName).IsRequired().HasMaxLength(50);
            users.Property(u => u.LastName).IsRequired().HasMaxLength(50);
            users.Property(u => u.PersonalId).IsRequired().HasMaxLength(11);
            users.Property(u => u.IsEmployee).IsRequired();
            users.Property(u => u.IsTaxPayer).IsRequired();
            users.Property(u => u.IsPensioPayer).IsRequired();
            users.Property(u => u.CreatedAt).IsRequired();
            users.HasOne(u => u.Scheme).WithMany(s => s.Users).HasForeignKey("SchemeId").IsRequired();

            base.OnModelCreating(modelBuilder);
        }
    }
}
