using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class PolicyConfiguration : IEntityTypeConfiguration<Policy>
{
    public void Configure(EntityTypeBuilder<Policy> builder)
    {
        builder.Property(p => p.PolicyNumber).HasMaxLength(25).IsRequired();
        builder.Property(p => p.SchedulePay).HasPrecision(10, 2);
        builder.Property(p => p.Payable).HasPrecision(10, 2);
        builder.Property(p => p.SumInsured).HasPrecision(10, 2);
        builder.Property(p => p.CurName).HasMaxLength(10).IsRequired();
        builder.Property(p => p.LimitCurrency).HasMaxLength(10).IsRequired();
        builder.Property(p => p.PremiumCurrency).HasMaxLength(10).IsRequired();
        builder.Property(p => p.Comission).HasMaxLength(25).IsRequired();
        builder.Property(p => p.Source).HasMaxLength(30).IsRequired();
        builder.Property(p => p.Intallment).HasMaxLength(25).IsRequired();
        builder.Property(p => p.PayType).HasMaxLength(30).IsRequired();
        builder.Property(p => p.Segment).HasMaxLength(30).IsRequired();
        builder.Property(p => p.SellSegment).HasMaxLength(30).IsRequired();
        builder.Property(p => p.SellSpot).HasMaxLength(35).IsRequired();
        builder.Property(p => p.SumInsured).HasMaxLength(25).IsRequired();
        builder.HasOne(p => p.License).WithMany(p => p.Policies).HasForeignKey(p => p.LicenseId).IsRequired().OnDelete(DeleteBehavior.ClientSetNull);
        builder.HasOne(p => p.Client).WithMany(p => p.Policies).HasForeignKey(p => p.ClientId).IsRequired().OnDelete(DeleteBehavior.ClientSetNull);
    }
}