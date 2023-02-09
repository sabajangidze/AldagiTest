using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class PlanConfiguration : IEntityTypeConfiguration<Plan>
{
    public void Configure(EntityTypeBuilder<Plan> builder)
    {
        builder.Property(p => p.ClientType).IsRequired();
        builder.HasOne(p => p.User).WithMany(u => u.Plans).HasForeignKey(p => p.UserId).IsRequired();
        builder.HasOne(p => p.License).WithMany(p => p.Plans).HasForeignKey(p => p.LicenseId).OnDelete(DeleteBehavior.ClientSetNull);
    }
}
