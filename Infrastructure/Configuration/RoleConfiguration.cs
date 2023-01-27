﻿
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(r => r.Type).IsRequired().HasMaxLength(50);
            builder.Property(r => r.CreatedAt).IsRequired();
            builder.HasOne(r => r.User).WithOne(u => u.Role).HasForeignKey<User>(u => u.RoleId).IsRequired();
            builder.HasOne(r => r.Product).WithMany(p => p.Roles).HasForeignKey(r => r.ProductId).IsRequired();
        }
    }
}
