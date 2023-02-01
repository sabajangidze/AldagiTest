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
    public class PolisConfiguration : IEntityTypeConfiguration<Polis>
    {
        public void Configure(EntityTypeBuilder<Polis> builder)
        {
            builder.Property(p => p.PolisNumber).HasMaxLength(25).IsRequired();
        }
    }
}
