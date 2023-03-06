using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.Property(r => r.Type).IsRequired().HasMaxLength(50);
        builder.HasOne(r => r.User).WithOne(u => u.Role).HasForeignKey<User>(u => u.RoleId).IsRequired().OnDelete(DeleteBehavior.ClientSetNull);
        builder.HasOne(r => r.License).WithMany(p => p.Roles).HasForeignKey(r => r.LicenseId).IsRequired();
    }
}
