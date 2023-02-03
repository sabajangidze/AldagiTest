using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class PolisConfiguration : IEntityTypeConfiguration<Polis>
{
    public void Configure(EntityTypeBuilder<Polis> builder)
    {
        builder.Property(p => p.PolisNumber).HasMaxLength(25).IsRequired();
        builder.Property(p => p.CurrentPaid).HasPrecision(18, 2);
        builder.Property(p => p.AllPaid).HasPrecision(18, 2);
        builder.Property(p => p.Payable).HasPrecision(18, 2);
        builder.Property(p => p.LossCount).HasPrecision(18, 2);
        builder.Property(p => p.PaidLoss).HasPrecision(18, 2);
    }
}