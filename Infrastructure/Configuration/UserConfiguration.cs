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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.PersonalId).IsRequired().HasMaxLength(11);
            builder.HasOne(u => u.Scheme).WithMany(s => s.Users).HasForeignKey(u => u.SchemeId).IsRequired().OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
