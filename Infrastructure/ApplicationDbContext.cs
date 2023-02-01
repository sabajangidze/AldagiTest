using Domain.Entities;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<AnnualPlan> AnnualPlans { get; set; }
        public virtual DbSet<Polis> Polises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
