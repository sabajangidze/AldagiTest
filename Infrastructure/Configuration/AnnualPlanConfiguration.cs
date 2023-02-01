using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class AnnualPlanConfiguration : IEntityTypeConfiguration<AnnualPlan>
{
    public void Configure(EntityTypeBuilder<AnnualPlan> builder)
    {
        builder.Property(a => a.Month).HasMaxLength(20).IsRequired();
        builder.HasOne(a => a.Plan).WithMany(p => p.AnnualPlans).HasForeignKey(a => a.PlanId).IsRequired();
    }
}
