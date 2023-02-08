using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.Property(c => c.ClientName).IsRequired().HasMaxLength(50);
        builder.Property(c => c.ClientCode).IsRequired().HasMaxLength(25);
        builder.Property(c => c.ContrAgentType).IsRequired().HasMaxLength(25);
    }
}
