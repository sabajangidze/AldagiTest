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
    public class UserPolisConfiguration : IEntityTypeConfiguration<UserPolis>
    {
        public void Configure(EntityTypeBuilder<UserPolis> builder)
        {
            builder.HasOne(u => u.User).WithMany(u => u.UserPolises).HasForeignKey(u => u.UserId).IsRequired();
            builder.HasOne(u => u.Polis).WithMany(u => u.UserPolises).HasForeignKey(u => u.PolisId).IsRequired();
        }
    }
}
