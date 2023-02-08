using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration
{
    public class UsersPolicyConfiguration : IEntityTypeConfiguration<UsersPolicies>
    {
        public void Configure(EntityTypeBuilder<UsersPolicies> builder)
        {
            builder.HasOne(u => u.User).WithMany(u => u.UsersPolicies).HasForeignKey(u => u.UserId).IsRequired();
            builder.HasOne(u => u.Policy).WithMany(u => u.UsersPolicies).HasForeignKey(u => u.PolicyId).IsRequired();
        }
    }
}
