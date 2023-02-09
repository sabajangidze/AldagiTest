using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class LicenseConfiguration : IEntityTypeConfiguration<License>
{
    public void Configure(EntityTypeBuilder<License> builder)
    {
        builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
        builder.Property(p => p.CascoType).HasMaxLength(25);
        builder.Property(p => p.TravelProduct).HasMaxLength(50).IsRequired();
        builder.HasOne(p => p.Scheme).WithMany(u => u.Licenses).HasForeignKey(p => p.SchemeId).IsRequired();
    }
}
