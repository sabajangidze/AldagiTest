using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class PolicyConfiguration : IEntityTypeConfiguration<Policy>
{
    public void Configure(EntityTypeBuilder<Policy> builder)
    {
        builder.Property(p => p.PolicyNumber).HasMaxLength(25).IsRequired();
        builder.Property(p => p.CurrentPaid).HasPrecision(10, 2);
        builder.Property(p => p.AllPaid).HasPrecision(10, 2);
        builder.Property(p => p.Payable).HasPrecision(10, 2);
        builder.Property(p => p.LossCount).HasPrecision(10, 2);
        builder.Property(p => p.PaidLoss).HasPrecision(10, 2);
        builder.HasOne(p => p.Product).WithMany(p => p.Policies).HasForeignKey(p => p.ProductId).IsRequired().OnDelete(DeleteBehavior.ClientSetNull);
        builder.HasOne(p => p.Client).WithMany(p => p.Policies).HasForeignKey(p => p.ClientId).IsRequired().OnDelete(DeleteBehavior.ClientSetNull);
    }
}