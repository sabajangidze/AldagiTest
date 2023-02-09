using Domain.Abstractions;

namespace Domain.Entities;

public class Role : IEntity<Guid>, IEntityAudit
{
    public Guid Id { get; set; }

    public string Type { get; set; }

    public int Hierarchy { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual User User { get; set; }

    public Guid UserId { get; set; }

    public virtual License License { get; set; }

    public Guid LicenseId { get; set; }
}
