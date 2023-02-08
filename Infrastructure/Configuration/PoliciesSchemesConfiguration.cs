using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class PoliciesSchemesConfiguration : IEntityTypeConfiguration<PoliciesSchemes>
    {
        public void Configure(EntityTypeBuilder<PoliciesSchemes> builder)
        {
            builder.HasOne(u => u.Policy).WithMany(u => u.PoliciesSchemes).HasForeignKey(u => u.PolicyId).IsRequired();
            builder.HasOne(u => u.Scheme).WithMany(u => u.PoliciesSchemes).HasForeignKey(u => u.SchemeId).IsRequired();
        }
    }
}
