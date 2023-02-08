using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Entities;

public class Product : IEntity<Guid>, IEntityAudit
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public double Percent { get; set; }

    public PercentType Type { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Scheme Scheme { get; set; }

    public Guid SchemeId { get; set; }

    public virtual ICollection<Role> Roles { get; set; }
    public virtual ICollection<Plan> Plans { get; set; }
    public virtual ICollection<Policy> Policies { get; set; }
}
