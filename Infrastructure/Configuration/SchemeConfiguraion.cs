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
    public class SchemeConfiguraion : IEntityTypeConfiguration<Scheme>
    {
        public void Configure(EntityTypeBuilder<Scheme> builder)
        {
            builder.Property(s => s.Name).IsRequired().HasMaxLength(50);
            builder.Property(s => s.CreatedAt).IsRequired();
        }
    }
}
