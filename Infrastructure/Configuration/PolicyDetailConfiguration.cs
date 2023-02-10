using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration;

public class PolicyDetailConfiguration : IEntityTypeConfiguration<PolicyDetail>
{
    public void Configure(EntityTypeBuilder<PolicyDetail> builder)
    {
        builder.Property(p => p.CurrentPaid).HasPrecision(10, 2);
        builder.Property(p => p.OldPolicyNumber).HasMaxLength(25);
        builder.Property(p => p.LossCount).HasPrecision(10, 2);
        builder.Property(p => p.PaidLoss).HasPrecision(10, 2);
        builder.Property(p => p.Rateprojected).HasPrecision(10, 2);
        builder.HasOne(p => p.Policy).WithOne(p => p.PolicyDetail).HasForeignKey<Policy>(p => p.PolicyDetailId);
    }
}
