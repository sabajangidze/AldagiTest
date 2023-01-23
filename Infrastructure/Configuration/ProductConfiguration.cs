using Domain.Abstractions;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.CreatedAt).IsRequired();
            builder.Property(p => p.QuarterPercent).IsRequired();
            builder.Property(p => p.MonthlyPercent).IsRequired();
            builder.HasOne(p => p.Scheme).WithMany(u => u.Products).HasForeignKey("SchemeId").IsRequired();
        }
    }
}
