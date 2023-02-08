using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class UsersSchemesConfiguration : IEntityTypeConfiguration<UsersSchemes>
{
    public void Configure(EntityTypeBuilder<UsersSchemes> builder)
    {
        builder.HasOne(u => u.User).WithMany(u => u.UsersSchemes).HasForeignKey(u => u.UserId).IsRequired().OnDelete(DeleteBehavior.ClientSetNull);
        builder.HasOne(u => u.Scheme).WithMany(u => u.UsersSchemes).HasForeignKey(u => u.SchemeId).IsRequired().OnDelete(DeleteBehavior.ClientSetNull);
    }
}
